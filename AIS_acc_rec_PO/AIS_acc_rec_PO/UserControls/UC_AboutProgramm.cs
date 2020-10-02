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
    public partial class UC_AboutProgramm : UserControl
    {
        public UC_AboutProgramm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            using (FormUser user = new FormUser())
           {
                user.ShowDialog();

            }

        }
    }
}
