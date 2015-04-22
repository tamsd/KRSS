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
    public partial class SettingsInterface : Form
    {

        public Settings set;
        public Finder find;

        public SettingsInterface(ref Settings setting, ref Finder finder)
        {
            InitializeComponent();
            set = setting;
            find = finder;
        }
        private void List_CheckedChanged(object sender, EventArgs e)
        {
            //if (List.Checked == false)
            //{
            //    set.setOutputType(0);
            //    List.Checked = true;
            //}
            //if (List.Checked == true)
            //{
            //    List.Checked = false;
            //}
            set.setOutputType(0);
        }

        private void ConcPDF_CheckedChanged(object sender, EventArgs e)
        {
            //if (ConcPDF.Checked == false)
            //{
            //    set.setOutputType(1);
            //    ConcPDF.Checked = true;
            //}
            //else if (ConcPDF.Checked == true)
            //{
            //    ConcPDF.Checked = false;
            //}
            set.setOutputType(1);
        }

        private void ZipFolder_CheckedChanged(object sender, EventArgs e)
        {
            //if (ZipFolder.Checked == false)
            //{
            //    set.setOutputType(1);
            //    ZipFolder.Checked = true;
            //}
            //else if (ZipFolder.Checked == true)
            //{
            //    ZipFolder.Checked = false;
            //}
            set.setOutputType(1);
        }

        private void SettingsInterface_Load(object sender, EventArgs e)
        {
            ZipFolder.Checked = true;
        }


    }
}
