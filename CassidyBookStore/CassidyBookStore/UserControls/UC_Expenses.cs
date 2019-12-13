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
    public partial class UC_Expenses : UserControl
    {
        int curRowIndex;
        public UC_Expenses()
        {
            InitializeComponent();
            PopulateDataGrid();
        }

        void PopulateDataGrid()
        {
            dtgvExpense.DataSource = DataProvider.Instance.ExecuteQuery("SELECT * FROM EXPENSES");
            dtgvExpense.ClearSelection();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form_AddExpense form = new Form_AddExpense(this))
            {
                form.ShowDialog();
                PopulateDataGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (Form_AddExpense form = new Form_AddExpense(this,curRowIndex))
            {
                form.ShowDialog();
                PopulateDataGrid();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgvExpense.Rows[curRowIndex].Cells["ID"].Value.ToString());

            if (ExpenseDAO.Instance.DeleteExpense(id))
            {
                MessageBox.Show("Delete Expense Successfully");
                PopulateDataGrid();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dtgvExpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                curRowIndex = e.RowIndex;
            }
        }

        
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            dtgvExpense.DataSource = SearchExpenseByName(txtSearchBox.Text);
        }

        private List<Expense> SearchExpenseByName(string name)
        {
            List<Expense> listExpense = ExpenseDAO.Instance.SearchExpenseByName(name);
            return listExpense;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
