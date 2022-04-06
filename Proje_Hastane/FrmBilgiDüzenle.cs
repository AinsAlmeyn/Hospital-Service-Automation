using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        private Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string tcno;
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text = tcno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txbAd.Text = dr[1].ToString();
                txbSoyad.Text= dr[2].ToString();
                mskTelefon.Text = dr[4].ToString();
                txbSifre.Text= dr[5].ToString();
                cmbCinsiyet.Text= dr[6].ToString();
            }

            bgl.baglanti().Close();
        }

        private void btnBilgileriGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 =
                new SqlCommand(
                    "update Tbl_Hastalar set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 where HastaTC=@p6",
                    bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txbAd.Text);
            komut2.Parameters.AddWithValue("@p2", txbSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txbSifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", mskTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
