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
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            using (Form_AddBook form = new Form_AddBook())
            {
                form.ShowDialog();
            }
            PopulateDataGrid();

        }
    }
}
