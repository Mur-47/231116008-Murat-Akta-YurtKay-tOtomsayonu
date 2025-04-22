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
    public partial class FrmGiderGuncelle: Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        public string  id,elektrik, su, dogalgaz, internet, gida, personel, diger;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtgida_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtinternet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtdogalgaz_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtelektrik_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtpersonel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtdiger_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnGidergıncelle_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand komut = new SqlCommand(" update TBL_Giderler set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,internet=@p4,Gıda=@p5,Personel=@p6,Diger=@p7  where Odemeid=@p8 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtelektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtsu.Text);
                komut.Parameters.AddWithValue("@p3", txtdogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtinternet.Text);
                komut.Parameters.AddWithValue("@p5", txtgida.Text);
                komut.Parameters.AddWithValue("@p6", txtpersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtdiger.Text);
                komut.Parameters.AddWithValue("@p8", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Giderler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            txtdiger.Text = diger;
            txtelektrik.Text = elektrik;
            txtdogalgaz.Text = dogalgaz;
            txtgida.Text = gida;
            txtinternet.Text = internet;
            txtpersonel.Text = personel;
            txtsu.Text = su;
            txtid.Text = id;

        }
    }
}
