using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AIS_acc_rec_PO.Forms
{
    public partial class FormExitMessage : Form
    {
        public FormExitMessage()
        {
            InitializeComponent();
        }

        private void btnСloseProg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
