using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ogrenci_not_kayit
{
    public partial class Frmogrencidetay : Form
    {
        public Frmogrencidetay()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=SerhatDemir\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True;");
        public string numara;
        private void Frmogrencidetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLDERS where OGRNUMARA=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[2].ToString() + "" + dr[3].ToString();
                lblSınav1.Text = dr[4].ToString();
                lblSınav2.Text = dr[5].ToString();
                lblSınav3.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                lblDurum.Text = dr[8].ToString();
            }
            baglanti.Close();
        }

    }
}
