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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CassidyBookStore.Forms
{
    public partial class Form_AddExpense : Form
    {
        UC_Expenses uce;
        int curRowIndex = -1;
        public Form_AddExpense(UC_Expenses uc, int rowIndex = -1)
        {
            InitializeComponent();
            (new Core.DropShaddow()).ApplyShadows(this);
            this.uce = uc;
            if(rowIndex != -1)
            {
                curRowIndex = rowIndex;
            }
            AutoFill();
            this.ActiveControl = label;
        }

        private void AutoFill()
        {
            if(curRowIndex != -1)
            {
                txtTitle.Text = uce.dtgvExpense.Rows[curRowIndex].Cells["Title"].Value.ToString();
                txtAmount.Text = uce.dtgvExpense.Rows[curRowIndex].Cells["Amount"].Value.ToString();
                txt_Date.Text = uce.dtgvExpense.Rows[curRowIndex].Cells["Date"].Value.ToString();
                txtDescription.Text = uce.dtgvExpense.Rows[curRowIndex].Cells["Description"].Value.ToString();
            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (curRowIndex == -1)
            {
                AddExpense();
            }
            else
            {
                EditExpense();
            }

        }

        private void AddExpense()
        {
            try
            {
                string title = txtTitle.Text;
                float amount = float.Parse(txtAmount.Text);
                string date = txt_Date.Value.ToString("MM/dd/yyyy");
                string description = txtDescription.Text;
                if(ExpenseDAO.Instance.InsertExpense(title,amount,date,description))
                {
                    MessageBox.Show("Insert Expense Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EditExpense()
        {
            try
            {
                int id = int.Parse(uce.dtgvExpense.Rows[curRowIndex].Cells["Id"].Value.ToString());
                string title = txtTitle.Text;
                float amount = float.Parse(txtAmount.Text);
                string date = txt_Date.Value.ToString("MM/dd/yyyy");
                string description = txtDescription.Text;
                if (ExpenseDAO.Instance.UpdateExpense(title, amount, date, description, id))
                {
                    MessageBox.Show("Update Expense Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
