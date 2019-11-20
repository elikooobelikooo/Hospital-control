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
    public partial class frmDoctorDuzenıe : Form
    {
        public frmDoctorDuzenıe()
        {
            InitializeComponent();
        }
        public string tcno;
        public string tc;
        sqlbaglanti bgl = new sqlbaglanti();

        private void frmDoctorDuzenıe_Load(object sender, EventArgs e)
        {


            mskTC.Text = tc;

            SqlCommand komut = new SqlCommand("select * from TblDoktor where DoktorTc="+mskTC.Text, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtxSoyad.Text = dr[2].ToString();
                CmbBranch.Text = dr[3].ToString();
                txtSifre.Text = dr[5].ToString();


            }
            bgl.baglanti().Close();


        }

        private void BtnDuzenıe_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TblDoktor set DoktorAd=@p1, DoktorSoyad=@p2, DoktorBrains=@p3, DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti()) ;
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbBranch.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("oldu");




        }
    }
}
