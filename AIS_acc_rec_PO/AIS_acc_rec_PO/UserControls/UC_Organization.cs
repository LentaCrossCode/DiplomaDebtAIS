using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AIS_acc_rec_PO.UserControls
{
    public partial class UC_Organization : UserControl
    {
        public UC_Organization()
        {
            InitializeComponent();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Данные об организации изменены", "АИС управление дебиторской задолженностью", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPrintExcel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Данные об организации выводятся на печать", "АИС управление дебиторской задолженностью", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
