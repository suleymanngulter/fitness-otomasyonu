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

namespace fitnessOtomasyonu
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suleymangulter\Documents\FitnessSalonuDb.mdf;Integrated Security=True;Connect Timeout=30");


        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdSoyadTextBox.Text == "" ||
                TelefonTextBox.Text == "" ||
                YasTextBox.Text == "" ||
                CinsiyetcomboBox.Text == "")
            {
                MessageBox.Show("eksik bilgi girildi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into Uye values(" +
                        "'" + AdSoyadTextBox.Text + "'," +
                        "'" + TelefonTextBox.Text+"'," +
                        "'" + YasTextBox.Text+ "'," +
                        "'" + CinsiyetcomboBox.SelectedItem.ToString() +"')";
                    SqlCommand komut = new SqlCommand(query,baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("üye başarıyla eklendi");
                    baglanti.Close();

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
