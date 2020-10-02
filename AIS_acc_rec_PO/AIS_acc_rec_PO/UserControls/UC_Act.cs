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
    public partial class UC_Act : UserControl
    {
        public UC_Act()
        {
            InitializeComponent();
        }

        private void btnPrintToExcel_Click(object sender, EventArgs e)
        {
            using (FormReportAct fd = new FormReportAct())
            {
                fd.ShowDialog();

            }
        }
    }
}
