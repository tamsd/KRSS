using System;
using System.Collections.Generic;

namespace InvoiceFinder
{
    namespace BackEnd
    {
        public class Search
        {
            //Data Declarations
            //Accessors and Mutators
            private string transID;
            public string TransID {
                set {
                    transID = value;
                }
                get {
                    return transID;
                }
            }

            private string custID;
            public string CustID {
                set {
                    custID = value;
                }
                get {
                    return custID;
                }
            }

            private string storeID;
            public string StoreID {
                set {
                    storeID = value;
                }
                get {
                    return storeID;
                }
            }

            private string regID;
            public string RegID {
                set {
                    regID = value;
                }
                get {
                    return regID;
                }
            }

            private string sDate;
            public string SDate {
                set
                {
                    sDate = value;
                }
                get
                {
                    return sDate;
                }
            }

            private string eDate;
            public string EDate {
                set {
                    eDate = value;
                }
                get {
                    return eDate;
                }
            }

            private DateTime dt_sDate;
            public DateTime Dt_sDate{
                get { return dt_sDate; }
                set { dt_sDate = value; }
            }

            private DateTime dt_eDate;
            public DateTime Dt_eDate
            {
                get { return dt_eDate; }
                set { dt_eDate = value; }
            }

            List<string> file_names;

            //Default constructor
            public Search() {
                transID = null;
                custID = null;
                storeID = null;
                regID = null;
                sDate = null;
                eDate = null;
                List<string> file_names = new List<string>();
            }

            //Single Args cosntructor
            public Search(string s) {
                file_names = new List<string>();
                char[] delims = {'.'};
                string[] parts = s.Split(delims);
                storeID = parts[0];
                regID = parts[1];
                transID = parts[2];
                custID = parts[3];
                sDate = parts[4];
                eDate = parts[5];
                dt_sDate = convertStringDate(sDate);
                dt_eDate = convertStringDate(eDate);

                /*Based on input create all possible filenames that need to be searched for*/
                string filename = storeID + "." + regID + "." + transID + "." + custID + "."; //does not have date or extension yet
                if(eDate != "*"){
                    DateTime d = dt_sDate;
                    string string_date = "";
                    while(d <= dt_eDate){
                        string_date = convertDateTimeDate(d);
                        string temp_filename = filename + string_date; //adds date
                        file_names.Add(temp_filename);
                        d = d.AddDays(1);
                    }
                }
                else{
                    filename = filename + sDate; //adds date
                    file_names.Add(filename);
                }
            }

            //Optional Parameter instructor, must name parameters entered
            public Search(string transaction = null, string customer = null, string store = null, string register = null, string start = null, string end = null) {
                transID = transaction;
                custID = customer;
                storeID = store;
                regID = register;
                sDate = start;
                eDate = end;
                file_names = new List<string>();
            }

            private DateTime convertStringDate(string d){
                if(d == "*"){
                    return new DateTime();
                }
                string month = "";
                string day = "";
                string year = "";
                //MMDDYYYY
                for(int i = 0; i < d.Length; i++){
                    if(i < 2){
                        month += d[i];
                    }
                    else if(i < 4){
                        day += d[i];
                    }
                    else if(i < 8){
                        year += d[i];
                    }
                }
                int mo = Convert.ToInt32(month);
                int da = Convert.ToInt32(day);
                int yr = Convert.ToInt32(year);
                DateTime dt = new DateTime(yr, mo, da);
                return dt;
            }

            private string convertDateTimeDate(DateTime d){
                string string_date = d.ToString("MMddyyyy");
                return string_date;
            }

            public List<string> get_filenames_list(){
                List<string> l = new List<string>(file_names);
                return l;
            }
            //ToString override
            public override string ToString() {
                string s = "transID: " + transID + "\n";
                s += "custID: " + custID + "\n";
                s += "storeID: " + storeID + "\n";
                s += "regID: " + regID + "\n";
                s += "sDate: " + sDate + "\n";
                s += "eDate: " + eDate + "\n";
                return s;
            }
        }
    }
}
