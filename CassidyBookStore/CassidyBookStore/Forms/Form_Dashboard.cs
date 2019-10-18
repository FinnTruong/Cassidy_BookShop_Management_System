using CassidyBookStore.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CassidyBookStore.Forms
{
    public partial class Form_Dashboard : Form
    {
        int panelWidth;
        bool isCollapsed;

        public Form_Dashboard()
        {
            InitializeComponent();
            panelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
       
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panelLeft.Width += 10;
                if(panelLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width -= 10;
                if(panelLeft.Width <= 65)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void BtnSlideMenu_Click(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panelLeft.Visible = false;
                panelLeft.Width = panelWidth;
                panelAnimator.ShowSync(panelLeft);
                isCollapsed = false;
            }
            else
            {
                panelLeft.Visible = false;
                panelLeft.Width = 71;
                panelAnimator.ShowSync(panelLeft);
                isCollapsed = true;
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            UC_Users ucu = new UC_Users();
            AddControlsToPanel(ucu);
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            UC_SaleDetails ucs = new UC_SaleDetails();
            AddControlsToPanel(ucs);
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            UC_Order uco = new UC_Order();
            AddControlsToPanel(uco);
        }
    }
}
