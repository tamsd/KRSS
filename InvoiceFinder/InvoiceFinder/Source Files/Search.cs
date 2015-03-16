using System;
using System.Collections.Generic;

namespace InvoiceFinder
{
    namespace BackEnd
    {
        class Search
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

            //Default constructor
            public Search() {
                transID = null;
                custID = null;
                storeID = null;
                regID = null;
                sDate = null;
                eDate = null;
            }

            //Single Args cosntructor
            public Search(string s) {
                char[] delims = {'.'};
                string[] parts = s.Split(delims);
                storeID = parts[0];
                regID = parts[1];
                transID = parts[2];
                custID = parts[3];
                sDate = parts[4];
                eDate = parts[5];
            }

            //Optional Parameter instructor, must name parameters entered
            public Search(string transaction = null, string customer = null, string store = null, string register = null, string start = null, string end = null) {
                transID = transaction;
                custID = customer;
                storeID = store;
                regID = register;
                sDate = start;
                eDate = end;
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
