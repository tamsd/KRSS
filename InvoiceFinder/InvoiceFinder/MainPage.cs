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
        public Results results;
        public MainPage(ref Results r)
        {
            InitializeComponent();
            CreateResultsTable();
            results = r;
        }

        public void CreateResultsTable()
        {
            Label File_Name = new Label();
            File_Name.Dock = DockStyle.Fill;
            File_Name.Text = "File Name";
            File_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ResultsTable.Controls.Add(File_Name, 0, 0);

            Label Path = new Label();
            Path.Dock = DockStyle.Fill;
            Path.Text = "Path";
            Path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ResultsTable.Controls.Add(Path, 1, 0);

            Label Export = new Label();
            Export.Dock = DockStyle.Fill;
            Export.Text = "Export";
            Export.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ResultsTable.Controls.Add(Export, 2, 0);

            this.ResultsTable.AutoSize = true;
            this.ResultsTable.BackColor = System.Drawing.Color.Transparent;
            this.ResultsTable.Dock = System.Windows.Forms.DockStyle.Top;

            this.ResultsTable.Location = new System.Drawing.Point(0, 0);
            this.ResultsTable.Name = "ResultsTable";
            this.ResultsTable.TabIndex = 0;
        }

        public void FillTable(){
            for (int i = 1; i < 5; i++ )
            {
                string text = i.ToString();
                Label name = new Label();
                name.Dock = DockStyle.Fill;
                name.Text = text;
                name.TextAlign = ContentAlignment.MiddleLeft;

                text = "C:/" + i.ToString();
                Label path = new Label();
                path.Dock = DockStyle.Fill;
                path.Text = text;
                path.TextAlign = ContentAlignment.MiddleLeft;

                RadioButton radio_button = new RadioButton();
                radio_button.Dock = DockStyle.Fill;
                radio_button.CheckAlign = ContentAlignment.MiddleCenter;
                radio_button.Checked = true;

                ResultsTable.Controls.Add(name, 0, i);
                ResultsTable.Controls.Add(path, 1, i);
                ResultsTable.Controls.Add(radio_button, 2, i);
            }
        }
    }
}
