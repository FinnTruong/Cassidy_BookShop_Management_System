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
    public partial class UC_SaleDetails : UserControl
    {
        Random rand = new Random();
        public UC_SaleDetails()
        {
            InitializeComponent();
        }

        private void BunifuDataViz1_Load(object sender, EventArgs e)
        {

        }

        private void LoadChart()
        {
            var cnv = new Bunifu.DataViz.WinForms.Canvas();
            var dataPoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);
            var dataPoint2 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);

            dataPoint.addLabely("Mon", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Tue", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Wed", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Thu", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Fri", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Sat", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Sun", rand.Next(0, 500).ToString());

            dataPoint2.addLabely("Mon", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Tue", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Wed", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Thu", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Fri", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Sat", rand.Next(0, 500).ToString());
            dataPoint2.addLabely("Sun", rand.Next(0, 500).ToString());


            cnv.addData(dataPoint);
            cnv.addData(dataPoint2);
            bunifuDataViz1.colorSet.Add(Color.FromArgb(49, 197, 176));
            bunifuDataViz1.colorSet.Add(Color.Yellow);
            bunifuDataViz1.Render(cnv);

        }

        private void LoadChart2()
        {
            var cnv = new Bunifu.DataViz.WinForms.Canvas();
            var dataPoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_column);

            dataPoint.addLabely("Mon", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Tue", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Wed", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Thu", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Fri", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Sat", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Sun", rand.Next(0, 500).ToString());



            cnv.addData(dataPoint);
            bunifuDataViz1.colorSet.Add(Color.FromArgb(49, 197, 176));
            bunifuDataViz2.Render(cnv);

        }

        private void LoadData_Tick(object sender, EventArgs e)
        {
            loadData.Stop();
            LoadChart();
            LoadChart2();            
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            LoadChart();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BunifuDataViz2_Load(object sender, EventArgs e)
        {

        }
    }
}
