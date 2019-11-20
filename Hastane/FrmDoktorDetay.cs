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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        public string tc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;
            SqlCommand komut = new SqlCommand("select DoktorAd, DoktorSoyad from TblDoktor where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter dr1 = new SqlDataAdapter("select * from Tbl_randevuar where RandevuDoktor='"+LblAdSoyad.Text+"'",bgl.baglanti() );
            dr1.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            frmDoctorDuzenıe frm = new frmDoctorDuzenıe();
            frm.tc = lblTC.Text;
            frm.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyuru frm = new FrmDuyuru();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
           rctİcerik.Text= dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }
    }
}
