using AIS_acc_rec_PO.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.AIS_acc_rec_PO.UserControls;

namespace AIS_acc_rec_PO
{
    public partial class FormDashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public FormDashboard()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_Organization org = new UC_Organization();
            AddControlsToPanel(org);
            lblModule.Text = "Организация";
        }
        private void moveSidePanel(Control btn)
        {
           panelSide.Top = btn.Top;
           panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

       
        private void btnExitDash_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть программу?", "АИС управление дебиторской задолженностью", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
              Application.Exit();
            }
            
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 16;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();

                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 16;
                if (panelLeft.Width <= 58)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();

                }
            }

        }

        private void btnOrganisation_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnOrganisation);
            UC_Organization org = new UC_Organization();
            AddControlsToPanel(org);
            toolTip1.Show("Организация", btnOrganisation);
            lblModule.Text = "Организация";
        }

        private void btnContragent_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnContragent);
            UC_Contragent ca = new UC_Contragent();
            AddControlsToPanel(ca);
            toolTip1.Show("Контрагент", btnContragent);
            lblModule.Text = "Контрагент";
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnContract);
            UC_Contract con = new UC_Contract();
            AddControlsToPanel(con);
            toolTip1.Show("Договора", btnContract);
            lblModule.Text = "Договора";

        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnAct);
            UC_Act act = new UC_Act();
            AddControlsToPanel(act);
            toolTip1.Show("Акты выполненных работ", btnAct);
            lblModule.Text = "Акты выполненных работ";
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnStaff);
            UC_Staff sf = new UC_Staff();
            AddControlsToPanel(sf);
            toolTip1.Show("Cотрудники", btnStaff);
            lblModule.Text = "Сотрудники";

        }

        private void btnInfoProgramm_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnInfoProgramm);
           UC_AboutProgramm prog = new UC_AboutProgramm();
            AddControlsToPanel(prog);
            toolTip1.Show("О программе", btnInfoProgramm);
            lblModule.Text = "О программе";
        }

    }
}
