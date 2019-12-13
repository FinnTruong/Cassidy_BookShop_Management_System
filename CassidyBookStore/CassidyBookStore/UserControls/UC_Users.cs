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
using CassidyBookStore.DAO;
using CassidyBookStore.DTO;

namespace CassidyBookStore.UserControls
{
    public partial class UC_Users : UserControl
    {
        int curRowIndex = 0;

        public UC_Users()
        {
            InitializeComponent();
            PopulateDataGrid();

        }

        private void PopulateDataGrid()
        {
            dtgvUsers.DataSource = SearchUserByName(txtSearchBox.Text);
            dtgvUsers.ClearSelection();
            curRowIndex = -1;
        }

        private List<User> SearchUserByName(string name)
        {
            List<User> listUser = UserDAO.Instance.SearchUserByName(name);
            return listUser;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            using (Form_AddUser form = new Form_AddUser())
            {
                form.ShowDialog();
                PopulateDataGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgvUsers.Rows[curRowIndex].Cells["ID"].Value.ToString());
            try
            {
                AccountDAO.Instance.DeleteAccount(id);
                UserDAO.Instance.DeleteUser(id);
                MessageBox.Show("Delete User Successfully");
                PopulateDataGrid();
            }
            catch
            {
                MessageBox.Show("Can't Delete User");
            }
        }

        private void dtgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                curRowIndex = e.RowIndex;
            }
        }

        

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {            
            dtgvUsers.DataSource = SearchUserByName(txtSearchBox.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(curRowIndex == -1)
            {
                MessageBox.Show("Please choose user to edit info");
                return;
            }
            using (Form_EditUser form = new Form_EditUser(this, curRowIndex))
            {
                form.ShowDialog();
                PopulateDataGrid();
            }
        }
    }
}
