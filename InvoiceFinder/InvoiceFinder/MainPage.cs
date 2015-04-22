﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvoiceFinder.BackEnd;

namespace InvoiceFinder
{
    public partial class MainPage : Form
    {
        /***************General Variables and Cosntructor***************/
        private Results results;
        private SearchQueue searchQueue;
        private Settings set;
        private Finder find;
        private Exporter exporter;
        int index_of_selected;

        public MainPage(ref Results r, ref SearchQueue sQueue, ref Settings st, ref Finder finder, ref Exporter exp)
        {
            InitializeComponent();

            searchQueue = sQueue;
            set = st;
            find = finder;
            results = r;
            exporter = exp;
            index_of_selected = 0;

            CreateResultsTable();
            results.sortByStore("ascending");
            FillTable();
        }
        /***************End General Variables and Cosntructor***************/

        /***************Results Tab***************/
        /*sets the headers of the table columns*/
        public void CreateResultsTable()
        {
            //filename header
            Label FileName_Label = new Label();
            FileName_Label.Dock = DockStyle.Fill;
            FileName_Label.Text = "File Name";
            FileName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ResultsTable.Controls.Add(FileName_Label, 0, 0);

            //Store header
            Label Store_Label = new Label();
            Store_Label.Dock = DockStyle.Fill;
            Store_Label.Text = "Store";
            Store_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ResultsTable.Controls.Add(Store_Label, 1, 0);

            //Customer header
            Label Customer_Label = new Label();
            Customer_Label.Dock = DockStyle.Fill;
            Customer_Label.Text = "Customer";
            Customer_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ResultsTable.Controls.Add(Customer_Label, 2, 0);

            //Date header
            Label Date_label = new Label();
            Date_label.Dock = DockStyle.Fill;
            Date_label.Text = "Date";
            Date_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ResultsTable.Controls.Add(Date_label, 3, 0);

            //radio button export header
            Label Export_Label = new Label();
            Export_Label.Dock = DockStyle.Fill;
            Export_Label.Text = "Export";
            Export_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ResultsTable.Controls.Add(Export_Label, 4, 0);

            //table settings
            this.ResultsTable.AutoSize = true;
            this.ResultsTable.BackColor = System.Drawing.Color.Transparent;
            this.ResultsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResultsTable.Location = new System.Drawing.Point(0, 0);
            this.ResultsTable.Name = "ResultsTable";
            this.ResultsTable.TabIndex = 0;
        }

        /*Fills the table with the results passed in*/
        public void FillTable(){
            int row = 1;
            foreach(Invoice i in results){
                Label name = new Label();
                name.Dock = DockStyle.Fill;
                name.Text = i.File_name;
                name.TextAlign = ContentAlignment.MiddleLeft;

                Label store = new Label();
                store.Dock = DockStyle.Fill;
                store.Text = i.Store_id;
                store.TextAlign = ContentAlignment.MiddleLeft;

                Label customer = new Label();
                customer.Dock = DockStyle.Fill;
                customer.Text = i.Cust_id;
                customer.TextAlign = ContentAlignment.MiddleLeft;

                Label date = new Label();
                date.Dock = DockStyle.Fill;
                date.Text = i.Date;
                date.TextAlign = ContentAlignment.MiddleLeft;

                RadioButton radio_button = new RadioButton();
                radio_button.Dock = DockStyle.Fill;
                radio_button.CheckAlign = ContentAlignment.MiddleCenter;
                radio_button.Checked = true;

                ResultsTable.Controls.Add(name, 0, row);
                ResultsTable.Controls.Add(store, 1,row);
                ResultsTable.Controls.Add(customer, 2,row);
                ResultsTable.Controls.Add(date, 3,row);
                ResultsTable.Controls.Add(radio_button, 4, row);
                row++;
            }
        }

        /*Event handler for clicking export button*/
        private void Export_Click_1(object sender, EventArgs e)
        {
            string export_location = exporter.export();
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.InitialDirectory = set.getOutputPath();
            fileDialog.ShowDialog();
            //**********add a setting that prevents the dialog from popping up everytime
        }
        /***************End Results Tab***************/

        /***************Search Tab***************/
        private void Add_Click_1(object sender, EventArgs e)
        {
            string temp_s = Store_ID.Text + "." +
                            Region_ID.Text + "." +
                            Transaction_ID.Text + "." +
                            Cust_ID.Text + "." +
                            Start_Date.Text + "." +
                            End_Date.Text;
            searchQueue.addSearch(temp_s);
            Store_ID.Clear();
            Region_ID.Clear();
            Transaction_ID.Clear();
            Cust_ID.Clear();
            Start_Date.Clear();
            End_Date.Clear();
        }

        private void RemoveSearch_Click(object sender, EventArgs e)
        {

        }

        private void update_GUI_queue() 
        { 
            //for(int i=0; i<; i++){
            //    Invoice_Queue.SelectedIndex = i;
            //}
            //send all the searches to the 
        }
        /***************End Search Tab***************/

        /***************Settings Tab***************/        
        private void List_CheckedChanged(object sender, EventArgs e)
        {
            //if (List.Checked == false)
            //{
            //    set.setOutputType(0);
            //    List.Checked = true;
            //}
            //if (List.Checked == true)
            //{
            //    List.Checked = false;
            //}
            set.setOutputType(0);
        }

        private void ConcPDF_CheckedChanged(object sender, EventArgs e)
        {
            //if (ConcPDF.Checked == false)
            //{
            //    set.setOutputType(1);
            //    ConcPDF.Checked = true;
            //}
            //else if (ConcPDF.Checked == true)
            //{
            //    ConcPDF.Checked = false;
            //}
            set.setOutputType(1);
        }

        private void ZipFolder_CheckedChanged(object sender, EventArgs e)
        {
            //if (ZipFolder.Checked == false)
            //{
            //    set.setOutputType(1);
            //    ZipFolder.Checked = true;
            //}
            //else if (ZipFolder.Checked == true)
            //{
            //    ZipFolder.Checked = false;
            //}
            set.setOutputType(1);
        }

        private void SettingsInterface_Load(object sender, EventArgs e)
        {
            ZipFolder.Checked = true;
        }
        /***************End Settings Tab***************/
    }
}
