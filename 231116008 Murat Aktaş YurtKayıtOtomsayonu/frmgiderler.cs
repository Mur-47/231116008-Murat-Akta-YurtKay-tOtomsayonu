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
    public partial class frmgiderler: Form
    {
        public frmgiderler()
        {
            InitializeComponent();

        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void btnGiderkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into TBL_Giderler (Elektrik, Su, Dogalgaz, İnternet, Gıda, Personel, Diger) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtelektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtsu.Text);
                komut.Parameters.AddWithValue("@p3", txtdogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtinternet.Text);
                komut.Parameters.AddWithValue("@p5", txtgida.Text);
                komut.Parameters.AddWithValue("@p6", txtpersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtdiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Giderler Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show( "Hata", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }
    }
}
