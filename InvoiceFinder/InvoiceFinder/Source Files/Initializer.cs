using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InvoiceFinder.BackEnd;
using System.Configuration;
using System.Collections.Specialized;

namespace InvoiceFinder
{
    static class Initializer
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SearchQueue sQueue = new SearchQueue();
            Settings st = new Settings();
            Finder myF = new Finder(ref sQueue, ref st);
            Results myR = new Results();
            Exporter myE = new Exporter(ref st, ref myR);
            char[] delims = {' ', '\n', '\t', ','};
            List<string> archives = new List<string>(ConfigurationManager.AppSettings["Archive_Folders"].Split(delims));
            foreach(string path in archives){
                st.addArchive_Folder(path);
            }
            List<string> temps = new List<string>(ConfigurationManager.AppSettings["Temp_Folders"].Split(delims));
            foreach(string path in temps){
                st.addTempFolder(path);
            }
            List<string> others = new List<string>(ConfigurationManager.AppSettings["Other_folders"].Split(delims));
            foreach(string path in others){
                st.addOther_Folder(path);
            }
            st.setFinalDestination(ConfigurationManager.AppSettings["Final_Destination"]);
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage(ref myR, ref sQueue, ref st, ref myF, ref myE));

            return;
        }
    }
}

