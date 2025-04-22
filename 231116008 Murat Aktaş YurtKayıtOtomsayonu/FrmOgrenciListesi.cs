using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231116008_Murat_Aktaş_YurtKayıtOtomsayonu
{
    public partial class FrmOgrenciListesi: Form
    {
        public FrmOgrenciListesi()
        {
            InitializeComponent();
        }

        private void FrmOgrenciListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitOtomasyonuDataSet17.TBL_Ogrenciler' table. You can move, or remove it, as needed.
            this.tBL_OgrencilerTableAdapter1.Fill(this.yurtKayitOtomasyonuDataSet17.TBL_Ogrenciler);
            // TODO: This line of code loads data into the 'yurtKayitOtomasyonuDataSet8.TBL_Ogrenciler' table. You can move, or remove it, as needed.
            this.tBL_OgrencilerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet8.TBL_Ogrenciler);

        }

        int secilen;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
          
            FrmOgrDuzenle frm = new FrmOgrDuzenle();
            frm.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frm.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frm.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frm.tc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frm.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frm.dogum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frm.bolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frm.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frm.oda = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            frm.veliadsoyad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            frm.velitelefon = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            frm.veliadres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();

            frm.Show(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
