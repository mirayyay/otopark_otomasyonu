using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeotopark
{
    public partial class aracgirisi : Form
    {
        public aracgirisi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            motor_kayit mtrsec = new motor_kayit();
            mtrsec.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            otomobil_kayit otosec = new otomobil_kayit();
            otosec.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            otobus_kayit otobssec = new otobus_kayit();
            otobssec.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            minibus_kayit mnbsec = new minibus_kayit();
            mnbsec.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frmsec = new Form1();
            frmsec.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
