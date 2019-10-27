using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CassidyBookStore.Forms
{
    public partial class Form_AddUser : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ACER\Desktop\BookStore\Cassidy_BookShop_Management_System\CassidyBookStore\CassidyBookStore\UserData.mdf;Integrated Security=True");
        public Form_AddUser()
        {
            InitializeComponent();
            (new Core.DropShaddow()).ApplyShadows(this);
        }


        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Finish");
            c3.Checked = c3.Enabled = true;
            label3.ForeColor = Color.Indigo;
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Info");
        }



        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Profile");
        }

        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            try
            {
                String UserName = txtUserName.Text;
                String PassWord = txtPassword.Text;
                String FirstName = txtFirstName.Text;
                String Email = txtEmail.Text;
                long Phone = Int64.Parse(txtPhone.Text);
                long ID = Int64.Parse(txtID.Text);
                String Role = txtRole.Text;
                String LastName = txtLastName.Text;
                con.Open();
                String qry = "insert into Users(UserName,Password,FirstName,Email,Phone,ID,Role,LastName) values('" + UserName + "', '" + PassWord + "','" + FirstName + "','" + Email + "'," + Phone + "," + ID + ",'" + Role + "','" + LastName + "')";
                SqlCommand cmd = new SqlCommand(qry, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 1)
                    MessageBox.Show(i + "Number of User Registered With UserName:" + UserName);
                else
                    MessageBox.Show("User registration failed with username:" + UserName);
            }
            catch (System.Exception exp)
            {
                MessageBox.Show("Some Error Occucred at User Registration: " + exp.ToString());
            }
        }

        private void BunifuPages1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (bunifuPages1.SelectedIndex)
            {
                case 1:
                    c1.Checked = c1.Enabled = true;
                    label1.ForeColor = Color.Indigo;
                    break;
                case 2:
                    c2.Checked = c2.Enabled = true;
                    label2.ForeColor = Color.Indigo;
                    break;
            }
        }


    }
}
