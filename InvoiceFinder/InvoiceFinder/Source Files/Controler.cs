using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InvoiceFinder.BackEnd;

namespace InvoiceFinder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //test
            SearchQueue sQueue = new SearchQueue();
            sQueue.addSearch("0.1.13.3.06262010.x");
            sQueue.addSearch("0.1.69.9.01142012.x");
            sQueue.addSearch("0.2.60.2.04162010.x");
            sQueue.addSearch(".....");

            Finder myF = new Finder(ref sQueue);
            List<Invoice> r = myF.execute();
            Results myR = new Results(ref r);
            for (int i = 0; i < myR.Size; i++ )
            {
                Console.WriteLine(myR.getInvoice(i));
            }

            return;


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
