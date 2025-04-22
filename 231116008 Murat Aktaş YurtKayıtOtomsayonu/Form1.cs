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

namespace _231116008_Murat_Aktaş_YurtKayıtOtomsayonu
{
    public partial class FrmYoneticiİslemleri: Form
    {
        public FrmYoneticiİslemleri()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitOtomasyonuDataSet14.TBL_Admin' table. You can move, or remove it, as needed.
            this.tBL_AdminTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet14.TBL_Admin);

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_Admin (YoneticiAd,YoneticiSifre) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtyoneticiad.Text);
            komut.Parameters.AddWithValue("@p2", txtyoneticiparola.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Eklendi");
            this.tBL_AdminTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet14.TBL_Admin);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_Admin where Yoneticiid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtyoneticiid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Silindi");
            this.tBL_AdminTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet14.TBL_Admin);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_Admin set YoneticiAd=@p1,YoneticiSifre=@p2 where Yoneticiid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtyoneticiad.Text);
            komut.Parameters.AddWithValue("@p2", txtyoneticiparola.Text);
            komut.Parameters.AddWithValue("@p3", txtyoneticiid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Güncellendi");
            this.tBL_AdminTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet14.TBL_Admin);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, ad, sifre;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtyoneticiid.Text = id;
            txtyoneticiad.Text = ad;
            txtyoneticiparola.Text = sifre;




        }
    }
}
