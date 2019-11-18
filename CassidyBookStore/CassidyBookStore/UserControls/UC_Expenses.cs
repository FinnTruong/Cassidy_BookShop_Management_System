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

namespace CassidyBookStore.UserControls
{
    public partial class UC_Expenses : UserControl
    {
        public UC_Expenses()
        {
            InitializeComponent();
            PopulateDataGrid();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form_AddExpense form = new Form_AddExpense())
            {
                form.ShowDialog();
            }
        }

        void PopulateDataGrid()
        {

        }

    }
}
