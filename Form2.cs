using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace üretim_yönetim_sistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3sec = new Form3();
                  form3sec.Show();
                  this.Hide();
        }

            private void button2_Click(object sender, EventArgs e)
            {
                Form4 form4sec = new Form4();
                form4sec.Show();
                this.Hide();
            }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5sec = new Form5();
            form5sec.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6sec = new Form6();
            form6sec.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Show();
            this.Hide();
        }
    }
}
