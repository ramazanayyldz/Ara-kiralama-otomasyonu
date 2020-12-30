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
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "12345")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileriniz hatalı!!");
            }
        }
    }
}
