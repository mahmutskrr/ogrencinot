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
    public partial class listele : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0; Data Source=" + Application.StartupPath + "\\database3.accdb");
        DataTable tablo = new DataTable();

        public listele()
        {
            InitializeComponent();
        }

        private void listele_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adaptr = new OleDbDataAdapter("select * from tabl", baglanti);
            adaptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }
    }
}
