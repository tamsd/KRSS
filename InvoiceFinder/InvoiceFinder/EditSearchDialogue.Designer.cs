namespace InvoiceFinder
{
    partial class EditSearchDialogue
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
            this.Edit_Region_ID = new System.Windows.Forms.TextBox();
            this.Edit_Trans_ID = new System.Windows.Forms.TextBox();
            this.Region_ID_Label = new System.Windows.Forms.Label();
            this.Transaction_ID_Label = new System.Windows.Forms.Label();
            this.Save_And_Close_Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Edit_Cust_ID = new System.Windows.Forms.TextBox();
            this.Edit_Start_Date = new System.Windows.Forms.TextBox();
            this.Edit_Store_ID = new System.Windows.Forms.TextBox();
            this.Edit_End_Date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Date_Entry_Error_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Edit_Region_ID
            // 
            this.Edit_Region_ID.Location = new System.Drawing.Point(87, 141);
            this.Edit_Region_ID.Name = "Edit_Region_ID";
            this.Edit_Region_ID.Size = new System.Drawing.Size(100, 20);
            this.Edit_Region_ID.TabIndex = 56;
            // 
            // Edit_Trans_ID
            // 
            this.Edit_Trans_ID.Location = new System.Drawing.Point(87, 118);
            this.Edit_Trans_ID.Name = "Edit_Trans_ID";
            this.Edit_Trans_ID.Size = new System.Drawing.Size(100, 20);
            this.Edit_Trans_ID.TabIndex = 55;
            // 
            // Region_ID_Label
            // 
            this.Region_ID_Label.AutoSize = true;
            this.Region_ID_Label.Location = new System.Drawing.Point(30, 144);
            this.Region_ID_Label.Name = "Region_ID_Label";
            this.Region_ID_Label.Size = new System.Drawing.Size(55, 13);
            this.Region_ID_Label.TabIndex = 63;
            this.Region_ID_Label.Text = "Region ID";
            // 
            // Transaction_ID_Label
            // 
            this.Transaction_ID_Label.AutoSize = true;
            this.Transaction_ID_Label.Location = new System.Drawing.Point(8, 121);
            this.Transaction_ID_Label.Name = "Transaction_ID_Label";
            this.Transaction_ID_Label.Size = new System.Drawing.Size(77, 13);
            this.Transaction_ID_Label.TabIndex = 64;
            this.Transaction_ID_Label.Text = "Transaction ID";
            // 
            // Save_And_Close_Button
            // 
            this.Save_And_Close_Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save_And_Close_Button.Location = new System.Drawing.Point(92, 166);
            this.Save_And_Close_Button.Name = "Save_And_Close_Button";
            this.Save_And_Close_Button.Size = new System.Drawing.Size(94, 22);
            this.Save_And_Close_Button.TabIndex = 57;
            this.Save_And_Close_Button.Text = "Save and Close";
            this.Save_And_Close_Button.UseVisualStyleBackColor = true;
            this.Save_And_Close_Button.Click += new System.EventHandler(this.Save_And_Close_Button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Edit Search";
            // 
            // Edit_Cust_ID
            // 
            this.Edit_Cust_ID.Location = new System.Drawing.Point(87, 26);
            this.Edit_Cust_ID.Name = "Edit_Cust_ID";
            this.Edit_Cust_ID.Size = new System.Drawing.Size(100, 20);
            this.Edit_Cust_ID.TabIndex = 51;
            // 
            // Edit_Start_Date
            // 
            this.Edit_Start_Date.Location = new System.Drawing.Point(87, 49);
            this.Edit_Start_Date.Name = "Edit_Start_Date";
            this.Edit_Start_Date.Size = new System.Drawing.Size(100, 20);
            this.Edit_Start_Date.TabIndex = 52;
            this.Edit_Start_Date.TextChanged += new System.EventHandler(this.Edit_Start_Date_TextChanged);
            // 
            // Edit_Store_ID
            // 
            this.Edit_Store_ID.Location = new System.Drawing.Point(87, 95);
            this.Edit_Store_ID.Name = "Edit_Store_ID";
            this.Edit_Store_ID.Size = new System.Drawing.Size(100, 20);
            this.Edit_Store_ID.TabIndex = 54;
            // 
            // Edit_End_Date
            // 
            this.Edit_End_Date.Location = new System.Drawing.Point(87, 72);
            this.Edit_End_Date.Name = "Edit_End_Date";
            this.Edit_End_Date.Size = new System.Drawing.Size(100, 20);
            this.Edit_End_Date.TabIndex = 53;
            this.Edit_End_Date.TextChanged += new System.EventHandler(this.Edit_End_Date_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Store ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "End Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Customer ID";
            // 
            // Date_Entry_Error_Label
            // 
            this.Date_Entry_Error_Label.AutoSize = true;
            this.Date_Entry_Error_Label.Location = new System.Drawing.Point(33, 170);
            this.Date_Entry_Error_Label.Name = "Date_Entry_Error_Label";
            this.Date_Entry_Error_Label.Size = new System.Drawing.Size(58, 13);
            this.Date_Entry_Error_Label.TabIndex = 66;
            this.Date_Entry_Error_Label.Text = "Date Error!";
            this.Date_Entry_Error_Label.Visible = false;
            // 
            // EditSearchDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 194);
            this.Controls.Add(this.Date_Entry_Error_Label);
            this.Controls.Add(this.Edit_Region_ID);
            this.Controls.Add(this.Edit_Trans_ID);
            this.Controls.Add(this.Region_ID_Label);
            this.Controls.Add(this.Transaction_ID_Label);
            this.Controls.Add(this.Save_And_Close_Button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Edit_Cust_ID);
            this.Controls.Add(this.Edit_Start_Date);
            this.Controls.Add(this.Edit_Store_ID);
            this.Controls.Add(this.Edit_End_Date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditSearchDialogue";
            this.Text = "EditSearchDialogue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Edit_Region_ID;
        private System.Windows.Forms.TextBox Edit_Trans_ID;
        private System.Windows.Forms.Label Region_ID_Label;
        private System.Windows.Forms.Label Transaction_ID_Label;
        private System.Windows.Forms.Button Save_And_Close_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Edit_Cust_ID;
        private System.Windows.Forms.TextBox Edit_Start_Date;
        private System.Windows.Forms.TextBox Edit_Store_ID;
        private System.Windows.Forms.TextBox Edit_End_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Date_Entry_Error_Label;
    }
}