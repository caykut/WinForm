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
    public partial class Form4 : Form
    {
        public Form4()
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
            string sorgu = "insert into reçete_tanımı (ana_urun_kodu,Açıklama,miktar,satır_sayısı) values (@ana_urun_kodu,@Açıklama,@miktar,@satır_sayısı)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ana_urun_kodu", textBox1.Text);
            komut.Parameters.AddWithValue("@Açıklama", textBox2.Text);
            komut.Parameters.AddWithValue("@miktar", textBox3.Text);
            komut.Parameters.AddWithValue("@satır_sayısı", textBox4.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            veriler("SELECT * from reçete_tanımı");
            MessageBox.Show("kayıt eklendi");
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            veriler("SELECT * from reçete_tanımı");
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "DELETE from reçete_tanımı where ana_urun_kodu=@ana_urun_kodu";

            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ana_urun_kodu", textBox1.Text);
            komut.ExecuteNonQuery();
            veriler("SELECT * from reçete_tanımı");
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
            string ana_urun_kodu = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string Açıklama = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string miktar = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string satır_sayısı = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            textBox1.Text = ana_urun_kodu;
            textBox2.Text = Açıklama;
            textBox3.Text = miktar;
            textBox4.Text = satır_sayısı;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "update reçete_tanımı set  ana_urun_kodu=@ana_urun_kodu,Açıklama=@Açıklama,miktar=@miktar,satır_sayısı=@satır_sayısı where ana_urun_kodu=@ana_urun_kodu";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ana_urun_kodu", textBox1.Text);
            komut.Parameters.AddWithValue("@Açıklama", textBox2.Text);
            komut.Parameters.AddWithValue("@miktar", textBox3.Text);
            komut.Parameters.AddWithValue("@satır_sayısı", textBox4.Text);
            komut.ExecuteNonQuery();
            veriler("SELECT * from reçete_tanımı");
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
