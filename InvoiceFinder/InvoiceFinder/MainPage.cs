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

        private void Add_Single_Click_1(object sender, EventArgs e)
        {
            string temp_s = Store_ID.Text + "." +
                            Region_ID.Text + "." +
                            Trans_ID.Text + "." +
                            Cust_ID.Text + "." +
                            Start_Date.Text + "." +
                            End_Date.Text;
            searchQueue.addSearch(temp_s);

            End_Date.Clear();
            Cust_ID.Clear();
            Start_Date.Clear();
            Store_ID.Clear();
            Trans_ID.Clear();
            Region_ID.Clear();

            update_GUI_queue();

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
                dataGridView1.Rows.Add(s.CustID, s.SDate, s.EDate, s.StoreID, s.TransID, s.RegID);
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            find.execute();
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ? tabControl1.SelectedIndex + 1 : tabControl1.SelectedIndex;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        /***************End Search Tab***************/

        /***************Settings Tab***************/
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
