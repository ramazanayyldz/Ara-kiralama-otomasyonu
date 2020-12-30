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

namespace Araç_kiralama_otomasyonu
{
    public partial class Araç_ : Form
    {
        Araç_Kiralam araç_Kiralama = new Araç_Kiralam();
        public Araç_()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sericombo.Items.Clear();
                if (markacombo.SelectedIndex == 0)
                {
                    sericombo.Items.Add("Astra");
                    sericombo.Items.Add("Vectra");
                    sericombo.Items.Add("Corsa");
                }
                else if (markacombo.SelectedIndex == 1)
                {
                    sericombo.Items.Add("Megane");
                    sericombo.Items.Add("Clio");
                }
                else if (markacombo.SelectedIndex == 2)
                {
                    sericombo.Items.Add("Egea");
                    sericombo.Items.Add("Linea");
                }
            }
            catch
            {
                ;
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into araç (plaka,marka,seri,yil,renk,km,yakit,kiraucreti,resim,tarih,durumu)values(@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@kiraucreti,@resim,@tarih,@durumu)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", txtplaka.Text);
            komut2.Parameters.AddWithValue("@marka", markacombo.Text);
            komut2.Parameters.AddWithValue("@seri", sericombo.Text);
            komut2.Parameters.AddWithValue("@yil", txtmodel.Text);
            komut2.Parameters.AddWithValue("@renk", txtrenk.Text);
            komut2.Parameters.AddWithValue("@km", txtkm.Text);
            komut2.Parameters.AddWithValue("@yakit", yakıtcombo.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtkira.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@durumu", "BOŞ");
            araç_Kiralama.ekle_sil_güncelle(komut2,cümle);
            sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
        }
    }
}
