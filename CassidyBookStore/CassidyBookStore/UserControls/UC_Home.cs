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
    public partial class UC_Home : UserControl
    {
        Random rand = new Random();
        public UC_Home()
        {
            InitializeComponent();
        }

       
        private void LoadChart1()
        {
            var cnv = new Bunifu.DataViz.WinForms.Canvas();
            var dataPoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);

            dataPoint.addLabely("Jan", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Feb", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Mar", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Apr", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Jun", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Jul", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Aug", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Sep", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Oct", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Nov", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Dec", rand.Next(0, 500).ToString());

            cnv.addData(dataPoint);
            bunifuDataViz1.colorSet.Add(Color.Red);
            bunifuDataViz1.Render(cnv);

        }

        private void LoadChart2()
        {
            var cnv = new Bunifu.DataViz.WinForms.Canvas();
            var dataPoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_column);

            dataPoint.addLabely("Mon", rand.Next(0, 100).ToString());
            dataPoint.addLabely("Tue", rand.Next(0, 100).ToString());
            dataPoint.addLabely("Wed", rand.Next(0, 100).ToString());
            dataPoint.addLabely("Thu", rand.Next(0, 100).ToString());
            dataPoint.addLabely("Fri", rand.Next(0, 100).ToString());
            dataPoint.addLabely("Sat", rand.Next(0, 100).ToString());
            dataPoint.addLabely("Sun", rand.Next(0, 100).ToString());
            

            cnv.addData(dataPoint);
            bunifuDataViz2.colorSet.Add(Color.Red);
            bunifuDataViz2.Render(cnv);

        }
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            LoadChart1();
            LoadChart2();
        }

     
    }
}
