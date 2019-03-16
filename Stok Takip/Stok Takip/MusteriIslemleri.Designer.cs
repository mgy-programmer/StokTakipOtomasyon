namespace Stok_Takip
{
    partial class MusteriIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriIslemleri));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.must_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.must_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.must_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.must_adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.must_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_musteriAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_musteriTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_musteriSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_musteriAdi = new System.Windows.Forms.TextBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.must_id,
            this.must_adi,
            this.must_soyad,
            this.must_adres,
            this.must_tel});
            this.dataGridView1.Location = new System.Drawing.Point(427, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 449);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // must_id
            // 
            this.must_id.DataPropertyName = "must_id";
            this.must_id.HeaderText = "ID";
            this.must_id.Name = "must_id";
            this.must_id.Width = 50;
            // 
            // must_adi
            // 
            this.must_adi.DataPropertyName = "must_adi";
            this.must_adi.HeaderText = "Adı";
            this.must_adi.Name = "must_adi";
            this.must_adi.Width = 150;
            // 
            // must_soyad
            // 
            this.must_soyad.DataPropertyName = "must_soyad";
            this.must_soyad.HeaderText = "Soyad";
            this.must_soyad.Name = "must_soyad";
            this.must_soyad.Width = 150;
            // 
            // must_adres
            // 
            this.must_adres.DataPropertyName = "must_adres";
            this.must_adres.HeaderText = "Adres";
            this.must_adres.Name = "must_adres";
            this.must_adres.Width = 200;
            // 
            // must_tel
            // 
            this.must_tel.DataPropertyName = "must_tel";
            this.must_tel.HeaderText = "Telefon";
            this.must_tel.Name = "must_tel";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(212, 412);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(88, 32);
            this.btn_sil.TabIndex = 22;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(118, 412);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(88, 32);
            this.btn_guncelle.TabIndex = 21;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(24, 412);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(88, 32);
            this.btn_ekle.TabIndex = 20;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Muşteri Adı:";
            // 
            // txt_musteriAdres
            // 
            this.txt_musteriAdres.Location = new System.Drawing.Point(162, 244);
            this.txt_musteriAdres.Multiline = true;
            this.txt_musteriAdres.Name = "txt_musteriAdres";
            this.txt_musteriAdres.Size = new System.Drawing.Size(229, 154);
            this.txt_musteriAdres.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Muşteri Soyadı:";
            // 
            // txt_musteriTel
            // 
            this.txt_musteriTel.Location = new System.Drawing.Point(162, 205);
            this.txt_musteriTel.Name = "txt_musteriTel";
            this.txt_musteriTel.Size = new System.Drawing.Size(229, 26);
            this.txt_musteriTel.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Muşteri Adres:";
            // 
            // txt_musteriSoyad
            // 
            this.txt_musteriSoyad.Location = new System.Drawing.Point(161, 169);
            this.txt_musteriSoyad.Name = "txt_musteriSoyad";
            this.txt_musteriSoyad.Size = new System.Drawing.Size(229, 26);
            this.txt_musteriSoyad.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Muşteri Tel:";
            // 
            // txt_musteriAdi
            // 
            this.txt_musteriAdi.Location = new System.Drawing.Point(162, 137);
            this.txt_musteriAdi.Name = "txt_musteriAdi";
            this.txt_musteriAdi.Size = new System.Drawing.Size(229, 26);
            this.txt_musteriAdi.TabIndex = 16;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(306, 412);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(88, 32);
            this.btn_geri.TabIndex = 24;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(166, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "Müşteri İşlemleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(209, 100);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(130, 26);
            this.txt_id.TabIndex = 28;
            // 
            // MusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 473);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_musteriAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_musteriTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_musteriSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_musteriAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MusteriIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.MusteriIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_musteriAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_musteriTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_musteriSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_musteriAdi;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn must_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn must_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn must_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn must_adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn must_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
    }
}