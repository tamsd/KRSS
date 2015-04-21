using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceFinder
{
    namespace BackEnd{
        public class Results
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


            public void displayInvoices(){
                foreach(KeyValuePair<string, Invoice> entry in invoices){
                    Console.WriteLine(entry.Value);
                }
            }

        }
    }
}
