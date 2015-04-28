using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceFinder
{
    public partial class EditSearchDialogue : Form
    {

        //info to get passed back to the parent
        public string Edit_Cust_ID_in;
        public string Edit_Start_Date_in;
        public string Edit_End_Date_in;
        public string Edit_Store_ID_in;
        public string Edit_Trans_ID_in;
        public string Edit_Region_ID_in;

        public EditSearchDialogue()
        {
            InitializeComponent();
        }

        public void Load_Values()
        {
            Edit_Cust_ID.Text = Edit_Cust_ID_in;
            Edit_Start_Date.Text = Edit_Start_Date_in;
            Edit_End_Date.Text = Edit_End_Date_in;
            Edit_Store_ID.Text = Edit_Store_ID_in;
            Edit_Trans_ID.Text = Edit_Trans_ID_in;
            Edit_Region_ID.Text = Edit_Region_ID_in;
        }

        private void Save_And_Close_Button_Click(object sender, EventArgs e)
        {
            Edit_Cust_ID_in = Edit_Cust_ID.Text;
            Edit_Start_Date_in = Edit_Start_Date.Text;
            Edit_End_Date_in = Edit_End_Date.Text;
            Edit_Store_ID_in = Edit_Store_ID.Text;
            Edit_Trans_ID_in = Edit_Trans_ID.Text;
            Edit_Region_ID_in = Edit_Region_ID.Text;
        }
    }
}
