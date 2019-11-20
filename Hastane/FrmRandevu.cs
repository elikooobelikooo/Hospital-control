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

namespace Hastane
{
    public partial class FrmRandevu : Form
    {
        public FrmRandevu()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmRandevu_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;
            SqlCommand komut = new SqlCommand("select HastaAd, HastaSoyad from Tbl_hastaılar where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
            /////
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_randevuar where HastaTc="+tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource=dt;
            //branclar
            SqlCommand komut2 = new SqlCommand("select BranchAd from TblBranlar" ,bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranc.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbBranc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select DoktorAd, DoktorSoyad from TblDoktor where DoktorBrains=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBranc.Text) ;
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbDoktor.Items.Add(dr[0]+" "+dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_randevuar where RandevuBranch='"+cmbBranc.Text+"'"+"and RandevuDoktor='"+CmbDoktor.Text+"' and RandevuDurum=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle frm = new FrmBilgiDuzenle();
            frm.tc = lblTC.Text;
            frm.Show();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_randevuar set RandevuDurum=1, HastaTc=@p1, HastaSikayet=@p2 where RandeviİD=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            komut.Parameters.AddWithValue("@p2", rctİcerik.Text);
            komut.Parameters.AddWithValue("@p3",  TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("oldu");



        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
