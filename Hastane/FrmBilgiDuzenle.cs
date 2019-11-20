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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = tc;
            SqlCommand komut = new SqlCommand("select * from Tbl_hastaılar where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtxSoyad.Text = dr[2].ToString();
                
                mskTelefon.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                CmbCins.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtxSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbCins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDuzenıe_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_hastaılar set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3,  HastaSifre=@p4, HastaCins=@p5 where HastaTC="+mskTC.Text, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text) ;
            komut.Parameters.AddWithValue("@p2", TxtxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", CmbCins.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("guncellendi");


        }
    }
}
