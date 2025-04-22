using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace _231116008_Murat_Aktaş_YurtKayıtOtomsayonu
{
    public partial class frmNotEkle: Form
    {
        public frmNotEkle()
        {
            InitializeComponent();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kayıt Yeri Seçiniz";
            saveFileDialog1.Filter = "Metin Dosyası |*.txt";
            saveFileDialog1.InitialDirectory = @"C:\Users\MONSTER\Desktop";
            saveFileDialog1.ShowDialog();
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            MessageBox.Show("Dosya Kaydedildi");

        }
    }
}
