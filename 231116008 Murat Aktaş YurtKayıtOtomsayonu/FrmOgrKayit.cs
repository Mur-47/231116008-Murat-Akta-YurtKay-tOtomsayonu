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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();  

        
        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            // Bölüm Listeleme

           
            SqlCommand komut = new SqlCommand("select BolumAd from TBL_Bolumler",bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read()) 
            {
                cmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();


            //Boş oda Listeleme



            SqlCommand komut2 = new SqlCommand("select OdaNo from TBL_Odalar where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());

            }
            bgl.baglanti().Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komutkaydet = new SqlCommand("insert into TBL_Ogrenciler (OgrAd,OgrSoyad,OgrTc,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", txtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", mskTc.Text);
                komutkaydet.Parameters.AddWithValue("@p4", mskTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", mskDogumTarihi.Text);
                komutkaydet.Parameters.AddWithValue("@p6", cmbBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", txtMail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", txtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", mskVeliTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p11", rtxtAdres.Text);

                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show(" Yeni Öğrenci Kaydı Başarılı ✔️");


                // Öğrenci İD Yi Labele Çekme
                SqlCommand komut = new SqlCommand("select Ogrid From TBL_Ogrenciler", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();

                //Öğrenci Borç Alanı Oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into TBL_Borclar  (Ogrid,OgrAd,OgrSoyad,OgrKalanBorc) values (@b1,@b2,@b3,@b4)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", txtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", txtOgrSoyad.Text);
                komutkaydet2.Parameters.AddWithValue("@b4", "3000");
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();

                
                  
            }
            catch (Exception ex )
            {

                MessageBox.Show("Hata: " + ex.Message);
            }

            //Oda Kontenjanı azaltma
            SqlCommand komut3 = new SqlCommand("update TBL_Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            txtOgrAd.Clear();
            txtOgrSoyad.Clear();
            mskTc.Clear();
            mskTelefon.Clear();
            mskDogumTarihi.Clear();
            cmbBolum.Text = "";
            txtMail.Clear();
            cmbOdaNo.Text = "";
            txtVeliAdSoyad.Clear();
            mskVeliTelefon.Clear();
            rtxtAdres.Clear();

        }
    }
}
//Data Source = AKTAS; Initial Catalog = YurtKayitOtomasyonu; Integrated Security = True; Trust Server Certificate=True
