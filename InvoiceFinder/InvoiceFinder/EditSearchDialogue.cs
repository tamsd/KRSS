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
    public partial class EditSearchDialogue : Form
    {

        //info to get passed back to the caller
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

        //places the values from the caller into the text boxes
        public void Load_Values()
        {
            Edit_Cust_ID.Text = (Edit_Cust_ID_in != "x" && Edit_Cust_ID_in != "*") ? Edit_Cust_ID_in : ""; ;
            Edit_Start_Date.Text = Edit_Start_Date_in;
            Edit_End_Date.Text = (Edit_End_Date_in != "x" && Edit_End_Date_in != "*") ? Edit_End_Date_in : "";
            Edit_Store_ID.Text = (Edit_Store_ID_in != "x" && Edit_Store_ID_in != "*") ? Edit_Store_ID_in : "";
            Edit_Trans_ID.Text = (Edit_Trans_ID_in != "x" && Edit_Trans_ID_in != "*") ? Edit_Trans_ID_in : "";
            Edit_Region_ID.Text = (Edit_Region_ID_in != "x" && Edit_Region_ID_in != "*") ? Edit_Region_ID_in : "";
        }

        //button which saves the text box changes back the internal versions and then returns OK to the caller.
        private void Save_And_Close_Button_Click(object sender, EventArgs e)
        {
            if (MainPage.isValidDate(Edit_Start_Date.Text) && (MainPage.isValidDate(Edit_End_Date.Text) || Edit_End_Date.Text.Length == 0) && ((Finder.convertStringDate(Edit_End_Date.Text) > Finder.convertStringDate(Edit_Start_Date.Text)) || Edit_End_Date.Text == "") && Edit_Store_ID.Text != "" &&
                Edit_Region_ID.Text != "" &&
                Edit_Trans_ID.Text != "" &&
                Edit_Cust_ID.Text != "")
            {
                Edit_Cust_ID_in = (Edit_Cust_ID.Text == "") ? "" : Edit_Cust_ID.Text;
                Edit_Start_Date_in = Edit_Start_Date.Text;
                Edit_End_Date_in = (Edit_End_Date.Text == "") ? "" : Edit_End_Date.Text;
                Edit_Store_ID_in = (Edit_Store_ID.Text == "") ? "" : Edit_Store_ID.Text;
                Edit_Trans_ID_in = (Edit_Trans_ID.Text == "") ? "" : Edit_Trans_ID.Text;
                Edit_Region_ID_in = (Edit_Region_ID.Text == "") ? "" : Edit_Region_ID.Text;

                this.DialogResult = DialogResult.OK;
            }
            else if (Edit_Store_ID.Text == "" ||
                Edit_Region_ID.Text == "" ||
                Edit_Trans_ID.Text == "" ||
                Edit_Cust_ID.Text == "")
            {
                Date_Entry_Error_Label.Text = "Fill Error!";
                Date_Entry_Error_Label.Visible = true;
            }
            else
            {
                Date_Entry_Error_Label.Visible = true;
            }
        }

        //when the text is changed in the Start_Date box, hide the error message
        private void Edit_Start_Date_TextChanged(object sender, EventArgs e)
        {
            Date_Entry_Error_Label.Text = "Date Error!";
            Date_Entry_Error_Label.Visible = false;
        }

        //when the text is changed in the End_Date box, hide the error message
        private void Edit_End_Date_TextChanged(object sender, EventArgs e)
        {
            Date_Entry_Error_Label.Text = "Date Error!";
            Date_Entry_Error_Label.Visible = false;
        }

        //when the text is changed in the Cust_ID box, hide the error message
        private void Edit_Cust_ID_TextChanged(object sender, EventArgs e)
        {
            Date_Entry_Error_Label.Text = "Date Error!";
            Date_Entry_Error_Label.Visible = false;
        }

        //when the text is changed in the Store_ID box, hide the error message
        private void Edit_Store_ID_TextChanged(object sender, EventArgs e)
        {
            Date_Entry_Error_Label.Text = "Date Error!";
            Date_Entry_Error_Label.Visible = false;
        }

        //when the text is changed in the Trans_ID box, hide the error message
        private void Edit_Trans_ID_TextChanged(object sender, EventArgs e)
        {
            Date_Entry_Error_Label.Text = "Date Error!";
            Date_Entry_Error_Label.Visible = false;
        }

        //when the text is changed in the Region_ID box, hide the error message
        private void Edit_Region_ID_TextChanged(object sender, EventArgs e)
        {
            Date_Entry_Error_Label.Text = "Date Error!";
            Date_Entry_Error_Label.Visible = false;
        }

    }
}
