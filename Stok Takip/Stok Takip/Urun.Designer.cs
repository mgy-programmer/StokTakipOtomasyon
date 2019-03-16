namespace Stok_Takip
{
    partial class Urun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urun));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ger = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_urunAciklama = new System.Windows.Forms.TextBox();
            this.txt_urunAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_urunTur = new System.Windows.Forms.ComboBox();
            this.btn_turEkle = new System.Windows.Forms.Button();
            this.txt_sayi = new System.Windows.Forms.TextBox();
            this.urun_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_tur_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urun_id,
            this.urun_adi,
            this.urun_tur_id,
            this.urun_aciklama,
            this.urun_stok});
            this.dataGridView1.Location = new System.Drawing.Point(397, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 320);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_ger
            // 
            this.btn_ger.Location = new System.Drawing.Point(226, 387);
            this.btn_ger.Name = "btn_ger";
            this.btn_ger.Size = new System.Drawing.Size(95, 30);
            this.btn_ger.TabIndex = 33;
            this.btn_ger.Text = "Geri";
            this.btn_ger.UseVisualStyleBackColor = true;
            this.btn_ger.Click += new System.EventHandler(this.btn_ger_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(278, 342);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(95, 30);
            this.btn_sil.TabIndex = 32;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(160, 342);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(95, 30);
            this.btn_guncelle.TabIndex = 31;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(43, 342);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(95, 30);
            this.btn_ekle.TabIndex = 30;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_urunAciklama
            // 
            this.txt_urunAciklama.Location = new System.Drawing.Point(160, 221);
            this.txt_urunAciklama.Multiline = true;
            this.txt_urunAciklama.Name = "txt_urunAciklama";
            this.txt_urunAciklama.Size = new System.Drawing.Size(231, 104);
            this.txt_urunAciklama.TabIndex = 26;
            // 
            // txt_urunAdi
            // 
            this.txt_urunAdi.Location = new System.Drawing.Point(160, 107);
            this.txt_urunAdi.Name = "txt_urunAdi";
            this.txt_urunAdi.Size = new System.Drawing.Size(231, 26);
            this.txt_urunAdi.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Urun Açıklaması:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Urun Sayisi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Urun Adi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(308, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Urun İşlemleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Urun Türü:";
            // 
            // combo_urunTur
            // 
            this.combo_urunTur.FormattingEnabled = true;
            this.combo_urunTur.Location = new System.Drawing.Point(160, 178);
            this.combo_urunTur.Name = "combo_urunTur";
            this.combo_urunTur.Size = new System.Drawing.Size(231, 28);
            this.combo_urunTur.TabIndex = 38;
            // 
            // btn_turEkle
            // 
            this.btn_turEkle.Location = new System.Drawing.Point(52, 387);
            this.btn_turEkle.Name = "btn_turEkle";
            this.btn_turEkle.Size = new System.Drawing.Size(154, 30);
            this.btn_turEkle.TabIndex = 39;
            this.btn_turEkle.Text = "Ürün Tür Ekle";
            this.btn_turEkle.UseVisualStyleBackColor = true;
            this.btn_turEkle.Click += new System.EventHandler(this.btn_turEkle_Click);
            // 
            // txt_sayi
            // 
            this.txt_sayi.Location = new System.Drawing.Point(160, 142);
            this.txt_sayi.Name = "txt_sayi";
            this.txt_sayi.Size = new System.Drawing.Size(231, 26);
            this.txt_sayi.TabIndex = 25;
            // 
            // urun_id
            // 
            this.urun_id.DataPropertyName = "urun_id";
            this.urun_id.HeaderText = "ID";
            this.urun_id.Name = "urun_id";
            this.urun_id.Width = 40;
            // 
            // urun_adi
            // 
            this.urun_adi.DataPropertyName = "urun_adi";
            this.urun_adi.HeaderText = "Urun Adı";
            this.urun_adi.Name = "urun_adi";
            this.urun_adi.Width = 150;
            // 
            // urun_tur_id
            // 
            this.urun_tur_id.DataPropertyName = "urun_tur_id";
            this.urun_tur_id.HeaderText = "Tür";
            this.urun_tur_id.Name = "urun_tur_id";
            // 
            // urun_aciklama
            // 
            this.urun_aciklama.DataPropertyName = "urun_aciklama";
            this.urun_aciklama.HeaderText = "Açıklama";
            this.urun_aciklama.Name = "urun_aciklama";
            this.urun_aciklama.Width = 200;
            // 
            // urun_stok
            // 
            this.urun_stok.DataPropertyName = "urun_stok";
            this.urun_stok.HeaderText = "Stok";
            this.urun_stok.Name = "urun_stok";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(236, 66);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(155, 26);
            this.txt_id.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "ID:";
            // 
            // Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 429);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_turEkle);
            this.Controls.Add(this.combo_urunTur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ger);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_urunAciklama);
            this.Controls.Add(this.txt_sayi);
            this.Controls.Add(this.txt_urunAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Urun";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun İşlemleri";
            this.Load += new System.EventHandler(this.Urun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ger;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_urunAciklama;
        private System.Windows.Forms.TextBox txt_urunAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_urunTur;
        private System.Windows.Forms.Button btn_turEkle;
        private System.Windows.Forms.TextBox txt_sayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_tur_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_stok;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
    }
}