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
    public partial class AddSearch : Form
    {
        public SearchQueue searchQueue;
        public Settings set;
        int index_of_selected;
        public AddSearch(ref SearchQueue sQueue, ref Settings st)
        {
            InitializeComponent();
            searchQueue = sQueue;
            set = st;
            index_of_selected = 0;

        }

        private void Add_Click(object sender, EventArgs e)
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

        private void AddSearch_Load(object sender, EventArgs e)
        {

        }

        private void RemoveSearch_Click(object sender, EventArgs e)
        {

        }

        private void Invoice_Queue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_GUI_queue() 
        { 
            //for(int i=0; i<; i++){
            //    Invoice_Queue.SelectedIndex = i;
            //}
            //send all the searches to the 
        }

    }
}
