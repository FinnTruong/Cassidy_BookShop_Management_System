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
        }


        private void LoadChart()
        {
            var cnv = new Bunifu.DataViz.WinForms.Canvas();
            var dataPoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);
            var dataPoint2 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);

            dataPoint.addLabely("Jan", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Feb", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Mar", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Apr", rand.Next(0, 500).ToString());
            dataPoint.addLabely("May", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Jun", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Jul", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Aug", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Sep", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Oct", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Nov", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Dec", rand.Next(0, 500).ToString());

            dataPoint2.addLabely("Jan", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Feb", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Mar", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Apr", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("May", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Jun", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Jul", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Aug", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Sep", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Oct", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Nov", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Dec", rand.Next(0, 500).ToString());

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
            label2.Text = OrderDAO.Instance.GetOrderCount().ToString();
            label3.Text = ExpenseDAO.Instance.GetTotalExpense().ToString("c", new CultureInfo("en-US"));
            label7.Text = BookDAO.Instance.GetBookCount().ToString();
            label5.Text = CustomerDAO.Instance.GetCustomerCount().ToString();
        }

    }
}
