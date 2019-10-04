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
            Bunifu.Framework.Lib.Elipse.Apply(card1, 5);
            Bunifu.Framework.Lib.Elipse.Apply(card2, 5);
            Bunifu.Framework.Lib.Elipse.Apply(card3, 5);
            Bunifu.Framework.Lib.Elipse.Apply(card4, 5);



        }

       
        private void LoadChart1()
        {
            var cnv = new Bunifu.DataViz.WinForms.Canvas();
            var dataPoint = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_area);

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
            bunifuDataViz1.colorSet.Add(Color.FromArgb(49,197,176));
            bunifuDataViz1.Render(cnv);

        }

       
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            LoadChart1();
        }

        private void LoadData_Tick(object sender, EventArgs e)
        {
            loadData.Stop();
            LoadChart1();
        }

    }
}
