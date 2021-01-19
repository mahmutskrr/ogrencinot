using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace seminayodev
{
    public partial class guncelle : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0; Data Source=" + Application.StartupPath + "\\database3.accdb");
        public guncelle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update tabl set tc='"+textBox1.Text+"', isim='"+textBox2.Text+"', vize='"+textBox3.Text+"', final='"+textBox4.Text+"', gectikaldi='"+textBox5.Text+"', notu='"+textBox6.Text+"' where tc='"+textBox1.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("öğrenci bilgileri başarıyla güncellendi");
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from tabl where tc LIKE'" + textBox1.Text.ToString() + "'", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                textBox2.Text = okuyucu["isim"].ToString();
                textBox3.Text = okuyucu["vize"].ToString();
                textBox4.Text = okuyucu["final"].ToString();
                textBox5.Text = okuyucu["gectikaldi"].ToString();
                textBox6.Text = okuyucu["notu"].ToString();

            }
            baglanti.Close();
        }
    }
}
