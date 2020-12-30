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
    public partial class MüşteriEkle : Form
    {
        Araç_Kiralam Araç_Kiralama = new Araç_Kiralam();
        public MüşteriEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "insert into tblMusteriBilgileri (tc,ad,soyad,telefon,adres,mail) values(@tc,@ad,@soyad,@telefon,@adres,@mail)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@ad", txtAd.Text);
            komut2.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@mail", txtMail.Text);
            Araç_Kiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void MüşteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
