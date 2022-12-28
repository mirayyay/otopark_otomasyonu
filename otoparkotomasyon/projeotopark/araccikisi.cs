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
    public partial class araccikisi : Form
        
    {
        sqlbaglantisi bgl = new sqlbaglantisi();

        public araccikisi()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

             SqlCommand komut4 = new SqlCommand("Update park_yeri set plaka=@p100 where plaka=@p101", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p101", textBox1.Text);
            komut4.Parameters.AddWithValue("@p100", "");
            komut4.ExecuteReader();

            MessageBox.Show("Aracınzın Çıkışı Yapıldı");
            Form1 ckssec = new Form1();
            ckssec.Show();
            this.Hide();
        }

       
    }
}
