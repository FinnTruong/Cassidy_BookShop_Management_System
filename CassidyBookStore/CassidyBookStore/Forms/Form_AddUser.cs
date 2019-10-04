using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CassidyBookStore.Forms
{
    public partial class Form_AddUser : Form
    {
        public Form_AddUser()
        {
            InitializeComponent();
            (new Core.DropShaddow()).ApplyShadows(this);
        }

        private void BunifuCheckBox3_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Finish");
            c3.Checked = c3.Enabled = true;
            label3.ForeColor = Color.Indigo;
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Info");
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Profile");
        }

        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuPages1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (bunifuPages1.SelectedIndex)
            {
                case 1:
                    c1.Checked = c1.Enabled = true;
                    label1.ForeColor = Color.Indigo;
                    break;
                case 2:
                    c2.Checked = c2.Enabled = true;
                    label2.ForeColor = Color.Indigo;
                    break;
            }
        }
    }
}
