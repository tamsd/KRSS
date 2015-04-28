﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InvoiceFinder.BackEnd;
using System.Configuration;
using System.Collections.Specialized;

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
            Exporter myE = new Exporter(ref st, ref myR);

            st.setArchiveA(ConfigurationManager.AppSettings["Archive_a"]);
            st.setArchiveB(ConfigurationManager.AppSettings["Archive_b"]);
            st.setFinalDestination(ConfigurationManager.AppSettings["Store1"]);
            st.addOtherPath(ConfigurationManager.AppSettings["temp_folder"]);
            st.addOtherPath(ConfigurationManager.AppSettings["temp_folder2"]);
            st.setOutputPath(ConfigurationManager.AppSettings["Output_Path"]);


            //run the invoice environment and change these to adjust to your own data set generated by the environment generator ////store.region.trans.cust.date
            sQueue.addSearch("1.7.97.3.03302015.*");
            sQueue.addSearch("4.2.52.1.08222008.*");
            //sQueue.addSearch("1.7.85.8.05172014.x");

            Dictionary<string, Invoice> r = myF.execute();
            myR.copyDictionary(r);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage(ref myR, ref sQueue, ref st, ref myF, ref myE));

            return;
        }
    }
}
