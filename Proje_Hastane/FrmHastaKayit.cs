using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        private Sqlbaglantisi baglanti = new Sqlbaglantisi();
        private void btnKayıtYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut =
                new SqlCommand(
                    "insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@h1,@h2,@h3,@h4,@h5,@h6)",baglanti.baglanti());
            komut.Parameters.AddWithValue("@h1", txbAd.Text);
            komut.Parameters.AddWithValue("@h2", txbSoyad.Text);
            komut.Parameters.AddWithValue("@h3", mskTc.Text);
            komut.Parameters.AddWithValue("@h4", mskTelefon.Text);
            komut.Parameters.AddWithValue("@h5", txbSifre.Text);
            komut.Parameters.AddWithValue("@h6", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            baglanti.baglanti().Close();
            MessageBox.Show("Kaydınız Oluşturuldu Şifreniz :" + txbSifre.Text, "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
    }
}
