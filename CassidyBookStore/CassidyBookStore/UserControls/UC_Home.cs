using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassidyBookStore.DAO;
using System.Globalization;

namespace CassidyBookStore.UserControls
{
    public partial class UC_Home : UserControl
    {
        Random rand = new Random();
        public UC_Home()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(card1, 10);
            Bunifu.Framework.Lib.Elipse.Apply(card2, 10);
            Bunifu.Framework.Lib.Elipse.Apply(card3, 10);
            Bunifu.Framework.Lib.Elipse.Apply(card4, 10);
            GetStatistic();
            GetBestSeller();
            GetProfits();
            GetTotalOrders();
        }


        private void LoadChart()
        {            
            float totalIncome = OrderDAO.Instance.GetYearIncome("YEAR(GETDATE())");
            float totalExpense = ExpenseDAO.Instance.GetYearExpenses("YEAR(GETDATE())");
            float profits = totalIncome - totalExpense;
            lbTotalIncome.Text = totalIncome.ToString("c0", new CultureInfo("en-US"));
            lbTotalExpense.Text = totalExpense.ToString("c0", new CultureInfo("en-US"));
            if (profits < 0)
                lbTotalProfits.Text = "-" + (Math.Abs(profits)).ToString("c0", new CultureInfo("en-US"));
            else
                lbTotalProfits.Text = profits.ToString("c0", new CultureInfo("en-US"));

            var cnv = new Bunifu.DataViz.WinForms.Canvas();
            var dataPoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);
            var dataPoint2 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);

            dataPoint.addLabely("Jan", OrderDAO.Instance.GetThisMonthIncome("1").ToString());
            dataPoint.addLabely("Feb", OrderDAO.Instance.GetThisMonthIncome("2").ToString());
            dataPoint.addLabely("Mar", OrderDAO.Instance.GetThisMonthIncome("3").ToString());
            dataPoint.addLabely("Apr", OrderDAO.Instance.GetThisMonthIncome("4").ToString());
            dataPoint.addLabely("May", OrderDAO.Instance.GetThisMonthIncome("5").ToString());
            dataPoint.addLabely("Jun", OrderDAO.Instance.GetThisMonthIncome("6").ToString());
            dataPoint.addLabely("Jul", OrderDAO.Instance.GetThisMonthIncome("7").ToString());
            dataPoint.addLabely("Aug", OrderDAO.Instance.GetThisMonthIncome("8").ToString());
            dataPoint.addLabely("Sep", OrderDAO.Instance.GetThisMonthIncome("9").ToString());
            dataPoint.addLabely("Oct", OrderDAO.Instance.GetThisMonthIncome("10").ToString());
            dataPoint.addLabely("Nov", OrderDAO.Instance.GetThisMonthIncome("11").ToString());
            dataPoint.addLabely("Dec", OrderDAO.Instance.GetThisMonthIncome("12").ToString());

            dataPoint2.addLabely("Jan", ExpenseDAO.Instance.GetThisMonthExpenses("1").ToString());
            dataPoint2.addLabely("Feb", ExpenseDAO.Instance.GetThisMonthExpenses("2").ToString());
            dataPoint2.addLabely("Mar", ExpenseDAO.Instance.GetThisMonthExpenses("3").ToString());
            dataPoint2.addLabely("Apr", ExpenseDAO.Instance.GetThisMonthExpenses("4").ToString());
            dataPoint2.addLabely("May", ExpenseDAO.Instance.GetThisMonthExpenses("5").ToString());
            dataPoint2.addLabely("Jun", ExpenseDAO.Instance.GetThisMonthExpenses("6").ToString());
            dataPoint2.addLabely("Jul", ExpenseDAO.Instance.GetThisMonthExpenses("7").ToString());
            dataPoint2.addLabely("Aug", ExpenseDAO.Instance.GetThisMonthExpenses("8").ToString());
            dataPoint2.addLabely("Sep", ExpenseDAO.Instance.GetThisMonthExpenses("9").ToString());
            dataPoint2.addLabely("Oct", ExpenseDAO.Instance.GetThisMonthExpenses("10").ToString());
            dataPoint2.addLabely("Nov", ExpenseDAO.Instance.GetThisMonthExpenses("11").ToString());
            dataPoint2.addLabely("Dec", ExpenseDAO.Instance.GetThisMonthExpenses("12").ToString());

            cnv.addData(dataPoint);
            cnv.addData(dataPoint2);
            bunifuDataViz1.colorSet.Add(Color.FromArgb(49, 197, 176));
            bunifuDataViz1.colorSet.Add(Color.Yellow);
            bunifuDataViz1.Render(cnv);

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void LoadData_Tick(object sender, EventArgs e)
        {
            loadData.Stop();
            LoadChart();
        }

        void GetStatistic()
        {
            lbAllConfirmedOrders.Text = OrderDAO.Instance.GetTotalOrder().ToString();
            label3.Text = ExpenseDAO.Instance.GetTotalExpense().ToString("c0", new CultureInfo("en-US"));
            label7.Text = BookDAO.Instance.GetBookCount().ToString();
            label5.Text = CustomerDAO.Instance.GetCustomerCount().ToString();
        }

        void GetBestSeller()
        {
            if (BookDAO.Instance.GetBestSeller() == "no book")
            {
                lbBestSeller.Text = "There is currently no best seller this month";
            }
            else
            {
                lbBestSeller.Text = "This month best seller is " + BookDAO.Instance.GetBestSeller();
            }
        }

        void GetProfits()
        {
            float income = OrderDAO.Instance.GetThisMonthIncome("MONTH(GETDATE())");
            float expense = ExpenseDAO.Instance.GetThisMonthExpenses("MONTH(GETDATE())");
            float profits = income - expense;
            if (profits >= 0)
                lbProfits.Text = "This month profits currently is " + profits.ToString("c", new CultureInfo("en-US"));
            else
                lbProfits.Text = "This month profits currently is -" + Math.Abs(profits).ToString("c", new CultureInfo("en-US"));
        }

        void GetTotalOrders()
        {
            int totalOrders = OrderDAO.Instance.GetThisMonthTotalOrders("MONTH(GETDATE())");
            if (totalOrders > 1)
                lbTotalOrders.Text = "There have been " + totalOrders.ToString() + " confirmed orders this month";
            else
                lbTotalOrders.Text = "There has been " + totalOrders.ToString() + " confirmed order this month";            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadChart();
        }

    }
}
