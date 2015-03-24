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

            string trans_id, cust_id, store_id, reg_id, s_date, e_date;
            SearchQueue sQueue = new SearchQueue();
            Settings st = new Settings();

            Console.Write("Please enter the transaction id: ");
            trans_id = Console.ReadLine();
            Console.Write("Please enter the customer id: ");
            cust_id = Console.ReadLine();
            Console.Write("Please enter the store id: ");
            store_id = Console.ReadLine();
            Console.Write("Please enter the region id: ");
            reg_id = Console.ReadLine();
            Console.Write("Please enter the starting date (in MMDDYYY format): ");
            s_date = Console.ReadLine();
            Console.Write("Please enter the ending date (x if it is not a range): ");
            e_date = Console.ReadLine();

            string invoice = trans_id + "." + cust_id + "." + store_id + "." + reg_id + "." + s_date + "." + e_date;

            Console.Write(invoice);

            //sQueue.addSearch("0.1.13.3.06262010.x");
            //sQueue.addSearch("0.1.69.9.01142012.x");
            //sQueue.addSearch("0.2.60.2.04162010.x");
            //sQueue.addSearch(".....");

            
            Finder myF = new Finder(ref sQueue, ref st);
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
