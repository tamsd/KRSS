using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceFinder
{
    namespace BackEnd{
        public class Results : IEnumerable<Invoice>
        {
            private int size;
            private Dictionary<string, Invoice> invoices;

            public int Size{
                get { return size; }
            }

            /*Default constructor*/
            public Results() {
                this.size = 0;
                this.invoices = new Dictionary<string, Invoice>();
            }

            /*Single arge constructor sets results equal to the dictiornary of invoices received*/
            public Results(ref Dictionary<string, Invoice> invoices) {        
                this.invoices = invoices;
                this.size = invoices.Count;
            }

            /*displays each entry in the invoice dictionary to the console*/
            public void displayInvoices(){
                foreach(KeyValuePair<string, Invoice> entry in invoices){
                    Console.WriteLine(entry.Value);
                }
            }

            /*copies contents of dictionary into invoices, whatever invoices used to contain is gone*/
            public void copyDictionary(Dictionary<string, Invoice> dict){
                invoices = new Dictionary<string, Invoice>(dict);
            }

            /*Sort invoice Dictionary by store ascending*/
            public void sortByStore(string order){
                Dictionary<string, Invoice> newDict = new Dictionary<string, Invoice>();
                if(order == "ascending"){
                    var sortedDict = from entry in invoices orderby entry.Value.Store_id ascending select entry;
                    foreach (KeyValuePair<string, Invoice> entry in sortedDict)
                    {
                        newDict.Add(entry.Key, entry.Value);
                    }
                }
                else if(order == "descending"){
                    var sortedDict = from entry in invoices orderby entry.Value.Store_id descending select entry;
                    foreach (KeyValuePair<string, Invoice> entry in sortedDict)
                    {
                        newDict.Add(entry.Key, entry.Value);
                    }
                }
                copyDictionary(newDict);
            }

            /*Sort Invoice Dictionary by Customer ascending*/
            public void sortByCustomer(string order){
                Dictionary<string, Invoice> newDict = new Dictionary<string, Invoice>();
                if (order == "ascending")
                {
                    var sortedDict = from entry in invoices orderby entry.Value.Cust_id ascending select entry;
                    foreach (KeyValuePair<string, Invoice> entry in sortedDict)
                    {
                        newDict.Add(entry.Key, entry.Value);
                    }
                }
                else if (order == "descending")
                {
                    var sortedDict = from entry in invoices orderby entry.Value.Cust_id descending select entry;
                    foreach (KeyValuePair<string, Invoice> entry in sortedDict)
                    {
                        newDict.Add(entry.Key, entry.Value);
                    }
                }         
                copyDictionary(newDict);
            }

            /*Sort Invoice Dictionary by Date ascending*/
            public void sortByDate(string order){
                Dictionary<string, Invoice> newDict = new Dictionary<string, Invoice>();
                if (order == "ascending")
                {
                    var sortedDict = from entry in invoices orderby entry.Value.Date ascending select entry; //*************Date needs to be changed from the format of 01281999
                    foreach (KeyValuePair<string, Invoice> entry in sortedDict)
                    {
                        newDict.Add(entry.Key, entry.Value);
                    }
                }
                else if (order == "descending")
                {
                    var sortedDict = from entry in invoices orderby entry.Value.Date descending select entry; //*************Date needs to be changed from the format of 01281999
                    foreach (KeyValuePair<string, Invoice> entry in sortedDict)
                    {
                        newDict.Add(entry.Key, entry.Value);
                    }
                }

                copyDictionary(newDict);
            }

            /*Implement Ienumerable for invoices*/
            public IEnumerator<Invoice> GetEnumerator() {
                return invoices.Values.GetEnumerator();
            }
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
                return this.GetEnumerator();
            }
        }
    }
}
