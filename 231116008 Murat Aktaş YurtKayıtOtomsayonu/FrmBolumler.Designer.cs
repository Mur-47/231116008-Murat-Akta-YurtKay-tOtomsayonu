namespace _231116008_Murat_Aktaş_YurtKayıtOtomsayonu
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.pcBolumEkle = new System.Windows.Forms.PictureBox();
            this.pcBolumDüzenle = new System.Windows.Forms.PictureBox();
            this.pcBolumSil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolumid = new System.Windows.Forms.TextBox();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yurtKayitOtomasyonuDataSet1 = new _231116008_Murat_Aktaş_YurtKayıtOtomsayonu.YurtKayitOtomasyonuDataSet1();
            this.tBLBolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_BolumlerTableAdapter = new _231116008_Murat_Aktaş_YurtKayıtOtomsayonu.YurtKayitOtomasyonuDataSet1TableAdapters.TBL_BolumlerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBolumDüzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLBolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBolumEkle
            // 
            this.pcBolumEkle.Image = global::_231116008_Murat_Aktaş_YurtKayıtOtomsayonu.Properties.Resources._11527831;
            this.pcBolumEkle.Location = new System.Drawing.Point(110, 118);
            this.pcBolumEkle.Name = "pcBolumEkle";
            this.pcBolumEkle.Size = new System.Drawing.Size(46, 52);
            this.pcBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBolumEkle.TabIndex = 2;
            this.pcBolumEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcBolumEkle, "Bölüm Ekle");
            this.pcBolumEkle.Click += new System.EventHandler(this.pcBolumEkle_Click);
            // 
            // pcBolumDüzenle
            // 
            this.pcBolumDüzenle.Image = global::_231116008_Murat_Aktaş_YurtKayıtOtomsayonu.Properties.Resources._6065488;
            this.pcBolumDüzenle.Location = new System.Drawing.Point(209, 118);
            this.pcBolumDüzenle.Name = "pcBolumDüzenle";
            this.pcBolumDüzenle.Size = new System.Drawing.Size(58, 52);
            this.pcBolumDüzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBolumDüzenle.TabIndex = 1;
            this.pcBolumDüzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcBolumDüzenle, "Bölüm Güncelle");
            this.pcBolumDüzenle.Click += new System.EventHandler(this.pcBolumDüzenle_Click);
            // 
            // pcBolumSil
            // 
            this.pcBolumSil.Image = global::_231116008_Murat_Aktaş_YurtKayıtOtomsayonu.Properties.Resources._458594;
            this.pcBolumSil.Location = new System.Drawing.Point(162, 118);
            this.pcBolumSil.Name = "pcBolumSil";
            this.pcBolumSil.Size = new System.Drawing.Size(41, 52);
            this.pcBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBolumSil.TabIndex = 0;
            this.pcBolumSil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcBolumSil, "Bölüm Sil");
            this.pcBolumSil.Click += new System.EventHandler(this.pcBolumSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm id:";
            // 
            // txtBolumid
            // 
            this.txtBolumid.Enabled = false;
            this.txtBolumid.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumid.Location = new System.Drawing.Point(100, 42);
            this.txtBolumid.Name = "txtBolumid";
            this.txtBolumid.Size = new System.Drawing.Size(182, 27);
            this.txtBolumid.TabIndex = 1;
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumAd.Location = new System.Drawing.Point(100, 75);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(182, 27);
            this.txtBolumAd.TabIndex = 2;
            this.txtBolumAd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Adı:";
            // 
            // yurtKayitOtomasyonuDataSet1
            // 
            this.yurtKayitOtomasyonuDataSet1.DataSetName = "YurtKayitOtomasyonuDataSet1";
            this.yurtKayitOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLBolumlerBindingSource
            // 
            this.tBLBolumlerBindingSource.DataMember = "TBL_Bolumler";
            this.tBLBolumlerBindingSource.DataSource = this.yurtKayitOtomasyonuDataSet1;
            // 
            // tBL_BolumlerTableAdapter
            // 
            this.tBL_BolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLBolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 277);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bölüm id";
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "Bölüm Adı";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBolumid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcBolumEkle);
            this.Controls.Add(this.pcBolumDüzenle);
            this.Controls.Add(this.pcBolumSil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBolumDüzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLBolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBolumSil;
        private System.Windows.Forms.PictureBox pcBolumDüzenle;
        private System.Windows.Forms.PictureBox pcBolumEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolumid;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.Label label2;
        private YurtKayitOtomasyonuDataSet1 yurtKayitOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource tBLBolumlerBindingSource;
        private YurtKayitOtomasyonuDataSet1TableAdapters.TBL_BolumlerTableAdapter tBL_BolumlerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}