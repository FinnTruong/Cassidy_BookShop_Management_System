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
using System.Text.RegularExpressions;

namespace CassidyBookStore.UserControls
{
    public partial class UC_Order : UserControl
    {
        int curOrderID = -1;
        int curRowIndex = 0;
        int customerStatus = 0; //0: new customer || 1: existing customer
        

        public UC_Order()
        {
            InitializeComponent();
            curOrderID = OrderDAO.Instance.GetMaxIDOrder();
            ShowCart();
            LoadBookTitle();
            GetTotal();
            LoadExistingCustomer();
        }

        #region Navigate
        private void btn_NextProfile_Click(object sender, EventArgs e)
        {
            float temp;

            if (CartItemDAO.Instance.IsCartEmpty(curOrderID))
            {
                MessageBox.Show("Cart Is Empty");
                return;
            }
            if(!float.TryParse(txt_Discount.Text, out temp) && txt_Discount.Text != "")
            {
                MessageBox.Show("Invalid Discount");
                return;
            }

            else
                bunifuPages1.SetPage("Customer");

        }

        private void btn_BackDetails_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Order");
        }
        private void btn_NextConfirm_Click(object sender, EventArgs e)
        {
            //Add New Customer
            if (customerStatus == 0)
            {
                if (CustomerDAO.Instance.IsExistedEmail(txt_Email.Text) && txt_Email.Text != "")
                {
                    if (MessageBox.Show("This email has already existed. Are you sure this is a new customer?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                }

                //Check customer's info  
                if (!IsValidPhone(txt_Phone.Text) || !IsValidEmail(txt_Email.Text))
                {
                    MessageBox.Show("Invalid Info");
                    return;
                }
            }           

            //Existing Customer
            

            //Set final info before confirm
            bunifuPages1.SetPage("Confirm");
            lb_Name.Text = txt_FullName.Text;
            lb_Phone.Text = txt_Phone.Text;
            lb_Email.Text = txt_Email.Text;
            lb_Address.Text = txt_Address.Text;
            lbCity.Text = txt_City.Text;
            lb_Country.Text = Card.Text;
            lb_SubTotal.Text = txt_Amount.Text;
            if (txt_Discount.Text != "")
                lb_Discount.Text = float.Parse(txt_Discount.Text).ToString("c", new CultureInfo("en-US"));
            else
                lb_Discount.Text = 0.ToString("c", new CultureInfo("en-US"));

            lb_Total.Text = lb_Amount.Text;
        }
        private void btn_EditInfo_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Customer");
        }

        private void btn_EditAddress_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Customer");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Customer");
        }
        private void btn_ExistingCustomer_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("CustomerDatabase");
        }

        #endregion

        #region Order

        #region Functions
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


                lsvCart.Items.Add(lsvItem);
            }

            txt_Amount.Text = CartItemDAO.Instance.GetCartTotalByOrder(curOrderID).ToString();
        }

        void ClearAll()
        {
            txtBookTitle.Clear();
            ClearInfo();
        }

        void ClearInfo()
        {
            txtID.Visible = true;
            cbID.Visible = false;
            txtID.Clear();
            txtAuthor.Clear();
            txtStock.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtRemain.Clear();
            
        }


        private void GetRemain(object sender, EventArgs e)
        {
            int num;            
            if (int.TryParse(txtQuantity.Text, out num) && int.TryParse(txtStock.Text, out num))
            {

                int stock = int.Parse(txtStock.Text);
                int quantity = int.Parse(txtQuantity.Text);
                if(quantity <= 0)
                {
                    MessageBox.Show("Invalid quantity");
                    return;
                }
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
            int bookID;
            if (cbID.Visible == true)
            {
                bookID = int.Parse(cbID.Text);
            }
            else
            {
                bookID = int.Parse(txtID.Text);
            }
            int remain = int.Parse(txtRemain.Text);
            BookDAO.Instance.UpdateStorage(bookID, remain);
        }

        void LoadBookTitle()
        {
            AutoCompleteStringCollection bookTitle = new AutoCompleteStringCollection();
            List<string> listBookTilte = BookDAO.Instance.LoadBookTitle();
            foreach (string item in listBookTilte)
            {
                bookTitle.Add(item);
            }

            txtBookTitle.AutoCompleteCustomSource = bookTitle;
        }

        void LoadComboBoxID(string bookTitle)
        {
            List<string> bookID = new List<string>();
            List<string> listBookID = BookDAO.Instance.LoadBookID(bookTitle);
            foreach (string item in listBookID)
            {
                bookID.Add(item);
            }
            cbID.DataSource = bookID;
            cbID.MaxDropDownItems = bookID.Count() + 1;
        }

        void GetTotal()
        {
            //Get Total of current item in Order/Cart
            float total = CartItemDAO.Instance.GetCartTotalByOrder(curOrderID);
            string totalString = total.ToString("c", new CultureInfo("en-US")); //convert total to currency string

            txt_Amount.Text = totalString;
            lb_Amount.Text = totalString;
                  
            float num;
            if (float.TryParse(txt_Discount.Text, out num)) //Discount is float
            {                
                float discount = float.Parse(txt_Discount.Text);
                total -= discount;
                if (total >= 0)
                    lb_Amount.Text = total.ToString("c", new CultureInfo("en-US"));

                else //Discount > Amount
                {
                    MessageBox.Show("Invalid");
                    txt_Discount.Clear();
                }
            }            
        }
        #endregion

        #region Events
        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = curOrderID;
                int bookID;
                if(cbID.Visible == true)
                {
                    bookID = int.Parse(cbID.Text);
                }
                else
                {
                    bookID = int.Parse(txtID.Text);
                }
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            //Clear ListView
            lsvCart.Items.Clear();

            //Update Storage
            List<int> listBookID = CartItemDAO.Instance.GetAllBookIDFromCart(curOrderID); //get all the book from current order
            foreach (int item in listBookID) //loop through every book
            {
                int quantity = CartItemDAO.Instance.GetBookQuantity(item, curOrderID); //get the book quantity in the cart
                int stock = int.Parse(BookDAO.Instance.GetStock(item)); //get current stock of book from storage
                int remain = stock + quantity; //calculate the book stock after clear the cart
                BookDAO.Instance.UpdateStorage(item, remain); //Update the storage
            }

            //Clear From Database
            CartItemDAO.Instance.ClearAllCartItem(curOrderID);

            //Reset Amount, Total, Discount
            txt_Discount.Text = "";
            GetTotal();

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(txtID.Text, out num) && BookDAO.Instance.IsAcceptedID(int.Parse(txtID.Text)))
            {
                int id = int.Parse(txtID.Text);                
                txtAuthor.Text = BookDAO.Instance.GetAuthor(id);
                txtStock.Text = BookDAO.Instance.GetStock(id);
                txtPrice.Text = BookDAO.Instance.GetPrice(id);
            }
        }
        private void cbID_TextChanged(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(cbID.Text, out num) && BookDAO.Instance.IsAcceptedID(int.Parse(cbID.Text)))
            {
                int id = int.Parse(cbID.Text);                
                txtAuthor.Text = BookDAO.Instance.GetAuthor(id);
                txtStock.Text = BookDAO.Instance.GetStock(id);
                txtPrice.Text = BookDAO.Instance.GetPrice(id);
            }
        }
        private void cbID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(cbID.SelectedItem.ToString(), out num) && BookDAO.Instance.IsAcceptedID(int.Parse(cbID.SelectedItem.ToString())))
            {
                int id = int.Parse(cbID.SelectedItem.ToString());
                txtAuthor.Text = BookDAO.Instance.GetAuthor(id);
                txtStock.Text = BookDAO.Instance.GetStock(id);
                txtPrice.Text = BookDAO.Instance.GetPrice(id);
            }
        }

        private void txtBookTitle_TextChanged(object sender, EventArgs e)
        {
            if (BookDAO.Instance.IsAcceptedBookTitle(txtBookTitle.Text))
            {
                if (BookDAO.Instance.IsSameTitle(txtBookTitle.Text))
                {
                    txtID.Visible = false;
                    cbID.Visible = true;
                    InfoProvider.SetError(txtBookTitle, "There are more than one book with this title. Please specified ID");
                    LoadComboBoxID(txtBookTitle.Text);
                }
                else
                {
                    InfoProvider.SetError(txtBookTitle, null);
                    txtID.Text = BookDAO.Instance.GetIdFromBookTitle(txtBookTitle.Text);
                }
            }           
            else
            {
                ClearInfo();
            }
        }

        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {
            GetTotal();
        }

        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {
            GetTotal();
        }
        #endregion

        #endregion

        #region Customer

        #region Validating Functions
        
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        public bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, "^([0-9]{9,10})");
        }

        #endregion

        #region Validating Events
        private void txt_Phone_Validated(object sender, EventArgs e)
        {
            if (!IsValidPhone(txt_Phone.Text))
            {
                errorProvider1.SetError(txt_Phone, "Invalid Phone Number");
            }
            else
            {
                errorProvider1.SetError(txt_Phone, null);
            }
        }

        private void txt_Email_Validated(object sender, EventArgs e)
        {
            if (!IsValidEmail(txt_Email.Text))
            {
                errorProvider1.SetError(txt_Email, "Invalid Email");
            }
            else
            {
                errorProvider1.SetError(txt_Email, null);
            }
        }
        #endregion
        void DisableAllCustomerField()
        {
            txt_FullName.Enabled = false;
            txt_Phone.Enabled = false;
            txt_Email.Enabled = false;
            txt_Address.Enabled = false;
            txt_City.Enabled = false;
        }

        void EnableAllCustomerField()
        {
            txt_FullName.Enabled = true;
            txt_Phone.Enabled = true;
            txt_Email.Enabled = true;
            txt_Address.Enabled = true;
            txt_City.Enabled = true;
        }

        void ClearAllCustomerField()
        {
            txt_FullName.Clear();
            txt_Phone.Clear();
            txt_Email.Clear();
            txt_Address.Clear();
            txt_City.Clear();
        }

        private void btn_NewCustomer_Click(object sender, EventArgs e)
        {
            customerStatus = 0;
            btn_NewCustomer.Visible = false;
            btn_ExistingCustomer.Visible = true;
            EnableAllCustomerField();
            ClearAllCustomerField();
        }


        #region Customer Database        

        void LoadExistingCustomer()
        {
            string query = "SELECT * FROM CUSTOMERS";
            dtgvCustomer.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void AutoFillCustomer(DataGridViewRow row)
        {
            txt_FullName.Text = row.Cells["fullname"].Value.ToString();
            txt_Phone.Text = row.Cells["phone"].Value.ToString();
            txt_Email.Text = row.Cells["email"].Value.ToString();
            txt_Address.Text = row.Cells["address"].Value.ToString();
            txt_City.Text = row.Cells["city"].Value.ToString();
        }        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Customer> listCustomer = CustomerDAO.Instance.SearchCustomer(txtSearch.Text);
            dtgvCustomer.DataSource = listCustomer;
        }
        private void dtgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                curRowIndex = e.RowIndex;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(curRowIndex < 0)
            {
                MessageBox.Show("Please select a customer");
                return;
            }
            else
            {
                AutoFillCustomer(dtgvCustomer.Rows[curRowIndex]);
                DisableAllCustomerField();
                btn_ExistingCustomer.Visible = false;
                btn_NewCustomer.Visible = true;
                customerStatus = 1;
                bunifuPages1.SetPage("Customer");
            }
        }

        #endregion

        #endregion

        #region Confirm Order
        private void UpdateOrder()
        {
            int customerID = GetCustomerID();
            float discount = float.Parse(lb_Discount.Text, NumberStyles.Currency);
            float total = float.Parse(lb_Total.Text, NumberStyles.Currency);
            try
            {
                OrderDAO.Instance.UpdateOrder(customerID, discount, total, curOrderID);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void AddNewCustomer()
        {
            string fullname = txt_FullName.Text;
            string phone = txt_Phone.Text;
            string email = txt_Email.Text;
            string address = txt_Address.Text;
            string city = txt_City.Text;
            CustomerDAO.Instance.AddNewCustomer(fullname, phone, email, address, city);
        }
            
        
        private int GetCustomerID()
        {
            //Get New Customer ID
            if(customerStatus == 0)
            {
                return CustomerDAO.Instance.GetMaxIDCustomer();
            }
            //Get Existing Customer ID
            else
            {
                return int.Parse(dtgvCustomer.Rows[curRowIndex].Cells["Id"].Value.ToString());
            }
        }

        private void ConfirmOrder()
        {
            if(customerStatus == 0)
            {
                AddNewCustomer();
            }
            try
            {
                UpdateOrder();
                MessageBox.Show("Order Confirmed");
            }
            catch
            {
                MessageBox.Show("Error");
            }

            OrderDAO.Instance.AddNewOrder();
            curOrderID = OrderDAO.Instance.GetMaxIDOrder();
            ClearAll();
            ClearAllCustomerField();            
            lsvCart.Items.Clear();            
            CartItemDAO.Instance.ClearAllCartItem(curOrderID);            
            txt_Discount.Text = "";
            GetTotal();
            bunifuPages1.SetPage(0);


        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            ConfirmOrder();
        }


        #endregion


    }
}
