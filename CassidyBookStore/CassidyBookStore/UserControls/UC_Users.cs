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
    public partial class UC_Users : UserControl
    {
        public UC_Users()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(btn_Add, 10);
            Bunifu.Framework.Lib.Elipse.Apply(btn_Edit, 10);
            Bunifu.Framework.Lib.Elipse.Apply(btn_Delete, 10);

        }


        private void Btn_Add_Click(object sender, EventArgs e)
        {
            using (Form_AddUser form = new Form_AddUser())
            {
                form.ShowDialog();
            }
        }
    }
}
