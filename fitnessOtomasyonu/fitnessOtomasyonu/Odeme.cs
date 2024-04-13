using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessOtomasyonu
{
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdemeBox.Text = "";
            AdSoyadTextBox.Text = "";
            TutarTextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa=new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
