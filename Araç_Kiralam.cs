using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Araç_kiralama_otomasyonu
{
    public class Araç_Kiralam
    {
        public static SqlConnection baglanti = new SqlConnection("Server=.\\SQLEXPRESS;Database=AracKiralama;Trusted_Connection=True");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();


            //test
        }
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        public void satışhesapla(Label lbl)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(tutar) from satış", baglanti);
            lbl.Text = "toplam tutar=" + komut.ExecuteScalar() + "TL";
            baglanti.Close();
        }

        internal void ÜcretHesaplama(System.Windows.Forms.ComboBox kiraŞeklicombo, System.Windows.Forms.TextBox txtKiraÜcreti, string sorgu)
        {

        }
    }
}
