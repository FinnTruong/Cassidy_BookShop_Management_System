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
        }

        private void btn_BackDetails_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Order");
        }

    }
}
