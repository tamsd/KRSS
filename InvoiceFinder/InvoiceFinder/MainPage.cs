/*
 * Author(s):
 * Date:
 * Description:
*/
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
        private Results results;            //references results generated after search runs
        private SearchQueue searchQueue;    //references the search q
        private Settings set;               //references settings
        private Finder find;                //references finder
        private Exporter exporter;          //references exporter
        public MainPage(ref Results r, ref SearchQueue sQueue, ref Settings st, ref Finder finder, ref Exporter exp){ //cosntructor for MainPage form
            InitializeComponent();
            //intialize Invoice Finder objects
            searchQueue = sQueue;
            set = st;
            find = finder;
            results = r;
            exporter = exp;
            //Initialize results and settings tab
            FillTable();
            init_settings_tab();
        }
        /***************End General Variables and Constructor***************/
        /*
         * 
         * 
         * 
         * 
         */
        /***************Results Tab***************/

        /*Fills the table with the results passed in*/
        public void FillTable(){
            ResultsTable.Rows.Clear();
            foreach(Invoice i in results){
                ResultsTable.Rows.Add(i.File_name,i.Store_id, i.Cust_id, i.Date_Time_Date.ToString("d"), "Yes");
            }
        }

        /*Event handler for clicking export button*/
        private void Export_Click_1(object sender, EventArgs e){
            //iterate over results and update inv.Export member variable because user may have changed check mark
            foreach (DataGridViewRow row in ResultsTable.Rows){
                row.Cells["Export_DGV"].ValueType = typeof(string);
                if ((string)row.Cells["Export_DGV"].Value == "Yes"){
                    string fn = row.Cells["File_Name"].Value.ToString();
                    results.setInvExportValue(fn, true);
                }
                else{
                    string fn = row.Cells["File_Name"].Value.ToString();
                    results.setInvExportValue(fn, false);
                }
            }
            //export selected results if output path is set
            if (set.getOutputPath() != ""){
                string export_location = exporter.export();
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Multiselect = true;
                fileDialog.Filter = "Zip Files (*.zip)|*.zip|PDF Files (*.Pdf)|*.Pdf"; //this doesnt seem to work
                fileDialog.InitialDirectory = set.getOutputPath();
                fileDialog.ShowDialog();
            }
            else{
                MessageBox.Show("In order to export, you must set a File Export Destination in the Settings Tab"); //notify user that export path is not set
            }
        }

        /***************End Results Tab***************/
        /*
         * 
         * 
         * 
         * 
         *         
        /
        /***************Search Tab***************/

        private void Add_Single_Click_1(object sender, EventArgs e)
        {
            //check that start and end dates are valid
            if (isValidDate(Start_Date.Text) && (isValidDate(End_Date.Text) || End_Date.Text.Length == 0))
            {
                string temp_s = ((Store_ID.Text == "") ? "*" : Store_ID.Text) + "." +
                                ((Region_ID.Text == "") ? "*" : Region_ID.Text) + "." +
                                ((Trans_ID.Text == "") ? "*" : Trans_ID.Text) + "." +
                                ((Cust_ID.Text == "") ? "*" : Cust_ID.Text) + "." +
                                Start_Date.Text + "." +
                                ((End_Date.Text == "" || End_Date.Text == "pdf") ? "*" : End_Date.Text);
                searchQueue.addSearch(temp_s);

                End_Date.Clear();
                Cust_ID.Clear();
                Start_Date.Clear();
                Store_ID.Clear();
                Trans_ID.Clear();
                Region_ID.Clear();

                update_GUI_queue();
            }
            else
            {
                Date_Entry_Error_Label.Visible = true;
            }

        }

        private void Add_Multiple_Click(object sender, EventArgs e)
        {
            char[] delims = { '\n' };
            string[] parts = Multiple_Entry_Text_Box.Text.Split(delims);
            //check formatting
            bool is_formatted_correctly = true;
            char[] delims2 = { '.' };
            for (int i = 0; i < parts.Count(); i++)
            {
                string[] format_check = parts[i].Split(delims2);
                if (format_check.Count() != 6)
                {
                    is_formatted_correctly = false;
                }
            }

            if (!is_formatted_correctly)
            {
                Entry_Error_Label.Visible = true;
            }
            else //load it all into searchQueue
            {
                for (int i = 0; i < parts.Count(); i++)
                {
                    searchQueue.addSearch(parts[i]);
                }

                Multiple_Entry_Text_Box.Clear();

                update_GUI_queue();
            }
        }

        private void Start_Date_TextChanged(object sender, EventArgs e)
        {
            Date_Entry_Error_Label.Visible = false;
        }

        private void End_Date_TextChanged(object sender, EventArgs e)
        {
            Date_Entry_Error_Label.Visible = false;
        }

        private void Multiple_Entry_Text_Box_TextChanged(object sender, EventArgs e)
        {
            Entry_Error_Label.Visible = false;
        }

        private void RemoveSearch_Click(object sender, EventArgs e)
        {
            if (searchQueue.searchCount() > 0)
            {
                int index = dataGridView1.CurrentRow.Index;
                if (dataGridView1.Rows.Count > 0)
                {
                    searchQueue.deleteSearch(index);
                }
                update_GUI_queue();
                if (searchQueue.searchCount() > 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[index - ((index == searchQueue.searchCount()) ? 1 : 0)].Cells[0];
                }
            }
        }

        private void Move_Up_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int index = dataGridView1.CurrentRow.Index;
                searchQueue.moveSearch(index, index - ((index != 0) ? 1 : 0));
                update_GUI_queue();
                dataGridView1.CurrentCell = dataGridView1.Rows[index - ((index != 0) ? 1 : 0)].Cells[0];
            }
        }

        private void Move_Down_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int index = dataGridView1.CurrentRow.Index;
                searchQueue.moveSearch(index, index + ((index != searchQueue.searchCount() - 1) ? 1 : 0));
                update_GUI_queue();
                dataGridView1.CurrentCell = dataGridView1.Rows[index + ((index != searchQueue.searchCount() - 1) ? 1 : 0)].Cells[0];
            }
        }

        private void Move_Top_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int index = dataGridView1.CurrentRow.Index;
                searchQueue.moveSearch(index, 0);
                update_GUI_queue();
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }
        }

        private void Move_Bottom_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int index = dataGridView1.CurrentRow.Index;
                searchQueue.moveSearch(index, searchQueue.searchCount() - 1);
                update_GUI_queue();
                dataGridView1.CurrentCell = dataGridView1.Rows[searchQueue.searchCount() - 1].Cells[0];
            }
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            if (searchQueue.searchCount() > 0)
            {

                int index = dataGridView1.CurrentRow.Index;
                EditSearchDialogue dialog = new EditSearchDialogue();
                dialog.Edit_Cust_ID_in = searchQueue.getSearch(index).CustID;
                dialog.Edit_Start_Date_in = searchQueue.getSearch(index).SDate;
                dialog.Edit_End_Date_in = searchQueue.getSearch(index).EDate;
                dialog.Edit_Store_ID_in = searchQueue.getSearch(index).StoreID;
                dialog.Edit_Trans_ID_in = searchQueue.getSearch(index).TransID;
                dialog.Edit_Region_ID_in = searchQueue.getSearch(index).RegID;
                dialog.Load_Values();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    searchQueue.deleteSearch(index);
                    searchQueue.addSearch(dialog.Edit_Store_ID_in + "." +
                                            dialog.Edit_Region_ID_in + "." +
                                            dialog.Edit_Trans_ID_in + "." +
                                            dialog.Edit_Cust_ID_in + "." +
                                            dialog.Edit_Start_Date_in + "." +
                                            dialog.Edit_End_Date_in);
                    searchQueue.moveSearch(searchQueue.searchCount() - 1, index);

                }
                update_GUI_queue();
                dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
            }
        }

        private void update_GUI_queue()
        {
            //clear the queue
            dataGridView1.Rows.Clear();
            //repopulate the queue
            for (int i = 0; i < searchQueue.searchCount(); i++)
            {
                Search s = searchQueue.getSearch(i);
                //(End_Date.Text == "") ? "*" : End_Date.Text);
                dataGridView1.Rows.Add(s.CustID, s.Dt_sDate.ToString("d"), (s.EDate == "") ? s.EDate : s.Dt_eDate.ToString("d"), s.StoreID, s.TransID, s.RegID);
            }
        }

        public static bool isValidDate(string s)
        {
            if (s.Length != 8)
            {
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]))
                {
                    return false;
                }
            }
            try
            {
                Finder.convertStringDate(s);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            Dictionary<string, Invoice> r = find.execute();
            results.copyDictionary(r);
            FillTable();
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ? tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
        }
        /***************End Search Tab***************/
        /*
         * 
         * 
         * 
         * 
         *         
        /
        /***************Settings Tab***************/

        /* function intializes settings tab at startup */
        private void init_settings_tab(){
            output_type_comboBox.Items.Insert(0, "Seperate PDFs");          //Add option to combobox
            output_type_comboBox.Items.Insert(1, "Concatenated PDF File");  //Add option to combobox
            output_type_comboBox.Items.Insert(2, "Zip Folder");             //Add option to combobox

            switch(set.getOutputType()){ //Initialize the text showing in combobox
                case 0:
                    output_type_comboBox.Text = "Seperate PDFs";
                    break;
                case 1:
                    output_type_comboBox.Text = "Concatenated PDF File";
                    break;
                case 2:
                    output_type_comboBox.Text = "Zip Folder";
                    break;
                default:
                    break;
            } 

            if(set.getOutputPath() == ""){ //intialize the textbox showing output path
                export_location_textBox.Text = "Select a folder to save exports to...";
            }
            else{
                export_location_textBox.Text = set.getOutputPath();
            }
            return;
        }

        /* event handler for combobox changed pick */
        private void output_type_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)        {
            set.setOutputType(output_type_comboBox.SelectedIndex);
            return;
        }

        /* event handler for select button click */
        private void export_select_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog(); //folder broswer dialog for pivking export save location
            if(set.getOutputPath() != ""){
                try{ //try to set SelectedPath to waht has already been selected just in case getOutputPath returns invalid path
                    folderDialog.SelectedPath = set.getOutputPath();
                }
                catch{
                }
            }
            folderDialog.ShowDialog();
            if(folderDialog.SelectedPath != ""){ //set new output path if user picked a new one
                set.setOutputPath(folderDialog.SelectedPath);
                export_location_textBox.Text = set.getOutputPath();
            }
            return;
        }

        /***************End Settings Tab***************/
    }
}
