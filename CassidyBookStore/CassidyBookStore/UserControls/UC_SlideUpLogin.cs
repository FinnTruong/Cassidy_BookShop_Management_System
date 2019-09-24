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

namespace CassidyBookStore
{
    public partial class UC_SlideUpLogin : UserControl
    {
        public UC_SlideUpLogin()
        {
            InitializeComponent();
        }

        public delegate void OnFinish();
        public event OnFinish onFinish;

        int panel1_y = 300;
        int waiter = 0;
        int waiter2 = 0;


        //LOG IN
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Finn" && textBox2.Text =="pass123")
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                timer2.Enabled = true;
                label4.Text = "Welcome back " + textBox1.Text;
                label4.Location = new Point((panel3.Size.Width / 2 - (label4.Size.Width / 2)), (panel3.Size.Height / 2 - (label4.Size.Height / 2)));
            }  
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Your username or password is incorrect");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BtnLogin_Click(sender, e);
            }
        }
        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BtnLogin_Click(sender, e);
            }
        }


        //Panel 1 Slide Up Timer
        private void Timer1_Tick(object sender, EventArgs e)
        {
            waiter++;
            if (waiter > 150)
            {
                panel1_y -= 6;
                panel1.Size = new Size(panel1.Size.Width, panel1_y);
                if (panel1_y < 1)
                {
                    panel1.Hide();
                    timer1.Enabled = false;
                }
            }
        }

        //Panel 2 Slide Up Timer

        int panel2_y = 300;
        private void Timer2_Tick(object sender, EventArgs e)
        {
            panel2_y -= 6;
            panel2.Size = new Size(panel2.Size.Width, panel2_y);
            if(panel2_y < 1)
            {
                panel2.Hide();
                timer2.Enabled = false;
                timer3.Enabled = true;
               
            }
        }

        //Load Main Form Timer
        public void Timer3_Tick(object sender, EventArgs e)
        {
            waiter2++;
            if(waiter2>150)
            {
                timer3.Stop();
                onFinish();
            }
        }

        private void UC_SlideUpLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
