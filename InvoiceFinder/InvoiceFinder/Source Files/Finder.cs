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
            private List<Invoice> results;  //List containing Invoice Objects created based on found path names
            private SearchQueue searchQ; //Work order of seach objects
            private Settings sett; //file paths


            /*default constructor*/
            public Finder()
            {
                searchQ = new SearchQueue();
                results = new List<Invoice>();
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
                results = new List<Invoice>();
                other_folders = new List<string>();
                getFoldersFromSettings();
                
            }

            private void getFoldersFromSettings(){
                stores_folder = sett.getFinalDestination();
                archive_1 = sett.getArchiveA();
                archive_2 = sett.getArchiveB();
                for(int i=0; i<sett.otherPathCount(); i++){
                    other_folders.Add(sett.getOtherPath(i));
                }
            }

            //Takes a full path p leadng to a file, an invoice obj, and f - the parent of p
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
                        string[] invoice_attributes = filename.Split(new Char[] { '.' });
                        inv.Store_id = invoice_attributes[0];
                        inv.Reg_id = invoice_attributes[1];
                        inv.Trans_id = invoice_attributes[2];
                        inv.Cust_id = invoice_attributes[3];
                        inv.Date = invoice_attributes[4];
                        return true;
                    }
                    else{
                        return false;
                    }
                }
                catch (Exception e) {
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
            public List<Invoice> execute() {
                //update all the search paths
                getFoldersFromSettings();

                Search currentSearch = null;
                string path = "";
                    //search the final destination first
                for (int i = 0; i < searchQ.searchCount(); i++) {
                    currentSearch = searchQ.getSearch(i);
                    path = construct_search_path(ref currentSearch, stores_folder);
                    Invoice currentInvoice = new Invoice();
                    if (search(path, ref currentInvoice, stores_folder))
                    {
                        results.Add(currentInvoice);
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
                            results.Add(currentInvoice);
                        }
                    }
                }
                    //search the two archives last
                for (int i = 0; i < searchQ.searchCount(); i++)
                {
                    currentSearch = searchQ.getSearch(i);
                    path = construct_search_path(ref currentSearch, archive_1);
                    Invoice currentInvoice = new Invoice();
                    if (search(path, ref currentInvoice, archive_1))
                    {
                        results.Add(currentInvoice);
                    }
                }
                for (int i = 0; i < searchQ.searchCount(); i++)
                {
                    currentSearch = searchQ.getSearch(i);
                    path = construct_search_path(ref currentSearch, archive_2);
                    Invoice currentInvoice = new Invoice();
                    if (search(path, ref currentInvoice, archive_2))
                    {
                        results.Add(currentInvoice);
                    }
                }
                return results;
            }

        }
    }
}
