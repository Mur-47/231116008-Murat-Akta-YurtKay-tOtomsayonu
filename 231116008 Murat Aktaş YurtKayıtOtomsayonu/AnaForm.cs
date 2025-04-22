using DevExpress.Portable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231116008_Murat_Aktaş_YurtKayıtOtomsayonu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void persinelDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
         
            // TODO: This line of code loads data into the 'yurtKayitOtomasyonuDataSet12.TBL_Ogrenciler' table. You can move, or remove it, as needed.
            this.tBL_OgrencilerTableAdapter2.Fill(this.yurtKayitOtomasyonuDataSet13.TBL_Ogrenciler);
          
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text= DateTime.Now.ToLongDateString();
            label2.Text= DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }
        private void rADYO6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyo.dogannet.tv/numberone_fm";
        }

        private void rADYO7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyo.dogannet.tv/numberone_dance";
        }

        private void rADYO9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyo.itu.edu.tr/ITU_Radio_Classic.asx";
        }

        private void jOYTURKToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyo.dogannet.tv/joy_turk";
        }

        private void jOYTURKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyo.dogannet.tv/cnn_turk";
        }

        private void nTVRADYOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyo.dogannet.tv/ntv_radyo";
        }

        private void sLOWTURKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyo.dogannet.tv/slow_turk";
        }

        private void nUMBERONETURKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyo.dogannet.tv/numberone_turk";
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrKayit frm = new FrmOgrKayit();
            frm.Show();

        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciListesi frm = new FrmOgrenciListesi();
            frm.Show();
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciListesi frm = new FrmOgrenciListesi();
            frm.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler frm = new FrmBolumler();
            frm.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler frm = new FrmBolumler();
            frm.Show();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler frm = new FrmOdemeler();
            frm.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgiderler frm = new frmgiderler();
            frm.Show();

        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgiderlistesi frm = new frmgiderlistesi();
            frm.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGeliristatistik frm = new FrmGeliristatistik();
            frm.Show();
        }

        private void giderİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoneticiİslemleri frm = new FrmYoneticiİslemleri();
            frm.Show();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.Show();
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotEkle frm = new frmNotEkle();
            frm.Show();
        }

        private void öğrenciBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciRapor frm = new frmOgrenciRapor();
            frm.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bu Program, Henüz Kurulmamış Olan ''AKTAS C# PRM'' isimli Şirket Adına Murat Aktaş Tarafından 10 Mart 2025 Tarihinde Hazırlandı");
            

      
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void istatistiklerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
