using CassidyBookStore.DAO;
using CassidyBookStore.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CassidyBookStore.Forms
{
    public partial class Form_EditUser : Form
    {
        UC_Users ucu;
        int curRowIndex = -1;
        public Form_EditUser(UC_Users uc, int rowIndex)
        {
            InitializeComponent();
            (new Core.DropShaddow()).ApplyShadows(this);
            this.ucu = uc;
            if (rowIndex != -1)
                curRowIndex = rowIndex;            
        }

        private void Form_EditUser_Load(object sender, EventArgs e)
        {
            AutoFill();
        }

        private void AutoFill()
        {
            if (curRowIndex != -1)
            {
                txtFirstName.Text = ucu.dtgvUsers.Rows[curRowIndex].Cells["FirstName"].Value.ToString();
                txtLastName.Text = ucu.dtgvUsers.Rows[curRowIndex].Cells["LastName"].Value.ToString();
                txtPhone.Text = ucu.dtgvUsers.Rows[curRowIndex].Cells["Phone"].Value.ToString();
                txtEmail.Text = ucu.dtgvUsers.Rows[curRowIndex].Cells["Email"].Value.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(ucu.dtgvUsers.Rows[curRowIndex].Cells["Id"].Value.ToString());
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;
                if(!IsValidEmail(email) || !IsValidPhone(phone))
                {
                    MessageBox.Show("Invalid Info");
                    return;
                }
                UserDAO.Instance.UpdateUser(firstName, lastName, phone, email, id);
                MessageBox.Show("Update User's Information Successully");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Can't Update User's Information");
            }
        }

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

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            bool result = IsValidEmail(txtEmail.Text);
            if (!result)
            {
                errorProvider1.SetError(txtEmail, "Invalid Email");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            bool result = IsValidPhone(txtPhone.Text);
            if(!result)
            {
                errorProvider1.SetError(txtPhone, "Invalid Phone Number");
            }
            else
            {
                errorProvider1.SetError(txtPhone, null);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(ucu.dtgvUsers.Rows[curRowIndex].Cells["ID"].Value.ToString());
                string username = AccountDAO.Instance.ReturnUsernameFromUserID(id);
                bunifuPages1.SetPage(1);
                txt_Username.Text = username;
            }
            catch
            {
                MessageBox.Show("Can't Change Account's Info");                
            }
        }

        private void btn_NewCustomer_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(ucu.dtgvUsers.Rows[curRowIndex].Cells["ID"].Value.ToString());
            string username = txt_Username.Text;
            string password = txtNewPassword.Text;
            string currentPassword = txtCurrentPassword.Text;
            if(username == "" || password == "")
            {
                MessageBox.Show("Please Fill In Account's Info");
                return;
            }
            if(!AccountDAO.Instance.DoesCurrentPasswordValid(currentPassword, userID))
            {
                MessageBox.Show("Incorrect Password");
                return;
            }
            try
            {
                if (groupBox1.Visible == true)
                {
                    AccountDAO.Instance.UpdateAccount(userID, username, password);
                    MessageBox.Show("Update Account Information Successfully");
                    this.Close();
                }
                else
                {
                    AccountDAO.Instance.UpdateUsername(userID, username);
                    MessageBox.Show("Update Username Successfully");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Failed");                
            }
        }
    }
}
