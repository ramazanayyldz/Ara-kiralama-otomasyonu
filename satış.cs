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
    public partial class satışsayfası : Form
    {
        public satışsayfası()
        {
            InitializeComponent();
        }
        Araç_Kiralam arac = new Araç_Kiralam();

        private void satışsayfası_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select *from satış";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu2);
            arac.satışhesapla(label1);
        }
    }
}
