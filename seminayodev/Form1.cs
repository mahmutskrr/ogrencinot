using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminayodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekle ekle = new ekle();
            ekle.Show();
            this.Hide();

        }

        private void ekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listele listele = new listele();
            listele.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sil sil = new sil();
            sil.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guncelle guncelle = new guncelle();
            guncelle.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            grafik grafik = new grafik();
            grafik.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
