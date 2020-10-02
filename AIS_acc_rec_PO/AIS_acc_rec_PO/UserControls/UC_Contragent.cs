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
    public partial class UC_Contragent : UserControl
    {
        public UC_Contragent()
        {
            InitializeComponent();
        }

       

        private void btnPrintToExcelContragent_Click(object sender, EventArgs e)
        {
            using (FormReportContragent fd = new FormReportContragent())
            {
                fd.ShowDialog();

            }
       
        }
    }
}
