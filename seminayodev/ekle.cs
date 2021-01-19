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
    public partial class ekle : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0; Data Source="+Application.StartupPath+"\\database3.accdb");
        public ekle()
        {
            InitializeComponent();
        }

        private void ekle_Load(object sender, EventArgs e)
        {

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            string gectikaldi = "";
            int sonuc = 0;
            int vize2 = 0, final2 = 0;
            vize2 = Convert.ToInt32(textBox3.Text);
            final2 = Convert.ToInt32(textBox4.Text);
            sonuc = vize2 + final2;
            sonuc = sonuc / 2;
            if (sonuc < 60)
            {
                gectikaldi = "Kaldı";
            }
            else if (sonuc >= 60)
            {
                gectikaldi = "Geçti";
            }
            baglanti.Open();
           
            string ekle = "insert into tabl (tc,isim,vize,final,gectikaldi,notu) values (@tc,@isim,@vize,@final,@gectikaldi,@notu)";
            OleDbCommand komut = new OleDbCommand(ekle, baglanti);
            komut.Parameters.AddWithValue("@tc", textBox1.Text);
            komut.Parameters.AddWithValue("@isim", textBox2.Text);
            komut.Parameters.AddWithValue("@vize", textBox3.Text);
            komut.Parameters.AddWithValue("@final", textBox4.Text);
            komut.Parameters.AddWithValue("@gectikaldi", gectikaldi);
            komut.Parameters.AddWithValue("@notu", sonuc);
            komut.ExecuteNonQuery();
            MessageBox.Show("kayıt başarıyla tamamlandı"+vize2);
            baglanti.Close();
        }
    }
}
