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
        bool isCollapsed = true;
        
        public UC_History()
        {
            InitializeComponent();
            LoadOrder();
            curRowIndex = 0;
            lbTotal.Text = OrderDAO.Instance.GetTotalOrder().ToString();            
        }

        void LoadOrder()
        {
            string query = "SELECT ORDERS.ID, FULLNAME, DATE, TOTAL, STATUS FROM ORDERS JOIN CUSTOMERS ON CUSTOMERSID = CUSTOMERS.ID";
            dtgvOrder.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgvOrder.ClearSelection();
            curRowIndex = -1;
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
                int status = (int)dtgvOrder.Rows[curRowIndex].Cells["Status"].Value;
                if(status == 2)
                {
                    MessageBox.Show("Can't finalized aborted order");
                    return;
                }
                if(status == 1)
                {
                    MessageBox.Show("This order has already been finalized");
                    return;
                }
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
                int status = (int)dtgvOrder.Rows[curRowIndex].Cells["Status"].Value;
                if(status == 1)
                {
                    MessageBox.Show("Can't abort finalized order");
                    return;
                }
                if (status == 2)
                {
                    MessageBox.Show("This order has already been aborted");
                    return;
                }
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

        #region Filter

        private void Filter(DateTime From, DateTime To)
        {
            if(chkbAllTime.Checked == true)
            {
                string query = "SELECT ORDERS.ID, FULLNAME, DATE, TOTAL, STATUS FROM ORDERS JOIN CUSTOMERS ON CUSTOMERSID = CUSTOMERS.ID";
                dtgvOrder.DataSource = DataProvider.Instance.ExecuteQuery(query);
                lbPeriod.Visible = false;
                lbTotal.Text = OrderDAO.Instance.GetTotalOrder().ToString();
            }
            else if(chkbSpecific.Checked == true)
            {
                if(From.Date > To.Date)
                {                    
                    return;
                }
                else
                {
                    dtgvOrder.DataSource = OrderDAO.Instance.FilterByDate(From, To);
                    lbPeriod.Visible = true;
                    lbPeriod.Text = string.Format("FROM {0}/{1} TO {2}/{3}", From.Day.ToString(), From.Month.ToString(), To.Day.ToString(), To.Day.ToString());
                    lbTotal.Text = OrderDAO.Instance.GetTotalOrderInPeriod(From, To).ToString();
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelFilter.Visible = false;
                panelFilter.Height = 138;
                FilterAnimator.ShowSync(panelFilter);
                isCollapsed = false;
            }
            else
            {
                if(FromDate.Value > ToDate.Value && chkbAllTime.Checked == false)
                {
                    MessageBox.Show("Invalid Date");
                    return;
                }
                Filter(FromDate.Value, ToDate.Value);
                panelFilter.Visible = false;
                panelFilter.Height = 1;
                FilterAnimator.ShowSync(panelFilter);
                isCollapsed = true;
            }
        }


        private void chkbAllTime_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if(chkbAllTime.Checked == true)
            {
                chkbSpecific.Checked = false;
                FromDate.Visible = false;
                ToDate.Visible = false;
            }
            else if(chkbAllTime.Checked == false && chkbSpecific.Checked == false)
            {
                chkbSpecific.Checked = true;
                
            }

        }

        private void chkbSpecific_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkbSpecific.Checked == true)
            {
                chkbAllTime.Checked = false;
                FilterAnimator.ShowSync(FromDate);
                FilterAnimator.ShowSync(ToDate);
            }
            else if(chkbAllTime.Checked == false && chkbSpecific.Checked == false)
            {
                chkbAllTime.Checked = true;
                FromDate.Visible = false;
                ToDate.Visible = false;
            }
        }





        #endregion

    }
}
