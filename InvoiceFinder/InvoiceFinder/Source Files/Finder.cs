using System;
using System.IO;
using System.Collections.Generic;
using InvoiceFinder.BackEnd;

namespace InvoiceFinder
{
    namespace BackEnd
    {
        public class Finder
        {
            private string archive_1;
            private string archive_2;
            private List<string> other_folders; 
            private string stores_folder;
            private Dictionary<string, Invoice> results;  //List containing Invoice Objects created based on found path names
            private SearchQueue searchQ; //Work order of seach objects
            private Settings sett; //file paths


            /*default constructor*/
            public Finder()
            {
                searchQ = new SearchQueue();
                results = new Dictionary<string, Invoice>();
                other_folders = new List<string>();
                    //these do not need to be set for now.
                //archive_1 = @"C:\PPG\archives\archive_1"; //need to change these to get info from setting object
                //archive_2 = @"C:\PPG\archives\archive_2";
                //temp_folder1 = @"C:\PPG\temp_holders\temp_holder_1";
                //temp_folder2 = @"C:\PPG\temp_holders\temp_holder_2";
                //stores_folder = @"C:\PPG\stores";
            }

            /*double arg constructor*/
            public Finder(ref SearchQueue sq, ref Settings st)
            {
                searchQ = sq;
                sett = st;
                results = new Dictionary<string, Invoice>();
                other_folders = new List<string>();
               // getFoldersFromSettings(); *redundant call unless we implement a dictioranry for the "other_folders"
                
            }

            private void getFoldersFromSettings(){
                stores_folder = sett.getFinalDestination();
                archive_1 = sett.getArchiveA();
                archive_2 = sett.getArchiveB();
                for(int i=0; i<sett.otherPathCount(); i++){
                    other_folders.Add(sett.getOtherPath(i));
                }
            }

            //Takes a full path p leading to a file, an invoice obj, and f - the parent of p
            //If the the file is found the invoice object's attributes are set and the function returns true signaling success 
            private bool search(string p, ref Invoice inv, string f)
            {
                try {
                    if(File.Exists(p)){
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
                        if(f != stores_folder + "\\" + inv.Store_id){ //files parent is not a store folder aka final destination folder
                            try{
                                string dest = stores_folder + "\\" + inv.Store_id +"\\"+ inv.File_name;
                                File.Copy(p, dest);
                                inv.Final_destination = dest;
                            }
                            catch (Exception e){
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
                catch (Exception e) {
                    inv.Discovered = false;
                    Console.WriteLine(e);
                    return false;
                }
            }

            private string construct_search_path(ref Search searchObj, string folder) {
                string path = "";
                path += folder;
                path += "\\";
                path += searchObj.StoreID;
                path += ".";
                path += searchObj.RegID;
                path += ".";
                path += searchObj.TransID;
                path += ".";
                path += searchObj.CustID;
                path += ".";
                path += searchObj.SDate; //needs to be fixed
                path += ".pdf";
                return path;
            }

            /*iterates through searchQ and executes each search object*/
            public Dictionary<string, Invoice> execute() {
                //update all the search paths
                getFoldersFromSettings();

                Search currentSearch = null;
                string path = "";
                    //search the final destination first
                for (int i = 0; i < searchQ.searchCount(); i++) {
                    currentSearch = searchQ.getSearch(i);
                    string parent = stores_folder + "\\" + currentSearch.StoreID;
                    path = construct_search_path(ref currentSearch, parent);
                    Invoice currentInvoice = new Invoice();
                    if (search(path, ref currentInvoice, parent))
                    {
                        try {
                            results.Add(currentInvoice.File_name, currentInvoice);
                        }
                        catch (Exception e){
                            //key is either null or key laredy exists
                        }
                    }
                }
          
                    //search the two archives
                for (int i = 0; i < searchQ.searchCount(); i++)
                {
                    currentSearch = searchQ.getSearch(i);
                    path = construct_search_path(ref currentSearch, archive_1);
                    Invoice currentInvoice = new Invoice();
                    if (search(path, ref currentInvoice, archive_1))
                    {
                        try
                        {
                            results.Add(currentInvoice.File_name, currentInvoice);
                        }
                        catch (Exception e)
                        {
                            //key is either null or key laredy exists
                        }
                    }
                }
                for (int i = 0; i < searchQ.searchCount(); i++)
                {
                    currentSearch = searchQ.getSearch(i);
                    path = construct_search_path(ref currentSearch, archive_2);
                    Invoice currentInvoice = new Invoice();
                    if (search(path, ref currentInvoice, archive_2))
                    {
                        try
                        {
                            results.Add(currentInvoice.File_name, currentInvoice);
                        }
                        catch (Exception e)
                        {
                            //key is either null or key laredy exists
                        }
                    }
                }

                //search all the "other folders." The temp folders should be included in here
                for (int k = 0; k < other_folders.Count; k++)
                {
                    for (int i = 0; i < searchQ.searchCount(); i++)
                    {
                        currentSearch = searchQ.getSearch(i);
                        path = construct_search_path(ref currentSearch, other_folders[k]);
                        Invoice currentInvoice = new Invoice();
                        if (search(path, ref currentInvoice, other_folders[k]))
                        {
                            try
                            {
                                results.Add(currentInvoice.File_name, currentInvoice);
                            }
                            catch (Exception e)
                            {
                                //key is either null or key already exists
                            }
                        }
                    }
                }

                return results;
            }

        }
    }
}
