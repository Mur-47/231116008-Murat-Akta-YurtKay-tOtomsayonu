namespace _231116008_Murat_Aktaş_YurtKayıtOtomsayonu
{
    partial class frmOgrenciRapor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenciRapor));
            this.TBL_OgrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.YurtKayitOtomasyonuDataSet16 = new _231116008_Murat_Aktaş_YurtKayıtOtomsayonu.YurtKayitOtomasyonuDataSet16();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TBL_OgrencilerTableAdapter = new _231116008_Murat_Aktaş_YurtKayıtOtomsayonu.YurtKayitOtomasyonuDataSet16TableAdapters.TBL_OgrencilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_OgrencilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YurtKayitOtomasyonuDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // TBL_OgrencilerBindingSource
            // 
            this.TBL_OgrencilerBindingSource.DataMember = "TBL_Ogrenciler";
            this.TBL_OgrencilerBindingSource.DataSource = this.YurtKayitOtomasyonuDataSet16;
            // 
            // YurtKayitOtomasyonuDataSet16
            // 
            this.YurtKayitOtomasyonuDataSet16.DataSetName = "YurtKayitOtomasyonuDataSet16";
            this.YurtKayitOtomasyonuDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TBL_OgrencilerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_231116008_Murat_Aktaş_YurtKayıtOtomsayonu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1157, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TBL_OgrencilerTableAdapter
            // 
            this.TBL_OgrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // frmOgrenciRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrenciRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Rapor";
            this.Load += new System.EventHandler(this.frmOgrenciRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBL_OgrencilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YurtKayitOtomasyonuDataSet16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TBL_OgrencilerBindingSource;
        private YurtKayitOtomasyonuDataSet16 YurtKayitOtomasyonuDataSet16;
        private YurtKayitOtomasyonuDataSet16TableAdapters.TBL_OgrencilerTableAdapter TBL_OgrencilerTableAdapter;
    }
}