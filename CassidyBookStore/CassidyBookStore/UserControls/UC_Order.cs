using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassidyBookStore.DTO;
using CassidyBookStore.DAO;
using System.Globalization;

namespace CassidyBookStore.UserControls
{
    public partial class UC_Order : UserControl
    {

        int totalPrice = 0;
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

        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            ShowCart();
        }

        void ShowCart()
        {
            List<Cart> listCart = CartDAO.Instance.GetListCartByTable();            

            foreach (Cart item in listCart)
            {
                ListViewItem lsvItem = new ListViewItem(item.BookTitle.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Total.ToString());
                totalPrice += item.Total;

                lsvCart.Items.Add(lsvItem);
            }

            CultureInfo culture = new CultureInfo("en-US");

            txt_Amount.Text = totalPrice.ToString("c",culture);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            totalPrice = 0;
            txt_Amount.Text = totalPrice.ToString("c");
            lsvCart.Items.Clear();
        }

        void ClearInfo()
        {
            txtBookTitle.Clear();
            txtAuthor.Clear();
            txtStock.Clear();
            txtPrice.Clear();
            txtRemain.Clear();
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {
            ClearInfo();
            int num;
            if (int.TryParse(txtID.Text, out num) && BookDAO.Instance.IsAcceptedID(int.Parse(txtID.Text)))
            {
                int id = int.Parse(txtID.Text);
                txtBookTitle.Text = BookDAO.Instance.GetBookTitle(id);
                txtAuthor.Text = BookDAO.Instance.GetAuthor(id);
                txtStock.Text = BookDAO.Instance.GetStock(id);
                txtPrice.Text = BookDAO.Instance.GetPrice(id);
            }                       
        }
    }
}
