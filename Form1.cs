﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text == "cevat" && textBox2.Text == "123")
                {
                    MessageBox.Show("Giriş Başarılı");
                }
                else

                {
                    MessageBox.Show("Hatalı Giriş");
                }
                Form2 form2sec = new Form2();
                        form2sec.Show();
                        this.Hide();
        }
    }
}
