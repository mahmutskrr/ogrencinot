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
    public partial class grafik : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0; Data Source=" + Application.StartupPath + "\\database3.accdb");
        public grafik()
        {
            InitializeComponent();
        }

        private void grafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select isim,notu from tabl", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                chart1.Series["notlar"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
            }
            baglanti.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
