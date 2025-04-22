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
    public partial class FrmPersonel: Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_Personel (PersonelAdSoyad,PersonelDeparman) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtpersonelad.Text);
            komut.Parameters.AddWithValue("@p2", txtpersoneldepartman.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Eklendi");
            this.tBL_PersonelTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet15.TBL_Personel);
            txtpersoneldepartman.Clear();
            txtpersonelad.Clear();
            txtpersoneldepartman.Clear();

        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitOtomasyonuDataSet15.TBL_Personel' table. You can move, or remove it, as needed.
            this.tBL_PersonelTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet15.TBL_Personel);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_Personel where Personelid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtpersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi");
            this.tBL_PersonelTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet15.TBL_Personel);
            txtpersoneldepartman.Clear();
            txtpersonelad.Clear();
            txtpersoneldepartman.Clear();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_Personel set PersonelAdSoyad=@p1,PersonelDeparman=@p2 where Personelid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtpersonelad.Text);
            komut.Parameters.AddWithValue("@p2", txtpersoneldepartman.Text);
            komut.Parameters.AddWithValue("@p3", txtpersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Güncellendi");
            this.tBL_PersonelTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet15.TBL_Personel);
            txtpersoneldepartman.Clear();
            txtpersonelad.Clear();
            txtpersoneldepartman.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int secilen;
            string id, ad, departman;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            departman = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtpersonelid.Text = id;
            txtpersonelad.Text = ad;
            txtpersoneldepartman.Text = departman;
            
        }
    }
}
