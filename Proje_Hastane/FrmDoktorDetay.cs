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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        private Sqlbaglantisi bgl = new Sqlbaglantisi();
        public string tc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text= tc;

            //ad soyad
            SqlCommand komut = new SqlCommand("select DoktorAd,DoktorSoyad from tbl_doktorlar where DoktorTC=@p1",
                bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text=dr[0] + " " + dr[1];

            }
            bgl.baglanti().Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da =
                new SqlDataAdapter("select * from tbl_randevular where RandevuDoktor='" + lblAdSoyad.Text + "'",
                    bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle frm = new FrmDoktorBilgiDüzenle();
            frm.tcNo = lblTc.Text;
            frm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr =new FrmDuyurular();
            fr.Show();
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchŞikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
