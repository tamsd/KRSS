using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceFinder
{
    namespace BackEnd{
        class Results
        {
            private int size;
            public int Size{
                get { return size; }
            }
            private List<Invoice> invoices;
            public Results() {
                this.size = 0;
                this.invoices = new List<Invoice>();
            }
            public Results(ref List<Invoice> invoices) {        
                this.invoices = invoices;
                this.size = invoices.Count;
            }
            public Invoice getInvoice(int i){
                return this.invoices[i];
            }

        }
    }
}
