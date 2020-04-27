using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace üretim_yönetim_sistemi
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("server=LAPTOP-C5AKAGH5; Initial Catalog=Ödev;Integrated Security=SSPI");
        public void veriler(string verilerr)
        {
            SqlDataAdapter da = new SqlDataAdapter(verilerr, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into operasyon_tanımı_formu (Operasyon_Kodu,Toplam_Operasyon_Süresi,İşlem_Süresi,Bekleme_Süresi,Taşıma_Süresi,Operasyon_Açıklaması) values (@Operasyon_Kodu,@Toplam_Operasyon_Süresi,@İşlem_Süresi,@Bekleme_Süresi,@Taşıma_Süresi,@Operasyon_Açıklaması)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Operasyon_Kodu", textBox1.Text);
            komut.Parameters.AddWithValue("@Toplam_Operasyon_Süresi", textBox2.Text);
            komut.Parameters.AddWithValue("@İşlem_Süresi", textBox3.Text);
            komut.Parameters.AddWithValue("@Bekleme_Süresi", textBox4.Text);
            komut.Parameters.AddWithValue("@Taşıma_Süresi", textBox5.Text);
            komut.Parameters.AddWithValue("@Operasyon_Açıklaması", textBox6.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            veriler("SELECT * from operasyon_tanımı_formu");
            MessageBox.Show("kayıt eklendi");
            baglanti.Close();
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            veriler("SELECT * from operasyon_tanımı_formu");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();


        }
    }
}
