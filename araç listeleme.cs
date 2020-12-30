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
    public partial class araç_listeleme : Form
    {
        Araç_Kiralam Araç_Kiralama = new Araç_Kiralam();
        public araç_listeleme()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtplaka.Text = satır.Cells["plaka"].Value.ToString();
            markacombo.Text = satır.Cells["marka"].Value.ToString();
            sericombo.Text = satır.Cells["seri"].Value.ToString();
            txtmodel.Text = satır.Cells["yil"].Value.ToString();
            txtrenk.Text = satır.Cells["renk"].Value.ToString();
            txtkm.Text = satır.Cells["km"].Value.ToString();
            yakıtcombo.Text = satır.Cells["yakit"].Value.ToString();
            txtkira.Text = satır.Cells["kiraucreti"].Value.ToString();
            pictureBox2.ImageLocation = satır.Cells["resim"].Value.ToString();
        }

        private void araç_listeleme_Load(object sender, EventArgs e)
        {
            YenileAraçlarListesi();
            
                araçlarcombo.SelectedIndex = 0;
        
        }

        private void YenileAraçlarListesi()
        {
            string cümle = "select *from araç";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource=Araç_Kiralama.listele(adtr2, cümle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "update araç set marka=@marka,seri=@seri,yil=@yil,renk=@renk,km=@km,yakit=@yakit,kiraucreti=@kiraucreti,resim=@resim,tarih=@tarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", txtplaka.Text);
            komut2.Parameters.AddWithValue("@marka", markacombo.Text);
            komut2.Parameters.AddWithValue("@seri", sericombo.Text);
            komut2.Parameters.AddWithValue("@yil", txtmodel.Text);
            komut2.Parameters.AddWithValue("@renk", txtrenk.Text);
            komut2.Parameters.AddWithValue("@km", txtkm.Text);
            komut2.Parameters.AddWithValue("@yakit", yakıtcombo.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtkira.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox2.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            Araç_Kiralama.ekle_sil_güncelle(komut2, cümle);
            sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox2.ImageLocation = "";
            YenileAraçlarListesi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from araç where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            Araç_Kiralama.ekle_sil_güncelle(komut2, cümle);
            YenileAraçlarListesi();
            pictureBox2.ImageLocation = "";
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";


        }

        private void markacombo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void araçlarcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (araçlarcombo.SelectedIndex == 0)
                {
                    YenileAraçlarListesi();
                }
                if (araçlarcombo.SelectedIndex == 1)
                {
                    string cümle = "select *from araç where durumu='Boş'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = Araç_Kiralama.listele(adtr2, cümle);
                }
                if (araçlarcombo.SelectedIndex == 2)
                {
                    string cümle = "select *from araç where durumu='dolu'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = Araç_Kiralama.listele(adtr2, cümle);
                }

            }
            catch
            {
                ;
            }
        }
    }
}
