using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessOtomasyonu
{
    public partial class UyeleriGoruntule : Form
    {
        public UyeleriGoruntule()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suleymangulter\Documents\FitnessSalonuDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void uyeler()
        {
            baglanti.Open();
            string query = "select* from Uye";
            SqlDataAdapter sqldadapter = new SqlDataAdapter(query,baglanti);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
            var dset = new DataSet();
            sqldadapter.Fill(dset);
            uyelerDGV.DataSource = dset.Tables[0];
            baglanti.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdSoyadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UyeleriGoruntule_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
