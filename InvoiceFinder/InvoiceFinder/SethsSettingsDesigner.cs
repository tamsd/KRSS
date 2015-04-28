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
            this.RemoveSearch = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Invoice_Queue = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cust_ID = new System.Windows.Forms.TextBox();
            this.Start_Date = new System.Windows.Forms.TextBox();
            this.End_Date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Store_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Transaction_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Region_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ResultsTable = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Add_Location = new System.Windows.Forms.Button();
            this.Export_Location = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ZipFolder = new System.Windows.Forms.CheckBox();
            this.ConcPDF = new System.Windows.Forms.CheckBox();
            this.List = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RemoveSearch);
            this.tabPage1.Controls.Add(this.Add);
            this.tabPage1.Controls.Add(this.Invoice_Queue);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Cust_ID);
            this.tabPage1.Controls.Add(this.Start_Date);
            this.tabPage1.Controls.Add(this.End_Date);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Store_ID);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Transaction_ID);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Region_ID);
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
            // RemoveSearch
            // 
            this.RemoveSearch.Location = new System.Drawing.Point(281, 17);
            this.RemoveSearch.Name = "RemoveSearch";
            this.RemoveSearch.Size = new System.Drawing.Size(75, 23);
            this.RemoveSearch.TabIndex = 32;
            this.RemoveSearch.Text = "Remove";
            this.RemoveSearch.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(200, 17);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 23;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Invoice_Queue
            // 
            this.Invoice_Queue.FormattingEnabled = true;
            this.Invoice_Queue.Location = new System.Drawing.Point(200, 46);
            this.Invoice_Queue.Name = "Invoice_Queue";
            this.Invoice_Queue.Size = new System.Drawing.Size(368, 225);
            this.Invoice_Queue.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Edit Search Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Region ID";
            // 
            // Cust_ID
            // 
            this.Cust_ID.Location = new System.Drawing.Point(94, 46);
            this.Cust_ID.Name = "Cust_ID";
            this.Cust_ID.Size = new System.Drawing.Size(100, 20);
            this.Cust_ID.TabIndex = 17;
            // 
            // Start_Date
            // 
            this.Start_Date.Location = new System.Drawing.Point(94, 69);
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.Size = new System.Drawing.Size(100, 20);
            this.Start_Date.TabIndex = 18;
            // 
            // End_Date
            // 
            this.End_Date.Location = new System.Drawing.Point(94, 92);
            this.End_Date.Name = "End_Date";
            this.End_Date.Size = new System.Drawing.Size(100, 20);
            this.End_Date.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Transaction ID";
            // 
            // Store_ID
            // 
            this.Store_ID.Location = new System.Drawing.Point(94, 115);
            this.Store_ID.Name = "Store_ID";
            this.Store_ID.Size = new System.Drawing.Size(100, 20);
            this.Store_ID.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Store ID";
            // 
            // Transaction_ID
            // 
            this.Transaction_ID.Location = new System.Drawing.Point(94, 138);
            this.Transaction_ID.Name = "Transaction_ID";
            this.Transaction_ID.Size = new System.Drawing.Size(100, 20);
            this.Transaction_ID.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "End Date";
            // 
            // Region_ID
            // 
            this.Region_ID.Location = new System.Drawing.Point(94, 161);
            this.Region_ID.Name = "Region_ID";
            this.Region_ID.Size = new System.Drawing.Size(100, 20);
            this.Region_ID.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Customer ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ResultsTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Results";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ResultsTable
            // 
            this.ResultsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ResultsTable.ColumnCount = 6;
            this.ResultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.53192F));
            this.ResultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.76596F));
            this.ResultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.76596F));
            this.ResultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.2766F));
            this.ResultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.2766F));
            this.ResultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.382979F));
            this.ResultsTable.Location = new System.Drawing.Point(6, 6);
            this.ResultsTable.Name = "ResultsTable";
            this.ResultsTable.RowCount = 1;
            this.ResultsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.ResultsTable.Size = new System.Drawing.Size(661, 32);
            this.ResultsTable.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Add_Location);
            this.tabPage3.Controls.Add(this.Export_Location);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.ZipFolder);
            this.tabPage3.Controls.Add(this.ConcPDF);
            this.tabPage3.Controls.Add(this.List);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(673, 635);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Add_Location
            // 
            this.Add_Location.Location = new System.Drawing.Point(235, 254);
            this.Add_Location.Name = "Add_Location";
            this.Add_Location.Size = new System.Drawing.Size(86, 23);
            this.Add_Location.TabIndex = 12;
            this.Add_Location.Text = "Add";
            this.Add_Location.UseVisualStyleBackColor = true;
            this.Add_Location.Click += new System.EventHandler(this.Add_Location_Click);
            // 
            // Export_Location
            // 
            this.Export_Location.Location = new System.Drawing.Point(86, 257);
            this.Export_Location.Name = "Export_Location";
            this.Export_Location.Size = new System.Drawing.Size(100, 20);
            this.Export_Location.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "File Export Location: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Output Type: ";
            // 
            // ZipFolder
            // 
            this.ZipFolder.AutoSize = true;
            this.ZipFolder.Location = new System.Drawing.Point(86, 173);
            this.ZipFolder.Name = "ZipFolder";
            this.ZipFolder.Size = new System.Drawing.Size(70, 17);
            this.ZipFolder.TabIndex = 6;
            this.ZipFolder.Text = "ZipFolder";
            this.ZipFolder.UseVisualStyleBackColor = true;
            // 
            // ConcPDF
            // 
            this.ConcPDF.AutoSize = true;
            this.ConcPDF.Location = new System.Drawing.Point(86, 129);
            this.ConcPDF.Name = "ConcPDF";
            this.ConcPDF.Size = new System.Drawing.Size(136, 17);
            this.ConcPDF.TabIndex = 5;
            this.ConcPDF.Text = "Concatenated PDF File";
            this.ConcPDF.UseVisualStyleBackColor = true;
            // 
            // List
            // 
            this.List.AutoSize = true;
            this.List.Location = new System.Drawing.Point(86, 91);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(42, 17);
            this.List.TabIndex = 4;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 685);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel ResultsTable;
        private System.Windows.Forms.Button RemoveSearch;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox Invoice_Queue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cust_ID;
        private System.Windows.Forms.TextBox Start_Date;
        private System.Windows.Forms.TextBox End_Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Store_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Transaction_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Region_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox ZipFolder;
        private System.Windows.Forms.CheckBox ConcPDF;
        private System.Windows.Forms.CheckBox List;
        private System.Windows.Forms.Button Add_Location;
        private System.Windows.Forms.TextBox Export_Location;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

