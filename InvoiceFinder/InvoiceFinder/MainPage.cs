using System;
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
        public MainPage(ref Results r, ref SearchQueue sQueue, ref Settings st, ref Finder finder, ref Exporter exp)
        {
            InitializeComponent();

            searchQueue = sQueue;
            set = st;
            find = finder;
            results = r;
            exporter = exp;
            FillTable();
        }
        /***************End General Variables and Cosntructor***************/

        /***************Results Tab***************/
        /*Fills the table with the results passed in*/
        public void FillTable(){
            //int row = 1;
            foreach(Invoice i in results){
                ResultsTable.Rows.Add(i.File_name,i.Store_id, i.Cust_id, i.Date_Time_Date.ToString(), true);
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
       
        /***************End Search Tab***************/

        /***************Settings Tab***************/
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem item in checkedListBox_Output_Type.Items)
            {
                item.Selected = false;

            }
            switch (checkedListBox_Output_Type.SelectedIndex)
            {
                case 0:
                    System.Windows.Forms.MessageBox.Show("0");
                    set.setOutputType(0);
                    break;
                case 1:
                    System.Windows.Forms.MessageBox.Show("1");
                    set.setOutputType(1);
                    break;
                case 2:
                    System.Windows.Forms.MessageBox.Show("2");
                    set.setOutputType(2);
                    break;
                default:
                    set.setOutputType(2);
                    break;
            }
        }
        /***************End Settings Tab***************/
    }
}
