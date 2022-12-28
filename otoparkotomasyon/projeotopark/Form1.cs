using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projeotopark
{
    public partial class Form1 : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        int bilet_idsayaci = 0;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteri_kayit mstrsec = new musteri_kayit();
            mstrsec.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aracgirisi arcsec = new aracgirisi();
            arcsec.Show();
            this.Hide();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            araccikisi ckssec = new araccikisi();
            ckssec.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
