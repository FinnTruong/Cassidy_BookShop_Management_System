using CassidyBookStore.DAO;
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
    public partial class Form_AddUser : Form
    {
        public Form_AddUser()
        {
            InitializeComponent();
            (new Core.DropShaddow()).ApplyShadows(this);
            c1.Enabled = true;
            c1.Checked = false;
            label1.ForeColor = Color.Indigo;
        }

        #region Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_PreviousInfo_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Info");
        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {    
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please fill all info");
            }
            else if(!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid Email");
            }
            else if(!IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Invalid Phone Number");
            }
            else
            {
                bunifuPages1.SetPage("Profile");
            }
        }        

        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuPages1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (bunifuPages1.SelectedIndex)
            {
                case 0:
                    label1.ForeColor = Color.Indigo;
                    label2.ForeColor = Color.Gray;                   
                    c2.Enabled = false;
                    c1.Checked = false;
                    break;
                case 1:
                    c1.Checked = c1.Enabled = true;
                    c2.Enabled = true;
                    c2.Checked = false;                    
                    label1.ForeColor = Color.Indigo;
                    label2.ForeColor = Color.Indigo;
                    break;
                case 2:
                    c2.Checked = c2.Enabled = true;
                    label2.ForeColor = Color.Indigo;
                    break;
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

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            bool result = AccountDAO.Instance.IsValidAccountName(txtUsername.Text);           
            if (!result)
            {
                errorProvider1.SetError(txtUsername, "Username already exist");
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void btn_NextFinish_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string firstName = txtFirstName.Text;
                    string lastName = txtLastName.Text;
                    string phone = txtPhone.Text;
                    string email = txtEmail.Text;
                    UserDAO.Instance.InsertUser(firstName, lastName, phone, email);

                }
                catch
                {
                    MessageBox.Show("Can't Insert User");
                    return;
                }

                try
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;
                    int userID = UserDAO.Instance.GetMaxIDUser();
                    AccountDAO.Instance.InsertAccount(username, password, userID);

                }
                catch
                {
                    MessageBox.Show("Can't Create Account");
                    //Delete Added User If Account Can't Be Created
                    UserDAO.Instance.DeleteUser(UserDAO.Instance.GetMaxIDUser());
                    return;
                }               
            }
            catch
            { 
                MessageBox.Show("Error");
                return;
            }

            if (txtPassword.Text == txtRetypePassword.Text)
            {
                bunifuPages1.SetPage("Finish");
                c3.Checked = c3.Enabled = true;
                label3.ForeColor = Color.Indigo;
            }
            else
            {
                MessageBox.Show("Password doesn't match");
                return;
            }

        }
        #endregion

        private void txtPhone_Validated(object sender, EventArgs e)
        {
            if(!IsValidPhone(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Invalid Phone Number");
            }
            else
            {
                errorProvider1.SetError(txtPhone, null);
            }
        }
    }
}

