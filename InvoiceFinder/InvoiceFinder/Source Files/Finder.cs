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
            /*default constructor*/
            public Finder() {
                searchQ= new SearchQueue();
            }
            /*single arg constructor*/
            public Finder(ref SearchQueue sq) {
                searchQ = sq;
            }

            private List<Invoice> results;  //List containing Invoice Objects created based on found path names
            private SearchQueue searchQ; //Work order of seach objects

            private Invoice search(string p, Invoice inv) {
                if (File.Exists(p)) {

                    return inv;
                }
                else {
                    return null;
                }
            }

            private List<Invoice> execute() {
                Search currentSearch = null;
                Invoice currentInvoice = null;
                string path = "";
                for (int i = 0; i < searchQ.searchCount(); i++) {
                    currentSearch = searchQ.getSearch(i);
                    //construct search path: C:\PPG + currentSearch.getCustid() +"." + ... + date + .pdf;
                    currentInvoice = search(path, currentInvoice);
                    if(currentInvoice != null){

                    }
                    Console.WriteLine(path);
                    //search(path);
                }
                return results;
            }

        }
    }
}
