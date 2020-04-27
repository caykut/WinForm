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
    public partial class Form5 : Form
    {
        public Form5()
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

            string sorgu = "insert into iş_istasyonu_tanımıı (İş_İstasyonu_Kodu,İstasyon_Açıklama,Hammadde_Ambarı,istasyon_maliyeti) values (@İş_İstasyonu_Kodu,@İstasyon_Açıklama,@Hammadde_Ambarı,@istasyon_maliyeti)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@İş_İstasyonu_Kodu", textBox1.Text);
            komut.Parameters.AddWithValue("@İstasyon_Açıklama", textBox2.Text);
            komut.Parameters.AddWithValue("@Hammadde_Ambarı", textBox3.Text);
            komut.Parameters.AddWithValue("@İstasyon_Maliyeti", textBox4.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            veriler("SELECT * from iş_istasyonu_tanımıı");
            MessageBox.Show("kayıt eklendi");
            baglanti.Close();
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            veriler("SELECT * from iş_istasyonu_tanımıı");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "DELETE from iş_istasyonu_tanımıı where İş_istasyonu_kodu=@İş_istasyonu_kodu";

            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@iş_istasyonu_kodu", textBox1.Text);
            komut.ExecuteNonQuery();
            veriler("SELECT * from iş_istasyonu_tanımıı");
            MessageBox.Show("kayıt silindi");
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string İş_İstasyonu_Kodu = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string İstasyon_Açıklama = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string Hammadde_Ambarı = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string istasyon_maliyeti = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            textBox1.Text = İş_İstasyonu_Kodu;
            textBox2.Text = İstasyon_Açıklama;
            textBox3.Text = Hammadde_Ambarı;
            textBox4.Text = istasyon_maliyeti;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "update iş_istasyonu_tanımıı set İş_İstasyonu_Kodu=@İş_İstasyonu_Kodu,İstasyon_Açıklama=@İstasyon_Açıklama,Hammadde_Ambarı=@Hammadde_Ambarı,istasyon_maliyeti=@istasyon_maliyeti where İş_İstasyonu_Kodu=@İş_İstasyonu_Kodu";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@İş_İstasyonu_Kodu", textBox1.Text);
            komut.Parameters.AddWithValue("@İstasyon_Açıklama", textBox2.Text);
            komut.Parameters.AddWithValue("@Hammadde_Ambarı", textBox3.Text);
            komut.Parameters.AddWithValue("@istasyon_maliyeti", textBox4.Text);
           ;



            komut.ExecuteNonQuery();
            veriler("SELECT * from iş_istasyonu_tanımıı");
            MessageBox.Show("kayıt güncellendi");
            baglanti.Close();
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();
        }
    }
}
