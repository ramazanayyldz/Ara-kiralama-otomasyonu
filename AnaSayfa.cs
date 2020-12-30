using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_kiralama_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MüşteriEkle ekle = new MüşteriEkle();
            ekle.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            KullaniciGiris giris = new KullaniciGiris();
            if (giris.ShowDialog()==DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MüşteriListele listele = new MüşteriListele();
            listele.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            araç_listeleme listleme = new araç_listeleme();
            listleme.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Araç_ kayıt = new Araç_();
            kayıt.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sözleşme sozlesme = new Sözleşme();
            sozlesme.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            satışsayfası satış = new satışsayfası();
            satış.ShowDialog();
        }
    }
}
