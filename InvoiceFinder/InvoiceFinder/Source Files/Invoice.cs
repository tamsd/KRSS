using System;
using System.Collections.Generic;

namespace InvoiceFinder
{
    namespace BackEnd
    {
        public class Invoice
        {
            private string date;  //the date of the transaction
            public string Date {
                get {
                    return date;
                }
                set {
                    date = value;
                }
            }
            private string cust_id; //the customerid that they are searching
            public string Cust_id {
                get {
                    return cust_id;
                }
                set {
                    cust_id = value;
                }
            }
            private string reg_id;
            public string Reg_id{
                get { return reg_id; }
                set { reg_id = value; }
            }
            private string trans_id;    //the transaction id that they are searching
            public string Trans_id {
                get {
                    return trans_id;
                }
                set {
                   trans_id = value;
                }
            }
            private string store_id;    //the storeid that the transaction was from
            public string Store_id {
                get {
                    return store_id;
                }
                set {
                    store_id = value;
                }
            }
            private bool discovered;    //tells us if the path was discovered or not
            public bool Discovered {
                get {
                    return discovered;
                }
                set {
                    discovered = value;
                }
            }
            private string discovered_path; //tells us the discovered path
            public string Discovered_path {
                get {
                    return discovered_path;
                }
                set {
                    discovered_path = value;
                }
            }
            private string parent;
            public string Parent{
                get { return parent; }
                set { parent = value;}
            }
            private string final_destination;   //if it is in the final destination or not
            public string Final_destination {
                get {
                    return final_destination;
                }
                set {
                    final_destination = value;
                }
            }
            private bool copied_to_final_destination;   //letting us know if the transaction was copied to its final destination
            public bool Copied_to_final_destination {
                get {
                    return copied_to_final_destination;
                }
                set {
                    copied_to_final_destination = value;
                }
            }
            //def constructor
            public Invoice() {
                discovered = false;
                final_destination = null;
                copied_to_final_destination = false;
                date = null;
                reg_id = null;
                cust_id = null;
                trans_id = null;
                discovered_path = null;
                store_id = null;
            }
            //single arg constructor
            public Invoice(
                string rg_id = null, string dt = null, string cst_id = null, string trns_id = null, string dscvrd_pth = null, 
                bool dscvrd = false, bool cpd_to_fnl_dstntn = false, string fnl_dstntn = null, string str_id = null
            ) {
                reg_id = rg_id;
                discovered = dscvrd;
                final_destination = fnl_dstntn;
                copied_to_final_destination = cpd_to_fnl_dstntn;
                date = dt;
                cust_id = cst_id;
                trans_id = trns_id;
                discovered_path = dscvrd_pth;
                store_id = str_id;
            }

            //ToString override
            public override string ToString()
            {
                string s = "transID: " + trans_id + "\n";
                s += "custID: " + cust_id + "\n";
                s += "storeID: " + store_id + "\n";
                //s += "regID: " + regID + "\n";
                //s += "sDate: " + sDate + "\n";
               // s += "eDate: " + eDate + "\n";
                return s;
            }

        }
    }
}
