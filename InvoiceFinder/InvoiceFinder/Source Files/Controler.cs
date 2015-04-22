﻿using System;
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

           // string trans_id, cust_id, store_id, reg_id, s_date, e_date;
            SearchQueue sQueue = new SearchQueue();
            Settings st = new Settings();
            Finder myF = new Finder(ref sQueue, ref st);
            Results myR = new Results();

            st.setArchiveA(@"C:\PPG\archives\archive_1");
            st.setArchiveB(@"C:\PPG\archives\archive_2");
            st.setFinalDestination(@"C:\PPG\stores");
            st.addOtherPath(@"C:\PPG\temp_holders\temp_holder_1");
            st.addOtherPath(@"C:\PPG\temp_holders\temp_holder_2");

            sQueue.addSearch("7.6.88.6.04192015.x");
            sQueue.addSearch("4.2.52.1.08222008.x");
            sQueue.addSearch("1.7.85.8.05172014.x");

            Dictionary<string, Invoice> r = myF.execute();
            myR.copyDictionary(r);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage(ref myR, ref sQueue, ref st, ref myF));

            ////store.region.trans.cust.date
            //string invoice = store_id + "." + reg_id + "." + trans_id + "." + cust_id + "." + s_date + "." + e_date;

            //sQueue.addSearch(invoice);

            return;
        }
    }
}
