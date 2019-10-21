using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CassidyBookStore.UserControls
{
    public partial class UC_Order : UserControl
    {
        public UC_Order()
        {
            InitializeComponent();
            
        }

        private void btn_NextProfile_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Customer");
        }

        private void btn_NextConfirm_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Confirm");
            lb_Name.Text = txt_FullName.Text;
            lb_Phone.Text = txt_Phone.Text;
            lb_Email.Text = txt_Email.Text;
            lb_Address.Text = txt_Address.Text;
            lbCity.Text = txt_City.Text;
            lb_Country.Text = txt_Country.Text;
        }

        private void btn_BackDetails_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Order");
        }

        private void btn_EditInfo_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Customer");
        }

        private void btn_EditAddress_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Customer");
        }
    }
}
