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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Sqlbaglantisi baglanti = new Sqlbaglantisi();

        public string tc;
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            // ad soyad 
            lblTc.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1",baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            baglanti.baglanti().Close();

            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da =
                new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc, baglanti.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            //Branşlar
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", baglanti.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranş.Items.Add(dr2[0]);

            }
            baglanti.baglanti().Close();
        }

        private void cmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1",
                baglanti.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBranş.Text);
            SqlDataReader dr = komut3.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            baglanti.baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da =
                new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + cmbBranş.Text + "'" + "and RandevuDoktor='" + cmbDoktor.Text +"' and RandevuDurum=0",
                    baglanti.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void lnkBilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.tcno = lblTc.Text;
            fr.Show();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut =
                new SqlCommand(
                    "update tbl_randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3",
                    baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            komut.Parameters.AddWithValue("@p2", rchŞikayet.Text);
            komut.Parameters.AddWithValue("@p3", txbİd.Text);
            komut.ExecuteNonQuery();
            baglanti.baglanti().Close();
            MessageBox.Show("Randevu Aındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txbİd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
