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
    public partial class FrmDuyuru : Form
    {
        public FrmDuyuru()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmDuyuru_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("select * from TblDuyurular", bgl.baglanti());
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
