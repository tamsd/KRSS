using System;
using System.IO;
using System.Collections.Generic;
using InvoiceFinder.BackEnd;

namespace InvoiceFinder
{
    namespace BackEnd
    {
        class Finder
        {
            private string archive_1;
            private string archive_2;
            private string temp_folder1;
            private string temp_folder2;
            private string stores_folder;
            private List<Invoice> results;  //List containing Invoice Objects created based on found path names
            private SearchQueue searchQ; //Work order of seach objects

            /*default constructor*/
            public Finder()
            {
                searchQ = new SearchQueue();
                results = new List<Invoice>();
                archive_1 = @"C:\PPG\archives\archive_1"; //need to change these to get info from setting object
                archive_2 = @"C:\PPG\archives\archive_2";
                temp_folder1 = @"C:\PPG\temp_holders\temp_holder_1";
                temp_folder2 = @"C:\PPG\temp_holders\temp_holder_2";
                stores_folder = @"C:\PPG\stores";
            }

            /*single arg constructor*/
            public Finder(ref SearchQueue sq)
            {
                searchQ = sq;
                results = new List<Invoice>();
                archive_1 = @"C:\PPG\archives\archive_1";
                archive_2 = @"C:\PPG\archives\archive_2";
                temp_folder1 = @"C:\PPG\temp_holders\temp_holder_1";
                temp_folder2 = @"C:\PPG\temp_holders\temp_holder_2";
                stores_folder = @"C:\PPG\stores";
            }


            private Invoice search(string p, Invoice inv) {
                if (File.Exists(p)) {
                    return inv;
                }
                else {
                    return null;
                }
            }

            private string construct_search_path(ref Search searchObj, string folder) {
                string path = "";
                path += archive_1;
                path += "\\";
                path += searchObj.StoreID;
                path += ".";
                path += searchObj.RegID;
                path += ".";
                path += searchObj.CustID;
                path += ".";
                path += searchObj.TransID;
                path += ".";
                path += searchObj.SDate;
                path += ".pdf";
                return path;
            }

            /*iterates through searchQ and executes each search object*/
            public List<Invoice> execute() {
                Search currentSearch = null;
                Invoice currentInvoice = new Invoice();
                string path = "";
                for (int i = 0; i < searchQ.searchCount(); i++) {
                    currentSearch = searchQ.getSearch(i);
                    path = construct_search_path(ref currentSearch, archive_1);
                    currentInvoice = search(path, currentInvoice);
                    if(currentInvoice != null){
                        results.Add(currentInvoice);
                    }
                }
                return results;
            }

        }
    }
}
