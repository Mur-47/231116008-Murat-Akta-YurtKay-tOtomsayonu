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
    public partial class FrmOgrDuzenle: Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        public string id, ad, soyad, tc, telefon, dogum, bolum, mail, oda, veliadsoyad, velitelefon, veliadres;

        private void button1_Click(object sender, EventArgs e)
        {
            // Öğrenci Silme
            SqlCommand komut = new SqlCommand("delete from TBL_Ogrenciler where Ogrid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtOgrid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Başarılı✔️");

            // oda boşaltma
            SqlCommand komut2 = new SqlCommand("update TBL_Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda", bgl.baglanti());
            komut2.Parameters.AddWithValue("@oda", cmbOdaNo.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update TBL_Ogrenciler set OgrAd= @p2,OgrSoyad=@p3, OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where Ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtOgrid.Text);
                komut.Parameters.AddWithValue("@p2", txtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", mskTc.Text);
                komut.Parameters.AddWithValue("@p5", mskTelefon.Text);
                komut.Parameters.AddWithValue("@p6", mskDogumTarihi.Text);
                komut.Parameters.AddWithValue("@p7", cmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", txtMail.Text);
                komut.Parameters.AddWithValue("@p9", cmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", txtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", mskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", rtxtAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Başarılı✔️");
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA!: " + ex.Message);
            }
        }

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select BolumAd from TBL_Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbBolum.Items.Add(oku[0].ToString());
            }
            SqlCommand komut2 = new SqlCommand("select OdaNo from TBL_Odalar where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());

            }
            bgl.baglanti().Close();
            bgl.baglanti().Close();
            txtOgrid.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            mskTc.Text = tc;
            mskTelefon.Text = telefon;
            mskDogumTarihi.Text = dogum;
            cmbBolum.Text = bolum;
            txtMail.Text = mail;
            cmbOdaNo.Text = oda;
            txtVeliAdSoyad.Text = veliadsoyad;
            mskVeliTelefon.Text = velitelefon;
            rtxtAdres.Text = veliadres;

        }
    }
}
