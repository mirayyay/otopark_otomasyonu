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
    public partial class motor_kayit : Form
    {
        public motor_kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sqlbaglantisi bgl = new sqlbaglantisi();

            SqlCommand komut = new SqlCommand("insert into motor_bilgileri (motor_plaka,motor_markasi,motor_model,motor_rengi) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", textBox3.Text);
            komut.Parameters.AddWithValue("@p4", textBox4.Text);
            komut.ExecuteReader();


            SqlCommand komut1 = new SqlCommand("insert into motor_vites_tip (motor_plaka,vites_tip) values (@p11,@p12)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p11", textBox1.Text);
            if (radioButton1.Checked == true)
            {
                komut1.Parameters.AddWithValue("@p12", "Otomatik");
            }
            else if (radioButton2.Checked == true)
            {
                komut1.Parameters.AddWithValue("@p12", "Manuel");
            }
            else
            {
                komut1.Parameters.AddWithValue("@p12", "Seçim Yapılmadı");
            }
            komut1.ExecuteReader();

            SqlCommand komut2 = new SqlCommand("insert into motor_yakit_turu (motor_plaka,motor_yakit_turu) values (@p11,@p21)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p11", textBox1.Text);
            if (radioButton3.Checked == true)
            {
                komut2.Parameters.AddWithValue("@p21", "Dizel");
            }
            else if (radioButton4.Checked == true)
            {
                komut2.Parameters.AddWithValue("@p21", "LPG");
            }
            else if (radioButton6.Checked == true)
            {
                komut2.Parameters.AddWithValue("@p21", "Benzin");
            }
            else
            {
                komut2.Parameters.AddWithValue("@p21", "Seçim Yapılmadı");
            }
            komut2.ExecuteReader();

            SqlCommand komut3 = new SqlCommand("insert into tip (arac_plaka,arac_tipi) values (@p41,@p40)", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p41", textBox1.Text);
            komut3.Parameters.AddWithValue("@p40", "Motor");
            komut3.ExecuteReader();

            bgl.baglanti().Close();
            MessageBox.Show("Araç Girişi Sağlanmıştır.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aracgirisi arcsec = new aracgirisi();
            arcsec.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
