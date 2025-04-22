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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitOtomasyonuDataSet1.TBL_Bolumler' table. You can move, or remove it, as needed.
            this.tBL_BolumlerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet1.TBL_Bolumler);

        }

        private void pcBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut1 = new SqlCommand("insert into TBL_Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni Bölüm Kaydı Başarılı✔️");
                this.tBL_BolumlerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet1.TBL_Bolumler);

            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu!! Lütfen Tekrar Deneyiniz.");
            }
        }

        private void pcBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("delete from TBL_Bolumler Where  Bolumid= @p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtBolumid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Silme İşlemi Başarılı✔️");
                this.tBL_BolumlerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet1.TBL_Bolumler);
                txtBolumAd.Text = "";
                txtBolumid.Text = "";


            }
            catch (Exception)
            {

                MessageBox.Show("Hata!! Kayıt Silinemedi.");
            }
            

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, Bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id=dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            
            txtBolumid.Text = id;
            txtBolumAd.Text = Bolumad;

            
        }

        private void pcBolumDüzenle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("update  TBL_Bolumler set  BolumAd= @p1 where Bolumid=@p2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p2", txtBolumid.Text);
                komut2.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncelleme İşlemi Başarılı✔️");
                this.tBL_BolumlerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet1.TBL_Bolumler);
                txtBolumAd.Text = "";
                txtBolumid.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!! Güncelleme İşlemi Başarısız."); 
            }
        }
    }
}
