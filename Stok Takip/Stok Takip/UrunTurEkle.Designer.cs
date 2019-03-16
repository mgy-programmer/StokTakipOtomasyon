namespace Stok_Takip
{
    partial class UrunTurEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_turAdi = new System.Windows.Forms.TextBox();
            this.btn_ger = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tur_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tur_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_tuId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Türü Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tür Adı:";
            // 
            // txt_turAdi
            // 
            this.txt_turAdi.Location = new System.Drawing.Point(125, 77);
            this.txt_turAdi.Name = "txt_turAdi";
            this.txt_turAdi.Size = new System.Drawing.Size(223, 26);
            this.txt_turAdi.TabIndex = 2;
            // 
            // btn_ger
            // 
            this.btn_ger.Location = new System.Drawing.Point(306, 109);
            this.btn_ger.Name = "btn_ger";
            this.btn_ger.Size = new System.Drawing.Size(95, 30);
            this.btn_ger.TabIndex = 19;
            this.btn_ger.Text = "Geri";
            this.btn_ger.UseVisualStyleBackColor = true;
            this.btn_ger.Click += new System.EventHandler(this.btn_ger_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(205, 109);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(95, 30);
            this.btn_sil.TabIndex = 18;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(104, 109);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(95, 30);
            this.btn_guncelle.TabIndex = 17;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(3, 109);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(95, 30);
            this.btn_ekle.TabIndex = 16;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tur_id,
            this.Tur_Adi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 339);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Tur_id
            // 
            this.Tur_id.DataPropertyName = "Tur_id";
            this.Tur_id.HeaderText = "ID";
            this.Tur_id.Name = "Tur_id";
            // 
            // Tur_Adi
            // 
            this.Tur_Adi.DataPropertyName = "Tur_Adi";
            this.Tur_Adi.HeaderText = "Tür Adı";
            this.Tur_Adi.Name = "Tur_Adi";
            this.Tur_Adi.Width = 250;
            // 
            // txt_tuId
            // 
            this.txt_tuId.Location = new System.Drawing.Point(125, 45);
            this.txt_tuId.Name = "txt_tuId";
            this.txt_tuId.ReadOnly = true;
            this.txt_tuId.Size = new System.Drawing.Size(127, 26);
            this.txt_tuId.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID:";
            // 
            // UrunTurEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 496);
            this.Controls.Add(this.txt_tuId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ger);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_turAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "UrunTurEkle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürun Türü Ekle";
            this.Load += new System.EventHandler(this.UrunTurEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_turAdi;
        private System.Windows.Forms.Button btn_ger;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tur_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tur_Adi;
        private System.Windows.Forms.TextBox txt_tuId;
        private System.Windows.Forms.Label label3;
    }
}