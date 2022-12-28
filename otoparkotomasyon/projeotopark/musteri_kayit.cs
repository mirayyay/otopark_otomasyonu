using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projeotopark
{
    public partial class musteri_kayit : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public musteri_kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // KULLANİCİ EKLEME
            SqlCommand komut = new SqlCommand("insert into musteri_bilgisi (tc_kimlik,ad,soyad,telefon_no) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", textBox4.Text);
            komut.ExecuteReader();
            bgl.baglanti().Close();

            MessageBox.Show("Kaydınız oluşmuştur. Araç Girişinizi Yapabilirsiniz");

            Form1 frmsec = new Form1();
            frmsec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frmsec = new Form1();
            frmsec.Show();
            this.Hide();
        }

        private void musteri_kayit_Load(object sender, EventArgs e)
        {

        }
    }
}
