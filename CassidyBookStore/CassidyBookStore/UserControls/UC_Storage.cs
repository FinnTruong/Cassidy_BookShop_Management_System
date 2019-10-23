using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            for (int i = 0; i < 50; i++)
            {
                bunifuDataGridView1.Rows.Add(
                    new object[]
                    {
                    "1",
                    "Test",
                    "Test",
                    "100",
                    "20",
                    "120"
                    }
                    );
            }
        }
    }
}
