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
    public partial class FrmGeliristatistik: Form
    {
        public FrmGeliristatistik()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmGeliristatistik_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar
            SqlCommand komut = new SqlCommand("select sum(OdemeMiktar) from TBL_kasa", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblpara.Text = oku[0].ToString() + " ₺";
            }
            bgl.baglanti().Close();

            //tekrarsız olarak ayları listeleme
            SqlCommand komut2 = new SqlCommand("select distinct(OdemeAy) from TBL_kasa", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbAy.Items.Add(oku2[0].ToString());

            }
            bgl.baglanti().Close();
            //aylık kazanç manuel
            //this.chart1.Series["Aylık"].Points.AddXY("Ocak", 1500);
            //this.chart1.Series["Aylık"].Points.AddXY("Şubat", 2000);
            //this.chart1.Series["Aylık"].Points.AddXY("Mart", 3000);
            //this.chart1.Series["Aylık"].Points.AddXY("Nisan", 4000);
            //this.chart1.Series["Aylık"].Points.AddXY("Mayıs", 5000);
            //this.chart1.Series["Aylık"].Points.AddXY("Haziran", 6000);
            //this.chart1.Series["Aylık"].Points.AddXY("Temmuz", 7000);
            //this.chart1.Series["Aylık"].Points.AddXY("Ağustos", 8000);
            //this.chart1.Series["Aylık"].Points.AddXY("Eylül", 9000);
            //this.chart1.Series["Aylık"].Points.AddXY("Ekim", 10000);
            //this.chart1.Series["Aylık"].Points.AddXY("Kasım", 11000);
            //this.chart1.Series["Aylık"].Points.AddXY("Aralık", 12000);

            // grafik verilerini çekme
            SqlCommand komut3 = new SqlCommand("select OdemeAy,sum(OdemeMiktar) from TBL_kasa group by OdemeAy", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }
            bgl.baglanti().Close();


        }

        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum(OdemeMiktar) from TBL_kasa where OdemeAy=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbAy.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblaylik.Text = oku[0].ToString() + " ₺";
            }
            bgl.baglanti().Close();
        }

        private void lblpara_Click(object sender, EventArgs e)
        {

        }
    }
}
