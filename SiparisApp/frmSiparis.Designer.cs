namespace SiparisApp
{
    partial class frmSiparis
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnAnaSayfaDon = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTasi = new System.Windows.Forms.ComboBox();
            this.btnTasi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(58, 68);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(110, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(271, 28);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(101, 60);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(183, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "İkram Olsun";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 281);
            this.dataGridView1.TabIndex = 7;
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.BackColor = System.Drawing.Color.Tomato;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMasaNo.Location = new System.Drawing.Point(419, 136);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(200, 100);
            this.lblMasaNo.TabIndex = 8;
            this.lblMasaNo.Text = "00";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ödeme Tutarı:";
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTutari.Location = new System.Drawing.Point(418, 269);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(39, 25);
            this.lblOdemeTutari.TabIndex = 10;
            this.lblOdemeTutari.Text = "0 ₺";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIptal.Location = new System.Drawing.Point(414, 316);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(95, 63);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOdemeAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOdemeAl.Location = new System.Drawing.Point(524, 316);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(95, 63);
            this.btnOdemeAl.TabIndex = 12;
            this.btnOdemeAl.Text = "Ödeme Al";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // btnAnaSayfaDon
            // 
            this.btnAnaSayfaDon.Location = new System.Drawing.Point(414, 385);
            this.btnAnaSayfaDon.Name = "btnAnaSayfaDon";
            this.btnAnaSayfaDon.Size = new System.Drawing.Size(205, 32);
            this.btnAnaSayfaDon.TabIndex = 13;
            this.btnAnaSayfaDon.Text = "Ana Sayfa";
            this.btnAnaSayfaDon.UseVisualStyleBackColor = true;
            this.btnAnaSayfaDon.Click += new System.EventHandler(this.btnAnaSayfaDon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Masa No:";
            // 
            // cmbTasi
            // 
            this.cmbTasi.FormattingEnabled = true;
            this.cmbTasi.Location = new System.Drawing.Point(477, 45);
            this.cmbTasi.Name = "cmbTasi";
            this.cmbTasi.Size = new System.Drawing.Size(121, 21);
            this.cmbTasi.TabIndex = 15;
            // 
            // btnTasi
            // 
            this.btnTasi.Location = new System.Drawing.Point(477, 72);
            this.btnTasi.Name = "btnTasi";
            this.btnTasi.Size = new System.Drawing.Size(121, 23);
            this.btnTasi.TabIndex = 16;
            this.btnTasi.Text = "Taşı";
            this.btnTasi.UseVisualStyleBackColor = true;
            this.btnTasi.Click += new System.EventHandler(this.btnTasi_Click);
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 431);
            this.Controls.Add(this.btnTasi);
            this.Controls.Add(this.cmbTasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAnaSayfaDon);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmSiparis";
            this.Text = "Masa kaç";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSiparis_FormClosing);
            this.Load += new System.EventHandler(this.frmSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnAnaSayfaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTasi;
        private System.Windows.Forms.Button btnTasi;
    }
}