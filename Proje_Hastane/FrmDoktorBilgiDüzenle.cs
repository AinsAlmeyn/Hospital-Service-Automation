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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }

        private Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string tcNo;
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text = tcNo;
            SqlCommand komut = new SqlCommand("Select * from tbl_doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txbAd.Text = dr[1].ToString();
                txbSoyad.Text = dr[2].ToString();
                cmbBranş.Text=dr[3].ToString();
                txbSifre.Text=dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnBilgileriGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut =
                new SqlCommand(
                    "update tbl_doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5",
                    bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txbAd.Text);
            komut.Parameters.AddWithValue("@p2", txbSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBranş.Text);
            komut.Parameters.AddWithValue("@p4", txbSifre.Text);
            komut.Parameters.AddWithValue("@p5", mskTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
