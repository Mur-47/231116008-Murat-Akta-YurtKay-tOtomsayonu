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
    public partial class frmgiderlistesi: Form
    {
        public frmgiderlistesi()
        {
            InitializeComponent();
        }

        private void frmgiderlistesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitOtomasyonuDataSet9.TBL_Giderler' table. You can move, or remove it, as needed.
            this.tBL_GiderlerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet9.TBL_Giderler);

        }
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            FrmGiderGuncelle fr = new FrmGiderGuncelle();   
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            fr.elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.gida = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.Show();

            this.tBL_GiderlerTableAdapter.Fill(this.yurtKayitOtomasyonuDataSet9.TBL_Giderler);

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
