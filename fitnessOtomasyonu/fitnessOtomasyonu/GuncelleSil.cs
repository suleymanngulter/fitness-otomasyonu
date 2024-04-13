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
    public partial class GuncelleSil : Form
    {
        public GuncelleSil()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\suleymangulter\Documents\FitnessSalonuDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void uyeler()
        {
            baglanti.Open();
            string query = "select* from Uye";
            SqlDataAdapter sqldadapter = new SqlDataAdapter(query, baglanti);
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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
        int key = 1;
        private void uyelerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AdSoyadTextBox.Text = uyelerDGV.SelectedRows[0].Cells[1].Value.ToString();
            TelefonNumarasiTextBox.Text = uyelerDGV.SelectedRows[0].Cells[1].Value.ToString();
            YasTextBox.Text = uyelerDGV.SelectedRows[0].Cells[1].Value.ToString();
            CinsiyetCombox.Text = uyelerDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0||AdSoyadTextBox.Text==""||TelefonNumarasiTextBox.Text==""||YasTextBox.Text==""||CinsiyetCombox.Text=="")
            {
                Console.WriteLine("silinecek üyeyi seçiniz...");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update Uye set UnameSurname'"+AdSoyadTextBox.Text+"'UPhoneNumber'"+TelefonNumarasiTextBox.Text+"'Uage'"+YasTextBox.Text+"'Ugender'"+YasTextBox.Text+"' where Uid='"+key+";";
                    SqlCommand command = new SqlCommand(query, baglanti);
                    command.ExecuteNonQuery();
                    MessageBox.Show("uye guncellendi");
                    baglanti.Close();
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void GuncelleSil_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(key==0)
            {
                Console.WriteLine("silinecek üyeyi seçiniz...");
            }
            else
            {
                try
                {baglanti.Open();
                string query = "delete from Uye where Uid=" + key + ";";
                SqlCommand command = new SqlCommand(query,baglanti);
                command.ExecuteNonQuery();
                MessageBox.Show("uye silindi");
                baglanti.Close();
                    uyeler();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
