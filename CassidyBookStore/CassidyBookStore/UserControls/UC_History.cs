using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using CassidyBookStore.DAO;
using CassidyBookStore.DTO;

namespace CassidyBookStore.UserControls
{
    public partial class UC_History : UserControl
    {
        int curRowIndex = -1;
        
        public UC_History()
        {
            InitializeComponent();
            LoadOrder();
            
        }

        void LoadOrder()
        {
            string query = "SELECT ORDERS.ID, FULLNAME, CONVERT(DATE,GETDATE()) AS DATE, TOTAL, STATUS FROM ORDERS JOIN CUSTOMERS ON CUSTOMERSID = CUSTOMERS.ID";
            dtgvOrder.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgvOrder.ClearSelection();
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            dtgvOrder.DataSource = OrderDAO.Instance.SearchOrder(txtSearch.Text);
        }

        private void dtgvOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (dtgvOrder.Rows[e.RowIndex].Cells["STATUS"].Value != null)
                {
                    int status = int.Parse(dtgvOrder.Rows[e.RowIndex].Cells["STATUS"].Value.ToString());
                    switch(status)
                    {
                        case 0:
                            e.Value = Properties.Resources.pending;
                            break;
                        case 1:
                            e.Value = Properties.Resources.finalized;
                            break;
                        case 2:
                            e.Value = Properties.Resources.aborted;
                            break;
                        default:
                            e.Value = null;
                            break;
                    }                    
                }
            }
        }

        private void dtgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                curRowIndex = e.RowIndex;
            }
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            if (curRowIndex >= 0)
            {
                int orderID = (int)dtgvOrder.Rows[curRowIndex].Cells["ID"].Value;
                try
                {
                    OrderDAO.Instance.FinalizedOrder(orderID);
                    MessageBox.Show("Order Finalized");
                    LoadOrder();
                }
                catch
                {
                    MessageBox.Show("Can't finalize order");
                }
            }
            else
            {
                MessageBox.Show("Please choose an order to finalize");
            }
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            if (curRowIndex >= 0)
            {
                int orderID = (int)dtgvOrder.Rows[curRowIndex].Cells["ID"].Value;
                try
                {
                    OrderDAO.Instance.AbortedOrder(orderID);
                    MessageBox.Show("Order Aborted");
                    LoadOrder();
                }
                catch
                {
                    MessageBox.Show("Can't abort order");
                }
            }
            else
            {
                MessageBox.Show("Please choose an order to abort");
            }
        }
    }
}
