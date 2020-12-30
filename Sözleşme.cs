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
    public partial class Sözleşme : Form
    {
        SqlConnection baglanti = Araç_Kiralam.baglanti;
        public Sözleşme()
        {
            InitializeComponent();
        }
        Araç_Kiralam arac = new Araç_Kiralam();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Sözleşme_Load(object sender, EventArgs e)
        {
            Boş_Araçlar();
            Yenile();
        }

        private void Boş_Araçlar()
        {
            string sorgu2 = "Select *from araç where durumu='Boş'";
            Boş_Araçlar(araçlarcombo, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "select * from sözleşme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu3);
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void araçlarcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select * from araç where plaka like '" + araçlarcombo.SelectedItem + "'";
            CombodanGetir(araçlarcombo,txtMarka,txtSeri,txtyil,txtRenk,sorgu2);
        }

        private void KiraŞeklicombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from araç where plaka like '" + araçlarcombo.SelectedItem + "'";
            arac.ÜcretHesaplama(KiraŞeklicombo, txtKiraÜcreti, sorgu2);
        }

        public void Boş_Araçlar(ComboBox combo, String sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }
            baglanti.Close();
        }
        public void TC_Ara(TextBox tcara, TextBox tc, TextBox adsoyad, TextBox telefon, String sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                adsoyad.Text = read["ad"].ToString() +" " + read["soyad"].ToString();
                telefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }
        public void ücret_Hesapla(TextBox tc, TextBox adsoyad, TextBox telefon, String sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }
        public void Ücret_Hesaplama(ComboBox kiraŞeklicombo, TextBox ucret, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (KiraŞeklicombo.SelectedIndex == 0) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 1).ToString();
                if (KiraŞeklicombo.SelectedIndex == 1) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.80).ToString();
                if (KiraŞeklicombo.SelectedIndex == 2) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.70).ToString();
            }
            baglanti.Close();
        }
            public void CombodanGetir(ComboBox araclar, TextBox marka, TextBox seri, TextBox yil, TextBox renk, String sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                yil.Text = read["yil"].ToString();
                renk.Text = read["renk"].ToString();
            }
            baglanti.Close();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dateDönüş.Text) - DateTime.Parse(dateÇıkış.Text);
            int gun2 = gun.Days;
            txtGün.Text = gun2.ToString();
            txtTutar.Text = (gun2 * int.Parse(txtKiraÜcreti.Text)).ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            dateÇıkış.Text = DateTime.Now.ToShortDateString();
            dateDönüş.Text = DateTime.Now.ToShortDateString();
            KiraŞeklicombo.Text = "";
            txtKiraÜcreti.Text = "";
            txtGün.Text = "";
            txtTutar.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
         string sorgu2 = "insert into sözleşme(tc,adsoyad,telefon,ehliyetno,e_tarih,e_yer,plaka,marka,seri,yil,renk,kiraucreti,gun,tutar,ctarih,dtarih) values(@tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@e_yer,@plaka,@marka,@seri,@yil,@renk,@kiraucreti,@gun,@tutar,@ctarih,@dtarih)";
            SqlCommand komut2 = new SqlCommand(sorgu2);
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtEhliyetNo.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtEhliyetTarih.Text);
            komut2.Parameters.AddWithValue("@e_yer", txtE_verildigiYer.Text);
            komut2.Parameters.AddWithValue("@plaka", araçlarcombo.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtyil.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraÜcreti.Text));
            komut2.Parameters.AddWithValue("@gun", int.Parse(txtGün.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", dateÇıkış.Text);
            komut2.Parameters.AddWithValue("@dtarih", dateDönüş.Text);
            arac.ekle_sil_güncelle(komut2, sorgu2);
            string sorgu3 = "update araç set durumu='DOLU' where plaka='" + araçlarcombo.Text + "'";
            SqlCommand komut3 = new SqlCommand();
            arac.ekle_sil_güncelle(komut3, sorgu3);
            araçlarcombo.Items.Clear();
            Boş_Araçlar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            araçlarcombo.Text = "";
            Temizle();
            MessageBox.Show("sözleşme eklendi");
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            if (txttcara.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select * from tblMusteriBilgileri where tc like '%" + txttcara.Text + "%'";
            TC_Ara(txttcara, txtTC, txtAdSoyad, txtTelefon, sorgu2);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update sözleşme set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,ehliyetno=@ehliyetno,e_tarih=@e_tarih,e_yer=@e_yer,marka=@marka,seri=@seri,yil=@yil,renk=@renk,kiraucreti=@kiraucreti,gun=@gun,tutar=@tutar,ctarih=@ctarih,dtarih=@dtarih where plaka=@plaka"; 
            SqlCommand komut2 = new SqlCommand(sorgu2);
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtEhliyetNo.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtEhliyetTarih.Text);
            komut2.Parameters.AddWithValue("@e_yer", txtE_verildigiYer.Text);
            komut2.Parameters.AddWithValue("@plaka", araçlarcombo.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtyil.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraÜcreti.Text));
            komut2.Parameters.AddWithValue("@gun", int.Parse(txtGün.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", dateÇıkış.Text);
            komut2.Parameters.AddWithValue("@dtarih", dateDönüş.Text);
            arac.ekle_sil_güncelle(komut2, sorgu2);
            araçlarcombo.Items.Clear();
            Boş_Araçlar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            araçlarcombo.Text = "";
            Temizle();
            MessageBox.Show("sözleşme güncellendi");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAraçTeslim_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtekstra.Text) >= 0 || int.Parse(txtekstra.Text) < 0)
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
                int tutar = int.Parse(satır.Cells["tutar"].Value.ToString());
                DateTime çıkış = DateTime.Parse(satır.Cells["ctarih"].Value.ToString());
                TimeSpan gun = bugün - çıkış;
                int _gun = gun.Days;
                int toplamtutar = _gun * ucret;
                string sorgu1 = "delete from sözleşme where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
                SqlCommand komut = new SqlCommand();
                arac.ekle_sil_güncelle(komut, sorgu1);
                string sorgu2 = "update araç set durumu='BOŞ' where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
                SqlCommand komut3 = new SqlCommand();
                arac.ekle_sil_güncelle(komut3, sorgu2);

                string sorgu3 = "insert into satış(tc,adsoyad,plaka,marka,seri,yil,renk,gun,tutar,tarih1,tarih2,fiyat) values(@tc,@adsoyad,@plaka,@marka,@seri,@yil,@renk,@gun,@tutar,@tarih1,@tarih2,@fiyat)";
                SqlCommand komut2 = new SqlCommand(sorgu2);
                komut2.Parameters.AddWithValue("@tc", satır.Cells["tc"].Value.ToString());
                komut2.Parameters.AddWithValue("@adsoyad", satır.Cells["adsoyad"].Value.ToString());
                komut2.Parameters.AddWithValue("@plaka", satır.Cells["plaka"].Value.ToString());
                komut2.Parameters.AddWithValue("@marka", satır.Cells["marka"].Value.ToString());
                komut2.Parameters.AddWithValue("@seri", satır.Cells["seri"].Value.ToString());
                komut2.Parameters.AddWithValue("@yil", satır.Cells["yil"].Value.ToString());
                komut2.Parameters.AddWithValue("@renk", satır.Cells["renk"].Value.ToString());
                komut2.Parameters.AddWithValue("@gun", _gun);
                komut2.Parameters.AddWithValue("@tutar", toplamtutar);
                komut2.Parameters.AddWithValue("@tarih1", satır.Cells["ctarih"].Value.ToString());
                komut2.Parameters.AddWithValue("@tarih2", DateTime.Now.ToShortDateString());
                komut2.Parameters.AddWithValue("@fiyat", ucret);
                arac.ekle_sil_güncelle(komut2, sorgu3);
                MessageBox.Show("araç teslim edildi");
                araçlarcombo.Text = "";
                araçlarcombo.Items.Clear();
                Boş_Araçlar();
                Yenile();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                araçlarcombo.Text = "";
                Temizle();
                txtekstra.Text = "";
            }
            else 
            {
                MessageBox.Show("lütfen seçim yapınız", "uyarı");
            }
        }

        private void dateÇıkış_ValueChanged(object sender, EventArgs e)
        {
            dateDönüş.MinDate = dateÇıkış.Value;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTC.Text = satır.Cells[0].Value.ToString();
            txtAdSoyad.Text = satır.Cells[1].Value.ToString();
            txtTelefon.Text = satır.Cells[2].Value.ToString();
            txtEhliyetNo.Text = satır.Cells[3].Value.ToString();
            txtEhliyetTarih.Text = satır.Cells[4].Value.ToString();
            txtE_verildigiYer.Text = satır.Cells[5].Value.ToString();
            araçlarcombo.Text = satır.Cells[6].Value.ToString();
            txtMarka.Text = satır.Cells[7].Value.ToString();
            txtSeri.Text = satır.Cells[8].Value.ToString();
            txtyil.Text = satır.Cells[9].Value.ToString();
            txtRenk.Text = satır.Cells[10].Value.ToString();
            txtKiraÜcreti.Text = satır.Cells[11].Value.ToString();
            txtGün.Text = satır.Cells[12].Value.ToString();
            txtTutar.Text = satır.Cells[13].Value.ToString();
            dateÇıkış.Text = satır.Cells[14].Value.ToString();
            dateDönüş.Text = satır.Cells[15].Value.ToString();

            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime dönüş = DateTime.Parse(satır.Cells["dtarih"].Value.ToString());
            int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
            TimeSpan gunfarkı = bugün - dönüş;
            int _gunfarkı = gunfarkı.Days;
            int ucretfarkı;
            ucretfarkı = _gunfarkı * ucret;
            txtekstra.Text = ucretfarkı.ToString();
        }
    }
}
