using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AIS_acc_rec_PO.Forms;

namespace AIS_acc_rec_PO
{
    public partial class UC_Contract : UserControl
    {
        public UC_Contract()
        {
            InitializeComponent();
        }

        

        private void btnPrintToExcel_Click_1(object sender, EventArgs e)
        {
            using (FormReportContract fd = new FormReportContract())
            {
                fd.ShowDialog();

            }
        }

        private void btnPrExcOVR_Click(object sender, EventArgs e)
        {
            using (FormReportContract fd = new FormReportContract())
            {
                fd.ShowDialog();

            }
        }
    }
}
