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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
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
    }
}

