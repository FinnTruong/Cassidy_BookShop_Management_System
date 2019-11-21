using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassidyBookStore.Forms;
using System.Data.SqlClient;
using CassidyBookStore.DAO;

namespace CassidyBookStore.UserControls
{
    public partial class UC_Storage : UserControl
    {
        int curRowIndex; //Pass current index row to add/edit book

        public UC_Storage()
        {
            InitializeComponent();
        }
        

        private void UC_Storage_Load(object sender, EventArgs e)
        {
            PopulateDataGrid();
        }

        void PopulateDataGrid()
        {
            string query = "SELECT * FROM BOOKS";   

            dtgvBooks.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgvBooks.ClearSelection();
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            using (Form_AddBook form = new Form_AddBook(this, -1)) //pass index -1 to add new book instead of edit
            {
                form.ShowDialog();
                PopulateDataGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (Form_AddBook form = new Form_AddBook(this,curRowIndex))
            {
                form.ShowDialog();
                PopulateDataGrid();
            }
        }


        //Get selected index row to edit
        private void dtgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                curRowIndex = e.RowIndex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgvBooks.Rows[curRowIndex].Cells["ID"].Value.ToString());

            if (BookDAO.Instance.DeleteBook(id))
            {
                MessageBox.Show("Delete Book Successfully");
                PopulateDataGrid();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
