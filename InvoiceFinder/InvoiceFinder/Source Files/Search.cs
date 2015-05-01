﻿using System;
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
                set { transID = value; }
                get { return transID; }
            }

            private string custID;
            public string CustID {
                set { custID = value; }
                get { return custID; }
            }

            private string storeID;
            public string StoreID {
                set {storeID = value;}
                get {return storeID;}
            }

            private string regID;
            public string RegID {
                set { regID = value; }
                get { return regID; }
            }

            private string sDate;
            public string SDate {
                set { sDate = value; }
                get { return sDate; }
            }

            private string eDate;
            public string EDate {
                set { eDate = value; }
                get { return eDate; }
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
                dt_sDate = Finder.convertStringDate(sDate);
                if (parts[5] != "pdf" && parts.Length > 5){
                    eDate = parts[5];
                    dt_eDate = Finder.convertStringDate(eDate);
                }
                else{
                    eDate = "";
                    dt_eDate = new DateTime();
                }
                /*Based on input create all possible filenames that need to be searched for*/
                string filename = storeID + "." + regID + "." + transID + "." + custID + "."; //does not have date or extension yet
                if(eDate != ""){
                    DateTime d = dt_sDate;
                    string string_date = "";
                    while(d <= dt_eDate){
                        string pattern = makeRegex(parts);
                        string_date = convertDateTimeDate(d);
                        string temp_filename = filename + string_date; //adds date
                        file_names.Add(temp_filename/*, pattern*/);
                        d = d.AddDays(1);
                    }
                }
                else{
                    //string pattern = makeRegex(parts);
                    filename = filename + sDate; //adds date
                    file_names.Add(filename/*, pattern*/);
                }
            }
            //8000.2.12306.306381140006.03092015.pdf
            //"^\\d{4}.\\d{1}.\\d{5}.\\d{12}.\\d{8}.pdf$" ---regular expression of file names
            //function creates a regex expression based on parts
            private string makeRegex(string[] parts){
                string p = "^";
                for(int i = 0; i < 4 && i < parts.Length; i++){
                    if(parts[i] == "*"){
                        switch(i){
                            case 0: //storeid
                                p += "\\d{4}.";
                                break;
                            case 1: //reg id
                                p += "\\d{1}.";
                                break;
                            case 2: //trans id
                                p += "\\d{5}.";
                                break;
                            case 3: //cust id
                                p += "\\d{12}.";
                                break;
                            case 4: //sdate
                                p += "\\d{8}.";
                                break;
                            case 5:
                                break;
                            default:
                                break;
                        }
                    }
                    else{
                        p += parts[i] + ".";
                    }
                }
                p += "pdf";
                return p;
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

            private string convertDateTimeDate(DateTime d){
                string string_date = d.ToString("MMddyyyy");
                return string_date;
            }
            public List<string> get_filenames_list()
            {
                List<string> d = new List<string>(file_names);
                return d;
            }
            //public Dictionary<string, string> get_filenames_list(){
            //    Dictionary<string, string> d = new Dictionary<string, string>(file_names);
            //    return d;
            //}
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
