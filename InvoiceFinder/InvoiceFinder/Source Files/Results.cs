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

            public IEnumerator<Invoice> GetEnumerator()
            {
                return invoices.Values.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }
    }
}
