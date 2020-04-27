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
    public partial class Form3 : Form
    {


        public Form3()
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




            string sorgu = "insert into Calısan_tanımı (TC_Kimlik_NO,Adı_Soyadı,Görevi,Birim_Saati_Maliyeti,Aylık_Maliyeti) values (@TC_Kimlik_NO,@Adı_Soyadı,@Görevi,@Birim_Saati_Maliyeti,@Aylık_Maliyeti)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TC_Kimlik_No", textBox1.Text);
            komut.Parameters.AddWithValue("@Adı_Soyadı", textBox2.Text);
            komut.Parameters.AddWithValue("@Görevi", textBox3.Text);
            komut.Parameters.AddWithValue("@Birim_Saati_Maliyeti", textBox4.Text);
            komut.Parameters.AddWithValue("@Aylık_Maliyeti", textBox5.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            veriler("SELECT * from Calısan_tanımı");
            MessageBox.Show("kayıt eklendi");
            baglanti.Close();
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();










        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            veriler( "SELECT * from Calısan_tanımı");

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "DELETE from Calısan_tanımı where Adı_soyadı=@Adı_soyadı";

            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@Adı_soyadı", textBox2.Text);
            komut.ExecuteNonQuery();
            veriler("SELECT * from Calısan_tanımı");
            MessageBox.Show("kayıt silindi");
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string TC_Kimlik_No = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string Adı_Soyadı = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string Görevi = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string Birim_Saati_Maliyeti = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string Aylık_Maliyeti = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            textBox1.Text = TC_Kimlik_No;
            textBox2.Text = Adı_Soyadı;
            textBox3.Text = Görevi;
            textBox4.Text = Birim_Saati_Maliyeti;
            textBox5.Text = Aylık_Maliyeti;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "update  Calısan_tanımı set TC_Kimlik_NO=@TC_Kimlik_NO,Adı_Soyadı=@Adı_Soyadı,Görevi=@Görevi,Birim_Saati_Maliyeti=@Birim_Saati_Maliyeti,Aylık_Maliyeti=@Aylık_Maliyeti where TC_Kimlik_NO=@TC_Kimlik_NO";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@TC_Kimlik_No", textBox1.Text);
            komut.Parameters.AddWithValue("@Adı_Soyadı", textBox2.Text);
            komut.Parameters.AddWithValue("@Görevi", textBox3.Text);
            komut.Parameters.AddWithValue("@Birim_Saati_Maliyeti", textBox4.Text);
            komut.Parameters.AddWithValue("@Aylık_Maliyeti", textBox5.Text);



            komut.ExecuteNonQuery();
            veriler("SELECT * from Calısan_tanımı");
            MessageBox.Show("kayıt güncellendi");
            baglanti.Close();
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
            this.Hide();
        }
    }

}


