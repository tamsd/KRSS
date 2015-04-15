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
        public AddSearch(ref SearchQueue sQueue, ref Settings st)
        {
            InitializeComponent();
            searchQueue = sQueue;
            set = st;
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

    }
}
