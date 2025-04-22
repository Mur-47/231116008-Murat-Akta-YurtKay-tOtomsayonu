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
using System.Runtime.InteropServices;
namespace _231116008_Murat_Aktaş_YurtKayıtOtomsayonu
{
    public partial class FrmOdemeler: Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitOtomasyonuDataSet3.TBL_Borclar' table. You can move, or remove it, as needed.
            this.tBL_BorclarTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet3.TBL_Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtOgrid.Text = id; 
            txtAdi.Text = ad;
            txtSoyadi.Text = soyad;
            txtKalan.Text = kalan;
        }

        private void BtnOdeme_Click(object sender, EventArgs e)
        {
            //eksilen tutarı hesaplama
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(textBox1.Text);
            kalan = Convert.ToInt16(txtKalan.Text);
            yeniborc = kalan - odenen;
            txtKalan.Text = yeniborc.ToString();

            // Yeni borç durumunu veritabanına kaydetme
            SqlCommand komut = new SqlCommand("update TBL_Borclar set OgrKalanBorc=@p1 where Ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtOgrid.Text);
            komut.Parameters.AddWithValue("@p1", txtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ödeme Alındı✔️");
            this.tBL_BorclarTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet3.TBL_Borclar);


            //Kasa tablosuna ekleme yapma
            SqlCommand komut2 = new SqlCommand("insert into TBL_Kasa (OdemeAy, OdemeMiktar) values (@k1, @k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", comboBox1.Text);
            komut2.Parameters.AddWithValue("@k2", textBox1.Text);
            komut2.ExecuteNonQuery();
            textBox1.Text = "";
            bgl.baglanti().Close();


        }
    }
}
