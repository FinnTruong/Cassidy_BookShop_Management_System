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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            UC_Storage ucs = new UC_Storage();
            AddControlsToPanel(ucs);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            UC_Expenses uce = new UC_Expenses();
            AddControlsToPanel(uce);
        }

        private void btnOrderInfo_Click(object sender, EventArgs e)
        {
            UC_History uch = new UC_History();
            AddControlsToPanel(uch);
        }
    }
}
