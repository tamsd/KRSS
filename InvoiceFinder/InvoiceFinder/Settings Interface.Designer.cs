namespace InvoiceFinder
{
    partial class SettingsInterface
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
            this.List = new System.Windows.Forms.CheckBox();
            this.ConcPDF = new System.Windows.Forms.CheckBox();
            this.ZipFolder = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.AutoSize = true;
            this.List.Location = new System.Drawing.Point(144, 79);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(42, 17);
            this.List.TabIndex = 0;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            this.List.CheckedChanged += new System.EventHandler(this.List_CheckedChanged);
            // 
            // ConcPDF
            // 
            this.ConcPDF.AutoSize = true;
            this.ConcPDF.Location = new System.Drawing.Point(144, 117);
            this.ConcPDF.Name = "ConcPDF";
            this.ConcPDF.Size = new System.Drawing.Size(136, 17);
            this.ConcPDF.TabIndex = 1;
            this.ConcPDF.Text = "Concatenated PDF File";
            this.ConcPDF.UseVisualStyleBackColor = true;
            this.ConcPDF.CheckedChanged += new System.EventHandler(this.ConcPDF_CheckedChanged);
            // 
            // ZipFolder
            // 
            this.ZipFolder.AutoSize = true;
            this.ZipFolder.Location = new System.Drawing.Point(144, 161);
            this.ZipFolder.Name = "ZipFolder";
            this.ZipFolder.Size = new System.Drawing.Size(70, 17);
            this.ZipFolder.TabIndex = 2;
            this.ZipFolder.Text = "ZipFolder";
            this.ZipFolder.UseVisualStyleBackColor = true;
            this.ZipFolder.CheckedChanged += new System.EventHandler(this.ZipFolder_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Output Type";
            // 
            // SettingsInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 331);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ZipFolder);
            this.Controls.Add(this.ConcPDF);
            this.Controls.Add(this.List);
            this.Name = "SettingsInterface";
            this.Text = "SettingsInterface";
            this.Load += new System.EventHandler(this.SettingsInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.CheckBox List;
        private System.Windows.Forms.CheckBox ConcPDF;
        private System.Windows.Forms.CheckBox ZipFolder;
        private System.Windows.Forms.TextBox textBox1;
    }
}