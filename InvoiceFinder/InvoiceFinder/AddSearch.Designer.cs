namespace InvoiceFinder
{
    partial class AddSearch
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
            this.Cust_ID = new System.Windows.Forms.TextBox();
            this.Start_Date = new System.Windows.Forms.TextBox();
            this.Region_ID = new System.Windows.Forms.TextBox();
            this.Transaction_ID = new System.Windows.Forms.TextBox();
            this.Store_ID = new System.Windows.Forms.TextBox();
            this.End_Date = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Invoice_Queue = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RemoveSearch = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cust_ID
            // 
            this.Cust_ID.Location = new System.Drawing.Point(81, 47);
            this.Cust_ID.Name = "Cust_ID";
            this.Cust_ID.Size = new System.Drawing.Size(100, 20);
            this.Cust_ID.TabIndex = 0;
            // 
            // Start_Date
            // 
            this.Start_Date.Location = new System.Drawing.Point(81, 70);
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.Size = new System.Drawing.Size(100, 20);
            this.Start_Date.TabIndex = 1;
            // 
            // Region_ID
            // 
            this.Region_ID.Location = new System.Drawing.Point(81, 162);
            this.Region_ID.Name = "Region_ID";
            this.Region_ID.Size = new System.Drawing.Size(100, 20);
            this.Region_ID.TabIndex = 2;
            // 
            // Transaction_ID
            // 
            this.Transaction_ID.Location = new System.Drawing.Point(81, 139);
            this.Transaction_ID.Name = "Transaction_ID";
            this.Transaction_ID.Size = new System.Drawing.Size(100, 20);
            this.Transaction_ID.TabIndex = 3;
            // 
            // Store_ID
            // 
            this.Store_ID.Location = new System.Drawing.Point(81, 116);
            this.Store_ID.Name = "Store_ID";
            this.Store_ID.Size = new System.Drawing.Size(100, 20);
            this.Store_ID.TabIndex = 4;
            // 
            // End_Date
            // 
            this.End_Date.Location = new System.Drawing.Point(81, 93);
            this.End_Date.Name = "End_Date";
            this.End_Date.Size = new System.Drawing.Size(100, 20);
            this.End_Date.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(187, 18);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Region ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Transaction ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Store ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "End Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Edit Search Details";
            // 
            // Invoice_Queue
            // 
            this.Invoice_Queue.FormattingEnabled = true;
            this.Invoice_Queue.Location = new System.Drawing.Point(187, 47);
            this.Invoice_Queue.Name = "Invoice_Queue";
            this.Invoice_Queue.Size = new System.Drawing.Size(368, 225);
            this.Invoice_Queue.TabIndex = 15;
            this.Invoice_Queue.SelectedIndexChanged += new System.EventHandler(this.Invoice_Queue_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(571, 326);
            this.tabControl1.TabIndex = 16;
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
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(563, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RemoveSearch
            // 
            this.RemoveSearch.Location = new System.Drawing.Point(268, 18);
            this.RemoveSearch.Name = "RemoveSearch";
            this.RemoveSearch.Size = new System.Drawing.Size(75, 23);
            this.RemoveSearch.TabIndex = 16;
            this.RemoveSearch.Text = "Remove";
            this.RemoveSearch.UseVisualStyleBackColor = true;
            this.RemoveSearch.Click += new System.EventHandler(this.RemoveSearch_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(563, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 326);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddSearch";
            this.Text = "Add Search";
            this.Load += new System.EventHandler(this.AddSearch_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Cust_ID;
        private System.Windows.Forms.TextBox Start_Date;
        private System.Windows.Forms.TextBox Region_ID;
        private System.Windows.Forms.TextBox Transaction_ID;
        private System.Windows.Forms.TextBox Store_ID;
        private System.Windows.Forms.TextBox End_Date;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Invoice_Queue;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button RemoveSearch;
    }
}