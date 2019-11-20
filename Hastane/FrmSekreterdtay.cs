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
    public partial class FrmSekreterdtay : Form
    {
        public FrmSekreterdtay()
        {
            InitializeComponent();
        }
        public string tcNumara;
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmSekreterdtay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tcNumara;
            SqlCommand komut = new SqlCommand("select sekreterAdSoyad from TblSekreter where SekreterTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            // brachlar
            DataTable dt = new DataTable();
            SqlDataAdapter dr1 = new SqlDataAdapter("select * from TblBranlar ", bgl.baglanti());
            dr1.Fill(dt);
            dataGridView1.DataSource = dt;
            // doktorar
            DataTable dt2 = new DataTable();
            SqlDataAdapter dr2 = new SqlDataAdapter("select (DoktorAd+' '+DoktorSoyad) as 'Doktorlar', DoktorBrains from TblDoktor ", bgl.baglanti());
            dr2.Fill(dt2);
            dataGridView4.DataSource = dt2;
            // branslar
            SqlCommand komut2 = new SqlCommand("select BranchAd from TblBranlar", bgl.baglanti());
            SqlDataReader dr3 = komut2.ExecuteReader();
            while (dr3.Read())
            {
                cmbbransh.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_randevuar (RandevuTarih, RandevuSaat, RandevuBranch, RandevuDoktor) values(@p1, @p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbbransh.Text);
            komutkaydet.Parameters.AddWithValue("@p4", cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("oldu");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cmbbransh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("select DoktorAd, DoktorSoyad from TblDoktor where DoktorBrains=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbbransh.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbdoktor.Items.Add(dr[0]+" "+dr[1]);
            }
            bgl.baglanti().Close();

        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblDuyurular (DuyuruText) values(@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", RchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Oldu");
        }

        private void BtnDoktrPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPanel fem = new FrmDoktorPanel();
            fem.Show();
        }

        private void BtnBranshPaenl_Click(object sender, EventArgs e)
        {
            FrmBranch frm = new FrmBranch();
            frm.Show();
        }

        private void BtnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm = new FrmRandevuListesi();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyuru fr = new FrmDuyuru();
            fr.Show();
        }
    }
}
