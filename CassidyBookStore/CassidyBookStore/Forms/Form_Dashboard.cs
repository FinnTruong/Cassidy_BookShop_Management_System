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
    }
}
