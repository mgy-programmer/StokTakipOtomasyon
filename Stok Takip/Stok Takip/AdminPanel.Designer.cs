namespace Stok_Takip
{
    partial class AdminPanel
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
            this.btn_musteriIslemleri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_musteri = new System.Windows.Forms.ComboBox();
            this.combo_kullanici = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_urun = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fatura_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatura_tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatura_aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciF_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunF_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriF_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_musteriIslemleri
            // 
            this.btn_musteriIslemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_musteriIslemleri.Location = new System.Drawing.Point(12, 12);
            this.btn_musteriIslemleri.Name = "btn_musteriIslemleri";
            this.btn_musteriIslemleri.Size = new System.Drawing.Size(150, 35);
            this.btn_musteriIslemleri.TabIndex = 0;
            this.btn_musteriIslemleri.Text = "Müşteri İşlemleri";
            this.btn_musteriIslemleri.UseVisualStyleBackColor = true;
            this.btn_musteriIslemleri.Click += new System.EventHandler(this.btn_musteriIslemleri_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(168, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kullanıcı İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(338, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Urun İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(520, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fatura İşlemler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteri Adı:";
            // 
            // combo_musteri
            // 
            this.combo_musteri.FormattingEnabled = true;
            this.combo_musteri.Location = new System.Drawing.Point(124, 110);
            this.combo_musteri.Name = "combo_musteri";
            this.combo_musteri.Size = new System.Drawing.Size(196, 28);
            this.combo_musteri.TabIndex = 5;
            // 
            // combo_kullanici
            // 
            this.combo_kullanici.FormattingEnabled = true;
            this.combo_kullanici.Location = new System.Drawing.Point(124, 154);
            this.combo_kullanici.Name = "combo_kullanici";
            this.combo_kullanici.Size = new System.Drawing.Size(196, 28);
            this.combo_kullanici.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // combo_urun
            // 
            this.combo_urun.FormattingEnabled = true;
            this.combo_urun.Location = new System.Drawing.Point(124, 199);
            this.combo_urun.Name = "combo_urun";
            this.combo_urun.Size = new System.Drawing.Size(196, 28);
            this.combo_urun.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Urun Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fatura Tarih:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(516, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fatura Açıklama:";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(516, 137);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(412, 126);
            this.txt_aciklama.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fatura_id,
            this.adet,
            this.fatura_tarih,
            this.fatura_aciklama,
            this.kullaniciF_id,
            this.urunF_id,
            this.musteriF_id});
            this.dataGridView1.Location = new System.Drawing.Point(12, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 420);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // fatura_id
            // 
            this.fatura_id.DataPropertyName = "fatura_id";
            this.fatura_id.HeaderText = "ID";
            this.fatura_id.Name = "fatura_id";
            this.fatura_id.Width = 35;
            // 
            // adet
            // 
            this.adet.DataPropertyName = "adet";
            this.adet.HeaderText = "Adet";
            this.adet.Name = "adet";
            // 
            // fatura_tarih
            // 
            this.fatura_tarih.DataPropertyName = "fatura_tarih";
            this.fatura_tarih.HeaderText = "Tarih";
            this.fatura_tarih.Name = "fatura_tarih";
            // 
            // fatura_aciklama
            // 
            this.fatura_aciklama.DataPropertyName = "fatura_aciklama";
            this.fatura_aciklama.HeaderText = "Açıklama";
            this.fatura_aciklama.Name = "fatura_aciklama";
            this.fatura_aciklama.Width = 315;
            // 
            // kullaniciF_id
            // 
            this.kullaniciF_id.DataPropertyName = "kullaniciF_id";
            this.kullaniciF_id.HeaderText = "Yetkili";
            this.kullaniciF_id.Name = "kullaniciF_id";
            this.kullaniciF_id.Width = 150;
            // 
            // urunF_id
            // 
            this.urunF_id.DataPropertyName = "urunF_id";
            this.urunF_id.HeaderText = "Ürün";
            this.urunF_id.Name = "urunF_id";
            this.urunF_id.Width = 150;
            // 
            // musteriF_id
            // 
            this.musteriF_id.DataPropertyName = "musteriF_id";
            this.musteriF_id.HeaderText = "Müşteri";
            this.musteriF_id.Name = "musteriF_id";
            this.musteriF_id.Width = 150;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(214, 243);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(95, 30);
            this.btn_sil.TabIndex = 22;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(113, 243);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(95, 30);
            this.btn_ekle.TabIndex = 20;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(130, 67);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(146, 26);
            this.txt_id.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Adet:";
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(516, 67);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(132, 26);
            this.txt_adet.TabIndex = 27;
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(12, 243);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(95, 30);
            this.btn_kapat.TabIndex = 28;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(315, 243);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(95, 30);
            this.btn_temizle.TabIndex = 29;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 711);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.txt_adet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_urun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_kullanici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_musteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_musteriIslemleri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_musteriIslemleri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_musteri;
        private System.Windows.Forms.ComboBox combo_kullanici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_urun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatura_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatura_tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatura_aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciF_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunF_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriF_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Button btn_temizle;
    }
}