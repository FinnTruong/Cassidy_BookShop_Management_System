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

        float totalPrice = 0;
        int curOrderID = -1;
        public UC_Order()
        {
            InitializeComponent();
            curOrderID = OrderDAO.Instance.GetMaxIDOrder();
            ShowCart();
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
            try
            {
                int orderID = curOrderID;
                int bookID = int.Parse(txtID.Text);
                int quantity = int.Parse(txtQuantity.Text);
                float price = float.Parse(txtPrice.Text);

                if (orderID < 1) //chua ton tai order
                {
                    OrderDAO.Instance.AddNewOrder();
                    CartItemDAO.Instance.AddToCart(OrderDAO.Instance.GetMaxIDOrder(), bookID, quantity, price);
                    curOrderID = OrderDAO.Instance.GetMaxIDOrder();
                }
                else //da ton tai
                {
                    CartItemDAO.Instance.AddToCart(orderID, bookID, quantity, price);
                }

                ShowCart();
                UpdateStorage();
                ClearAll();
            }
            catch
            {
                MessageBox.Show("Invalid Info");
            }
        }

        void ShowCart()
        {
            lsvCart.Items.Clear();
            
            List<CartItem> listCart = CartItemDAO.Instance.GetListCartByOrder(curOrderID);            

            foreach (CartItem item in listCart)
            {
                ListViewItem lsvItem = new ListViewItem(item.BookTitle.ToString());
                lsvItem.SubItems.Add(item.Quantity.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Total.ToString());
                totalPrice += item.Total;

                lsvCart.Items.Add(lsvItem);
            }

            txt_Amount.Text = totalPrice.ToString();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            totalPrice = 0;
            txt_Amount.Text = "";
            lsvCart.Items.Clear();

        }

        void ClearInfo()
        {
            txtBookTitle.Clear();
            txtAuthor.Clear();
            txtStock.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtRemain.Clear();
        }

        void ClearAll()
        {
            txtID.Clear();
            ClearInfo();
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

        private void GetRemain(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(txtQuantity.Text, out num) && int.TryParse(txtStock.Text, out num))
            {
                int stock = int.Parse(txtStock.Text);
                int quantity = int.Parse(txtQuantity.Text);
                int remain = stock - quantity;
                if (remain >= 0)
                    txtRemain.Text = remain.ToString();
                else
                {
                    MessageBox.Show("Not enough books");
                    txtQuantity.Clear();
                }
            }
            else
                txtRemain.Text = "";
        }

        void UpdateStorage()
        {
            int bookID = int.Parse(txtID.Text);
            int remain = int.Parse(txtRemain.Text);
            BookDAO.Instance.UpdateStorage(bookID, remain);
        }

        private void GetTotal(object sender, EventArgs e)
        {
            lb_Amount.Text = float.Parse(txt_Amount.Text).ToString("c",new CultureInfo("en-US"));
            float num;
            if (float.TryParse(txt_Discount.Text, out num)) //Discount is float
            {
                float amount = float.Parse(txt_Amount.Text);
                float discount = float.Parse(txt_Discount.Text);
                float total = amount - discount;
                if (total >= 0)
                    lb_Amount.Text = total.ToString("c", new CultureInfo("en-US"));

                else //Discount > Amount
                {
                    MessageBox.Show("Invalid");
                    txt_Discount.Clear();
                }
            }
                     
        }

 
    }
}
