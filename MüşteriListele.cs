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
    public partial class MüşteriListele : Form
    {
        Araç_Kiralam arackiralama = new Araç_Kiralam();
        public MüşteriListele()
        {
            InitializeComponent();
        }

        private void MüşteriListele_Load(object sender, EventArgs e)
        {
            yenileListele();
        }

        private void yenileListele()
        {
            string cümle = "select *from tblMusteriBilgileri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "AD";
            dataGridView1.Columns[2].HeaderText = "SOYAD";
            dataGridView1.Columns[3].HeaderText = "ADRES";
            dataGridView1.Columns[4].HeaderText = "TELEFON";
            dataGridView1.Columns[5].HeaderText = "MAİL";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select *from tblMusteriBilgileri where tc like '%" + textBox1.Text+"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTc.Text = satır.Cells[0].Value.ToString();
            txtAd.Text = satır.Cells[1].Value.ToString();
            txtSoyad.Text = satır.Cells[2].Value.ToString();
            txtTelefon.Text = satır.Cells[3].Value.ToString();
            txtAdres.Text = satır.Cells[4].Value.ToString();
            txtMail.Text = satır.Cells[5].Value.ToString();

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update tblMusteriBilgileri set ad=@ad,soyad=@soyad,telefon=@telefon,adres=@adres,mail=@mail where tc=@tc";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@ad", txtAd.Text);
            komut2.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@mail", txtMail.Text);
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            yenileListele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from tblMusteriBilgileri where tc='" + satır.Cells["tc"].Value.ToString()+ "'";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            //istege baglı====foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            yenileListele();
        }
    }
    
}
