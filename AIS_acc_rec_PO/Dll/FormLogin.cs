using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AIS_acc_rec_PO
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "1" & tbPswd.Text == "1")
            {
                using ( FormN fd = new ())
                {
                    fd.ShowDialog();
                }
            }
        }
            else
            {
                using (FormDashboard fd = new FormDashboard())
                {
                    fd.ShowDialog();
                }
            }
            
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
