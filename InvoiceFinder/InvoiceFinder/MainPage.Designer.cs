namespace InvoiceFinder
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Region_ID = new System.Windows.Forms.TextBox();
            this.Trans_ID = new System.Windows.Forms.TextBox();
            this.Region_ID_Label = new System.Windows.Forms.Label();
            this.Transaction_ID_Label = new System.Windows.Forms.Label();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Move_Bottom_Button = new System.Windows.Forms.Button();
            this.Move_Top_Button = new System.Windows.Forms.Button();
            this.Entry_Error_Label = new System.Windows.Forms.Label();
            this.Move_Down_Button = new System.Windows.Forms.Button();
            this.Move_Up_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_Multiple = new System.Windows.Forms.Button();
            this.Multiple_Entry_Text_Box = new System.Windows.Forms.RichTextBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Date_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_Date_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Store_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region_ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveSearch = new System.Windows.Forms.Button();
            this.Add_Single = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Cust_ID = new System.Windows.Forms.TextBox();
            this.Start_Date = new System.Windows.Forms.TextBox();
            this.Store_ID = new System.Windows.Forms.TextBox();
            this.End_Date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultsTab = new System.Windows.Forms.TabPage();
            this.ResultsTable = new System.Windows.Forms.DataGridView();
            this.File_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Store_Id_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Id_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Export_DGV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Export = new System.Windows.Forms.Button();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.checkedListBox_Output_Type = new System.Windows.Forms.CheckedListBox();
            this.Edit_Output_Location_Settings = new System.Windows.Forms.Button();
            this.Export_Location = new System.Windows.Forms.TextBox();
            this.File_Export_Loc_Label = new System.Windows.Forms.Label();
            this.Output_Type_Settings = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ResultsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsTable)).BeginInit();
            this.SettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.ResultsTab);
            this.tabControl1.Controls.Add(this.SettingsTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Region_ID);
            this.tabPage1.Controls.Add(this.Trans_ID);
            this.tabPage1.Controls.Add(this.Region_ID_Label);
            this.tabPage1.Controls.Add(this.Transaction_ID_Label);
            this.tabPage1.Controls.Add(this.Edit_Button);
            this.tabPage1.Controls.Add(this.Move_Bottom_Button);
            this.tabPage1.Controls.Add(this.Move_Top_Button);
            this.tabPage1.Controls.Add(this.Entry_Error_Label);
            this.tabPage1.Controls.Add(this.Move_Down_Button);
            this.tabPage1.Controls.Add(this.Move_Up_Button);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Add_Multiple);
            this.tabPage1.Controls.Add(this.Multiple_Entry_Text_Box);
            this.tabPage1.Controls.Add(this.Search_Button);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.RemoveSearch);
            this.tabPage1.Controls.Add(this.Add_Single);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.Cust_ID);
            this.tabPage1.Controls.Add(this.Start_Date);
            this.tabPage1.Controls.Add(this.Store_ID);
            this.tabPage1.Controls.Add(this.End_Date);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Region_ID
            // 
            this.Region_ID.Location = new System.Drawing.Point(91, 147);
            this.Region_ID.Name = "Region_ID";
            this.Region_ID.Size = new System.Drawing.Size(100, 20);
            this.Region_ID.TabIndex = 56;
            // 
            // Trans_ID
            // 
            this.Trans_ID.Location = new System.Drawing.Point(91, 124);
            this.Trans_ID.Name = "Trans_ID";
            this.Trans_ID.Size = new System.Drawing.Size(100, 20);
            this.Trans_ID.TabIndex = 55;
            // 
            // Region_ID_Label
            // 
            this.Region_ID_Label.AutoSize = true;
            this.Region_ID_Label.Location = new System.Drawing.Point(34, 150);
            this.Region_ID_Label.Name = "Region_ID_Label";
            this.Region_ID_Label.Size = new System.Drawing.Size(55, 13);
            this.Region_ID_Label.TabIndex = 76;
            this.Region_ID_Label.Text = "Region ID";
            // 
            // Transaction_ID_Label
            // 
            this.Transaction_ID_Label.AutoSize = true;
            this.Transaction_ID_Label.Location = new System.Drawing.Point(12, 127);
            this.Transaction_ID_Label.Name = "Transaction_ID_Label";
            this.Transaction_ID_Label.Size = new System.Drawing.Size(77, 13);
            this.Transaction_ID_Label.TabIndex = 77;
            this.Transaction_ID_Label.Text = "Transaction ID";
            // 
            // Edit_Button
            // 
            this.Edit_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Edit_Button.Location = new System.Drawing.Point(212, 417);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(75, 23);
            this.Edit_Button.TabIndex = 75;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Move_Bottom_Button
            // 
            this.Move_Bottom_Button.Location = new System.Drawing.Point(387, 439);
            this.Move_Bottom_Button.Name = "Move_Bottom_Button";
            this.Move_Bottom_Button.Size = new System.Drawing.Size(91, 23);
            this.Move_Bottom_Button.TabIndex = 74;
            this.Move_Bottom_Button.Text = "Move Bottom";
            this.Move_Bottom_Button.UseVisualStyleBackColor = true;
            this.Move_Bottom_Button.Click += new System.EventHandler(this.Move_Bottom_Button_Click);
            // 
            // Move_Top_Button
            // 
            this.Move_Top_Button.Location = new System.Drawing.Point(387, 417);
            this.Move_Top_Button.Name = "Move_Top_Button";
            this.Move_Top_Button.Size = new System.Drawing.Size(91, 23);
            this.Move_Top_Button.TabIndex = 73;
            this.Move_Top_Button.Text = "Move Top";
            this.Move_Top_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Move_Top_Button.UseVisualStyleBackColor = true;
            this.Move_Top_Button.Click += new System.EventHandler(this.Move_Top_Button_Click);
            // 
            // Entry_Error_Label
            // 
            this.Entry_Error_Label.AutoSize = true;
            this.Entry_Error_Label.Location = new System.Drawing.Point(36, 423);
            this.Entry_Error_Label.Name = "Entry_Error_Label";
            this.Entry_Error_Label.Size = new System.Drawing.Size(59, 13);
            this.Entry_Error_Label.TabIndex = 72;
            this.Entry_Error_Label.Text = "Entry Error!";
            this.Entry_Error_Label.Visible = false;
            // 
            // Move_Down_Button
            // 
            this.Move_Down_Button.Location = new System.Drawing.Point(293, 439);
            this.Move_Down_Button.Name = "Move_Down_Button";
            this.Move_Down_Button.Size = new System.Drawing.Size(91, 23);
            this.Move_Down_Button.TabIndex = 71;
            this.Move_Down_Button.Text = "Move Down";
            this.Move_Down_Button.UseVisualStyleBackColor = true;
            this.Move_Down_Button.Click += new System.EventHandler(this.Move_Down_Button_Click);
            // 
            // Move_Up_Button
            // 
            this.Move_Up_Button.Location = new System.Drawing.Point(293, 417);
            this.Move_Up_Button.Name = "Move_Up_Button";
            this.Move_Up_Button.Size = new System.Drawing.Size(91, 23);
            this.Move_Up_Button.TabIndex = 70;
            this.Move_Up_Button.Text = "Move Up";
            this.Move_Up_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Move_Up_Button.UseVisualStyleBackColor = true;
            this.Move_Up_Button.Click += new System.EventHandler(this.Move_Up_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Search Queue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Multiple Entry";
            // 
            // Add_Multiple
            // 
            this.Add_Multiple.Location = new System.Drawing.Point(115, 418);
            this.Add_Multiple.Name = "Add_Multiple";
            this.Add_Multiple.Size = new System.Drawing.Size(75, 22);
            this.Add_Multiple.TabIndex = 67;
            this.Add_Multiple.Text = "Add Multiple";
            this.Add_Multiple.UseVisualStyleBackColor = true;
            this.Add_Multiple.Click += new System.EventHandler(this.Add_Multiple_Click);
            // 
            // Multiple_Entry_Text_Box
            // 
            this.Multiple_Entry_Text_Box.Location = new System.Drawing.Point(19, 227);
            this.Multiple_Entry_Text_Box.Name = "Multiple_Entry_Text_Box";
            this.Multiple_Entry_Text_Box.Size = new System.Drawing.Size(173, 188);
            this.Multiple_Entry_Text_Box.TabIndex = 66;
            this.Multiple_Entry_Text_Box.Text = "";
            this.Multiple_Entry_Text_Box.TextChanged += new System.EventHandler(this.Multiple_Entry_Text_Box_TextChanged);
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(482, 422);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(172, 36);
            this.Search_Button.TabIndex = 65;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_ID,
            this.Start_Date_Column,
            this.End_Date_Column,
            this.Store_ID_Column,
            this.Transaction_ID_Column,
            this.Region_ID_Column});
            this.dataGridView1.Location = new System.Drawing.Point(212, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(442, 383);
            this.dataGridView1.TabIndex = 64;
            // 
            // Customer_ID
            // 
            this.Customer_ID.HeaderText = "Cust. ID";
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            this.Customer_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Customer_ID.Width = 70;
            // 
            // Start_Date_Column
            // 
            this.Start_Date_Column.HeaderText = "Start Date";
            this.Start_Date_Column.Name = "Start_Date_Column";
            this.Start_Date_Column.ReadOnly = true;
            this.Start_Date_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Start_Date_Column.Width = 70;
            // 
            // End_Date_Column
            // 
            this.End_Date_Column.HeaderText = "End Date";
            this.End_Date_Column.Name = "End_Date_Column";
            this.End_Date_Column.ReadOnly = true;
            this.End_Date_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.End_Date_Column.Width = 70;
            // 
            // Store_ID_Column
            // 
            this.Store_ID_Column.HeaderText = "Store ID";
            this.Store_ID_Column.Name = "Store_ID_Column";
            this.Store_ID_Column.ReadOnly = true;
            this.Store_ID_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Store_ID_Column.Width = 70;
            // 
            // Transaction_ID_Column
            // 
            this.Transaction_ID_Column.HeaderText = "Trans. ID";
            this.Transaction_ID_Column.Name = "Transaction_ID_Column";
            this.Transaction_ID_Column.ReadOnly = true;
            this.Transaction_ID_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Transaction_ID_Column.Width = 70;
            // 
            // Region_ID_Column
            // 
            this.Region_ID_Column.HeaderText = "Region ID";
            this.Region_ID_Column.Name = "Region_ID_Column";
            this.Region_ID_Column.ReadOnly = true;
            this.Region_ID_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Region_ID_Column.Width = 70;
            // 
            // RemoveSearch
            // 
            this.RemoveSearch.Location = new System.Drawing.Point(212, 439);
            this.RemoveSearch.Name = "RemoveSearch";
            this.RemoveSearch.Size = new System.Drawing.Size(75, 23);
            this.RemoveSearch.TabIndex = 63;
            this.RemoveSearch.Text = "Remove";
            this.RemoveSearch.UseVisualStyleBackColor = true;
            this.RemoveSearch.Click += new System.EventHandler(this.RemoveSearch_Click);
            // 
            // Add_Single
            // 
            this.Add_Single.Location = new System.Drawing.Point(117, 171);
            this.Add_Single.Name = "Add_Single";
            this.Add_Single.Size = new System.Drawing.Size(75, 22);
            this.Add_Single.TabIndex = 58;
            this.Add_Single.Text = "Add Single";
            this.Add_Single.UseVisualStyleBackColor = true;
            this.Add_Single.Click += new System.EventHandler(this.Add_Single_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Single Entry";
            // 
            // Cust_ID
            // 
            this.Cust_ID.Location = new System.Drawing.Point(91, 32);
            this.Cust_ID.Name = "Cust_ID";
            this.Cust_ID.Size = new System.Drawing.Size(100, 20);
            this.Cust_ID.TabIndex = 51;
            // 
            // Start_Date
            // 
            this.Start_Date.Location = new System.Drawing.Point(91, 55);
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.Size = new System.Drawing.Size(100, 20);
            this.Start_Date.TabIndex = 52;
            // 
            // Store_ID
            // 
            this.Store_ID.Location = new System.Drawing.Point(91, 101);
            this.Store_ID.Name = "Store_ID";
            this.Store_ID.Size = new System.Drawing.Size(100, 20);
            this.Store_ID.TabIndex = 54;
            // 
            // End_Date
            // 
            this.End_Date.Location = new System.Drawing.Point(91, 78);
            this.End_Date.Name = "End_Date";
            this.End_Date.Size = new System.Drawing.Size(100, 20);
            this.End_Date.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Store ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "End Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Customer ID";
            // 
            // ResultsTab
            // 
            this.ResultsTab.Controls.Add(this.ResultsTable);
            this.ResultsTab.Controls.Add(this.Export);
            this.ResultsTab.Location = new System.Drawing.Point(4, 22);
            this.ResultsTab.Name = "ResultsTab";
            this.ResultsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ResultsTab.Size = new System.Drawing.Size(673, 635);
            this.ResultsTab.TabIndex = 1;
            this.ResultsTab.Text = "Results";
            this.ResultsTab.UseVisualStyleBackColor = true;
            // 
            // ResultsTable
            // 
            this.ResultsTable.AllowUserToAddRows = false;
            this.ResultsTable.AllowUserToDeleteRows = false;
            this.ResultsTable.AllowUserToResizeColumns = false;
            this.ResultsTable.AllowUserToResizeRows = false;
            this.ResultsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ResultsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ResultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.File_Name,
            this.Store_Id_DGV,
            this.Customer_Id_DGV,
            this.Date_DGV,
            this.Export_DGV});
            this.ResultsTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.ResultsTable.Location = new System.Drawing.Point(3, 3);
            this.ResultsTable.Name = "ResultsTable";
            this.ResultsTable.Size = new System.Drawing.Size(559, 629);
            this.ResultsTable.TabIndex = 2;
            // 
            // File_Name
            // 
            this.File_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.File_Name.HeaderText = "File Name";
            this.File_Name.Name = "File_Name";
            this.File_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.File_Name.Width = 79;
            // 
            // Store_Id_DGV
            // 
            this.Store_Id_DGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Store_Id_DGV.HeaderText = "Store ID";
            this.Store_Id_DGV.Name = "Store_Id_DGV";
            this.Store_Id_DGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Store_Id_DGV.Width = 71;
            // 
            // Customer_Id_DGV
            // 
            this.Customer_Id_DGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Customer_Id_DGV.HeaderText = "Customer ID";
            this.Customer_Id_DGV.Name = "Customer_Id_DGV";
            this.Customer_Id_DGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Customer_Id_DGV.Width = 90;
            // 
            // Date_DGV
            // 
            this.Date_DGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date_DGV.HeaderText = "Date";
            this.Date_DGV.Name = "Date_DGV";
            this.Date_DGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date_DGV.Width = 55;
            // 
            // Export_DGV
            // 
            this.Export_DGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Export_DGV.DataPropertyName = "toBeExported";
            this.Export_DGV.FalseValue = "NoExport";
            this.Export_DGV.HeaderText = "Export";
            this.Export_DGV.Name = "Export_DGV";
            this.Export_DGV.TrueValue = "Export";
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(592, 606);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(75, 23);
            this.Export.TabIndex = 1;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click_1);
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.checkedListBox_Output_Type);
            this.SettingsTab.Controls.Add(this.Edit_Output_Location_Settings);
            this.SettingsTab.Controls.Add(this.Export_Location);
            this.SettingsTab.Controls.Add(this.File_Export_Loc_Label);
            this.SettingsTab.Controls.Add(this.Output_Type_Settings);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(673, 635);
            this.SettingsTab.TabIndex = 2;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // checkedListBox_Output_Type
            // 
            this.checkedListBox_Output_Type.AllowDrop = true;
            this.checkedListBox_Output_Type.CausesValidation = false;
            this.checkedListBox_Output_Type.FormattingEnabled = true;
            this.checkedListBox_Output_Type.Items.AddRange(new object[] {
            "List",
            "Concatenated PDF File",
            "Zip Folder"});
            this.checkedListBox_Output_Type.Location = new System.Drawing.Point(21, 45);
            this.checkedListBox_Output_Type.Name = "checkedListBox_Output_Type";
            this.checkedListBox_Output_Type.Size = new System.Drawing.Size(118, 49);
            this.checkedListBox_Output_Type.TabIndex = 0;
            this.checkedListBox_Output_Type.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Edit_Output_Location_Settings
            // 
            this.Edit_Output_Location_Settings.Location = new System.Drawing.Point(127, 149);
            this.Edit_Output_Location_Settings.Name = "Edit_Output_Location_Settings";
            this.Edit_Output_Location_Settings.Size = new System.Drawing.Size(75, 23);
            this.Edit_Output_Location_Settings.TabIndex = 6;
            this.Edit_Output_Location_Settings.Text = "Change";
            this.Edit_Output_Location_Settings.UseVisualStyleBackColor = true;
            // 
            // Export_Location
            // 
            this.Export_Location.Location = new System.Drawing.Point(21, 151);
            this.Export_Location.Name = "Export_Location";
            this.Export_Location.Size = new System.Drawing.Size(100, 20);
            this.Export_Location.TabIndex = 5;
            // 
            // File_Export_Loc_Label
            // 
            this.File_Export_Loc_Label.AutoSize = true;
            this.File_Export_Loc_Label.Location = new System.Drawing.Point(18, 135);
            this.File_Export_Loc_Label.Name = "File_Export_Loc_Label";
            this.File_Export_Loc_Label.Size = new System.Drawing.Size(100, 13);
            this.File_Export_Loc_Label.TabIndex = 4;
            this.File_Export_Loc_Label.Text = "File Export Location";
            // 
            // Output_Type_Settings
            // 
            this.Output_Type_Settings.AutoSize = true;
            this.Output_Type_Settings.Location = new System.Drawing.Point(18, 28);
            this.Output_Type_Settings.Name = "Output_Type_Settings";
            this.Output_Type_Settings.Size = new System.Drawing.Size(66, 13);
            this.Output_Type_Settings.TabIndex = 0;
            this.Output_Type_Settings.Text = "Output Type";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 685);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainPage";
            this.Text = "Invoice Finder";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResultsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsTable)).EndInit();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        /*tab control*/
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage ResultsTab;
        private System.Windows.Forms.TabPage SettingsTab;

        /*results tab*/
        private System.Windows.Forms.Button Export;

        /*Search tab*/

        /*settings tab*/
        private System.Windows.Forms.DataGridView ResultsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn File_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Store_Id_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Id_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_DGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Export_DGV;
        private System.Windows.Forms.Button Edit_Output_Location_Settings;
        private System.Windows.Forms.TextBox Export_Location;
        private System.Windows.Forms.Label File_Export_Loc_Label;
        private System.Windows.Forms.Label Output_Type_Settings;
        private System.Windows.Forms.CheckedListBox checkedListBox_Output_Type;
        private System.Windows.Forms.TextBox Region_ID;
        private System.Windows.Forms.TextBox Trans_ID;
        private System.Windows.Forms.Label Region_ID_Label;
        private System.Windows.Forms.Label Transaction_ID_Label;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Move_Bottom_Button;
        private System.Windows.Forms.Button Move_Top_Button;
        private System.Windows.Forms.Label Entry_Error_Label;
        private System.Windows.Forms.Button Move_Down_Button;
        private System.Windows.Forms.Button Move_Up_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_Multiple;
        private System.Windows.Forms.RichTextBox Multiple_Entry_Text_Box;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Date_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_Date_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Store_ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region_ID_Column;
        private System.Windows.Forms.Button RemoveSearch;
        private System.Windows.Forms.Button Add_Single;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Cust_ID;
        private System.Windows.Forms.TextBox Start_Date;
        private System.Windows.Forms.TextBox Store_ID;
        private System.Windows.Forms.TextBox End_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}

