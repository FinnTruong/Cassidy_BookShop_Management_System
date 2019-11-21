using CassidyBookStore.DAO;
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
    public partial class Form_AddBook : Form
    {
        UC_Storage ucs;
        int curRowIndex = -1; //current row selected to edit
        public Form_AddBook(UC_Storage uc, int rowIndex = -1)
        {
            InitializeComponent();
            (new Core.DropShaddow()).ApplyShadows(this);
            this.ucs = uc;
            if(rowIndex != -1)
                curRowIndex = rowIndex;
            AutoFill();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AutoFill()
        {
            if (curRowIndex != -1)
            {
                txtBookTitle.Text = ucs.dtgvBooks.Rows[curRowIndex].Cells["BookTitle"].Value.ToString();
                txtAuthor.Text = ucs.dtgvBooks.Rows[curRowIndex].Cells["Author"].Value.ToString();
                txtStock.Text = ucs.dtgvBooks.Rows[curRowIndex].Cells["Stock"].Value.ToString();
                txtCostPrice.Text = ucs.dtgvBooks.Rows[curRowIndex].Cells["Cost"].Value.ToString();
                txtSellingPrice.Text = ucs.dtgvBooks.Rows[curRowIndex].Cells["Price"].Value.ToString();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(curRowIndex == -1)
            {
                AddNewBook();
            }
            else
            {
                EditInfo();
            }
        }

        private void AddNewBook()
        {
            try
            {
                string bookTitle = txtBookTitle.Text;
                string author = txtAuthor.Text;
                int stock = int.Parse(txtStock.Text);
                float cost = float.Parse(txtCostPrice.Text);
                float price = float.Parse(txtSellingPrice.Text);

                if (BookDAO.Instance.InsertBook(bookTitle, author, stock, cost, price))
                {
                    MessageBox.Show("Add New Book Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void EditInfo()
        {
            try
            {
                int id = int.Parse(ucs.dtgvBooks.Rows[curRowIndex].Cells["ID"].Value.ToString());
                string bookTitle = txtBookTitle.Text;
                string author = txtAuthor.Text;
                int stock = int.Parse(txtStock.Text);
                float cost = float.Parse(txtCostPrice.Text);
                float price = float.Parse(txtSellingPrice.Text);

                if (BookDAO.Instance.UpdateBook(id, bookTitle, author, stock, cost, price))
                {
                    MessageBox.Show("Update Book Info Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
