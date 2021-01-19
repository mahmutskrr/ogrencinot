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
    public partial class sil : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0; Data Source=" + Application.StartupPath + "\\database3.accdb");
        public sil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("detece from tabl where tc='"+textBox1.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("öğrenci başarıyla silindi");
            baglanti.Close();
        }
    }
}
