/*
 * Author(s):
 * Date:
 * Description:
*/
using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using InvoiceFinder.BackEnd;

namespace InvoiceFinder
{
    namespace BackEnd
    {
        public class Finder
        {
            private Dictionary<string, Invoice> results;    //Dictionay of found files key=>value is filename.pdf=>invObj 
            private SearchQueue searchQ;                    //The Work order of seach objects
            private Settings sett;                          //Used to get search folders
            private List<string> search_paths;              //Stores all the possible search paths that each search object represents. main use is for date range handling

            /* default constructor intentionally empty and unused */
            public Finder(){ }

            /* double arg constructor */
            public Finder(ref SearchQueue sq, ref Settings st){
                searchQ = sq;
                sett = st;
                results = new Dictionary<string, Invoice>();    //will be edited by execute()
                search_paths = new List<string>();              //will be edited by execute()
            }

            /* function used to convert a string MMddyyyy to returns 01/01/0001 if error*/
            public static DateTime convertStringDate(string d){
                DateTime dt = new DateTime();
                try{
                    dt = DateTime.ParseExact(d, "MMddyyyy", new CultureInfo("en-US"));
                }
                catch (FormatException){
                    //error with passed in string, not sure if we should popup msg here
                }
                return dt;
            }

            //private void getFoldersFromSettings()
            //{
            //    stores_folder = sett.getFinalDestination();
            //    archive_1 = sett.getArchiveA();
            //    archive_2 = sett.getArchiveB();
            //    for (int i = 0; i < sett.otherPathCount(); i++)
            //    {
            //        other_folders.Add(sett.getOtherPath(i));
            //    }
            //}

            //Takes a full path p leading to a file, an invoice obj, and f - the parent of p
            //If the the file is found the invoice object's attributes are set and the function returns true signaling success 
            private bool search(string p, ref Invoice inv, string f){
                try{
                    if (File.Exists(p)){
                        inv.Discovered_path = p;
                        inv.Discovered = true;
                        inv.Parent = f;
                        string[] slash_split = p.Split(new Char[] { '\\' });
                        string filename = slash_split[slash_split.Length - 1];
                        inv.File_name = filename;
                        string[] invoice_attributes = filename.Split(new Char[] { '.' });
                        inv.Store_id = invoice_attributes[0];
                        inv.Reg_id = invoice_attributes[1];
                        inv.Trans_id = invoice_attributes[2];
                        inv.Cust_id = invoice_attributes[3];
                        inv.Date = invoice_attributes[4];
                        inv.String_Date = invoice_attributes[4];
                        inv.Date_Time_Date = convertStringDate(invoice_attributes[4]);
                        //check if in search range
                        if (f != sett.getFinalDestination() + "\\" + inv.Store_id){ //files parent is not a store folder aka final destination folder
                            try{
                                string dest = sett.getFinalDestination() + "\\" + inv.Store_id + "\\" + inv.File_name;
                                File.Copy(p, dest);
                                inv.Final_destination = dest;
                            }
                            catch (Exception e){
                                //file copy error
                            }
                        }
                        else{
                            inv.Final_destination = inv.Discovered_path;
                        }
                        return true;
                    }
                    else{
                        return false;
                    }
                }
                catch (Exception e){
                    inv.Discovered = false;
                    Console.WriteLine(e);
                    return false;
                }
            }

            private string construct_search_path(string partial_filename, string folder){
                string path = "";
                path += folder;
                path += "\\";
                path += partial_filename;
                path += ".pdf";
                return path;
            }

            /*iterates through searchQ and executes each search object*/
            public Dictionary<string, Invoice> execute(){
                ////update all the search paths
                //getFoldersFromSettings();
                string path = "";
                List<string> file_names;
                Search currentSearch = null;
                //search the final destination first
                for (int i = 0; i < searchQ.searchCount(); i++){
                    currentSearch = searchQ.getSearch(i);
                    file_names = currentSearch.get_filenames_list();
                    foreach (String s in file_names){
                        string parent = sett.getFinalDestination() + "\\" + currentSearch.StoreID; //construct parent folder based on store folder that holds all stores
                        path = construct_search_path(s, parent);
                        Invoice currentInvoice = new Invoice();
                        if (search(path, ref currentInvoice, parent)){
                            try{
                                results.Add(currentInvoice.File_name, currentInvoice);
                            }
                            catch (Exception e){
                                //key is either null or key laredy exists
                            }
                        }
                    }
                }
                //search the archives
                for (int k = 0; k < sett.Archive_FoldersCount(); k++){
                    for (int i = 0; i < searchQ.searchCount(); i++){
                        currentSearch = searchQ.getSearch(i);
                        file_names = currentSearch.get_filenames_list();
                        foreach (String s in file_names){
                            path = construct_search_path(s, sett.getArchive_Folder(k));
                            Invoice currentInvoice = new Invoice();
                            if (search(path, ref currentInvoice, sett.getArchive_Folder(k))){
                                try{
                                    results.Add(currentInvoice.File_name, currentInvoice);
                                }
                                catch (Exception e){
                                    //key is either null or key laredy exists
                                }
                            }
                        }
                    }
                }
                
                //for (int i = 0; i < searchQ.searchCount(); i++)
                //{
                //    currentSearch = searchQ.getSearch(i);
                //    file_names = currentSearch.get_filenames_list();
                //    foreach (String s in file_names)
                //    {
                //        path = construct_search_path(s, archive_2);
                //        Invoice currentInvoice = new Invoice();
                //        if (search(path, ref currentInvoice, archive_2))
                //        {
                //            try
                //            {
                //                results.Add(currentInvoice.File_name, currentInvoice);
                //            }
                //            catch (Exception e)
                //            {
                //                //key is either null or key laredy exists
                //            }
                //        }
                //    }
                //}

                //search the temp folders
                for (int k = 0; k < sett.Temp_FoldersCount(); k++){
                    for (int i = 0; i < searchQ.searchCount(); i++){
                        currentSearch = searchQ.getSearch(i);
                        file_names = currentSearch.get_filenames_list();
                        foreach (String s in file_names){
                            path = construct_search_path(s, sett.getTempFolder(k));
                            Invoice currentInvoice = new Invoice();
                            if (search(path, ref currentInvoice, sett.getTempFolder(k))){
                                try{
                                    results.Add(currentInvoice.File_name, currentInvoice);
                                }
                                catch (Exception e){
                                    //key is either null or key laredy exists
                                }
                            }
                        }
                    }
                }
                //search all the "other folders."
                for (int k = 0; k < sett.Other_FolderCount(); k++){
                    for (int i = 0; i < searchQ.searchCount(); i++){
                        currentSearch = searchQ.getSearch(i);
                        file_names = currentSearch.get_filenames_list();
                        foreach (String s in file_names){
                            path = construct_search_path(s, sett.getOther_Folder(k));
                            Invoice currentInvoice = new Invoice();
                            if (search(path, ref currentInvoice, sett.getOther_Folder(k))){
                                try{
                                    results.Add(currentInvoice.File_name, currentInvoice);
                                }
                                catch (Exception e){
                                    //key is either null or key laredy exists
                                }
                            }
                        }
                    }
                }
                return results;
            }
        }
    }
}
