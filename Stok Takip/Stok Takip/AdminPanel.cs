using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stok_Takip
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        public SqlConnection connection;
        private void button1_Click(object sender, EventArgs e)
        {
            KullanıcıIslemleri kullanici = new KullanıcıIslemleri();
            this.Hide();
            kullanici.Show();
        }

        private void btn_musteriIslemleri_Click(object sender, EventArgs e)
        {
            MusteriIslemleri musteri = new MusteriIslemleri();
            this.Hide();
            musteri.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            this.Hide();
            urun.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source = DESKTOP-Q9PA9HF; Initial Catalog = stock; Integrated Security = true; MultipleActiveResultSets = True");
            ComboKDoldur();
            ComboUDoldur();
            ComboMDoldur();
            VerileriCek();
            combo_kullanici.SelectedIndex = 0;
            combo_musteri.SelectedIndex = 0;
            combo_urun.SelectedIndex = 0;
        }
        public void ComboMDoldur()
        {
            string query = "select must_id, must_adi from Musteri ";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            DataSet ds = new DataSet();
            da.Fill(ds, "Musteri");
            combo_musteri.DisplayMember = "must_adi";
            combo_musteri.ValueMember = "must_id";
            combo_musteri.DataSource = ds.Tables["Musteri"];
            connection.Close();
        }
        public void ComboKDoldur()
        {
            string query = "select kullanici_id, kullanici_adi from kullanici";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            DataSet ds2 = new DataSet();
            da.Fill(ds2, "kullanici");
            combo_kullanici.DisplayMember = "kullanici_adi";
            combo_kullanici.ValueMember = "kullanici_id";
            combo_kullanici.DataSource = ds2.Tables["kullanici"];
            connection.Close();
        }
        public void ComboUDoldur()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            string query = "select urun_id, urun_adi from urun ";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds3 = new DataSet();
            da.Fill(ds3, "urun");
            combo_urun.DisplayMember = "urun_adi";
            combo_urun.ValueMember = "urun_id";
            combo_urun.DataSource = ds3.Tables["urun"];
            connection.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            bool kontrol = true;
            if (txt_aciklama.Text != "" && txt_adet.Text != "")
            {

                int Must_adSoyad = int.Parse(combo_musteri.SelectedValue.ToString());
                int Kul_adSoyad = int.Parse(combo_kullanici.SelectedValue.ToString());
                int Urun_ad = int.Parse(combo_urun.SelectedValue.ToString());
                string aciklama = txt_aciklama.Text;
                string tarih = dateTimePicker1.Value.ToString();
                int adet = int.Parse(txt_adet.Text);
                kontrol = stokAzalt(kontrol);
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                if (kontrol == false)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string sql = "insert into fatura (fatura_tarih, fatura_aciklama, kullaniciF_id, urunF_id, musteriF_id, adet) values(@1, @2, @3, @4, @5, @6)";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@1", tarih);
                    cmd.Parameters.AddWithValue("@2", aciklama);
                    cmd.Parameters.AddWithValue("@3", Kul_adSoyad);
                    cmd.Parameters.AddWithValue("@4", Urun_ad);
                    cmd.Parameters.AddWithValue("@5", Must_adSoyad);
                    cmd.Parameters.AddWithValue("@6", adet);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Başarılı ");
                    Temizle();
                    VerileriCek();
                }
                else
                {
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun");
            }
        }

        public bool stokAzalt(bool kontrol)
        {
            int adet = int.Parse(txt_adet.Text);
            string urunAdi = combo_urun.Text;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            string kayit = "SELECT urun_adi, urun_stok from urun";
            SqlCommand komut = new SqlCommand(kayit, connection);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (urunAdi == reader["urun_adi"].ToString())
                {
                    int top = int.Parse(reader["urun_stok"].ToString());
                    if (top == 0)
                    {
                        MessageBox.Show("Stokta Kalmamış");
                    }
                    else
                    {
                        if (adet > top)
                        {
                            MessageBox.Show("Stokta istenilen adet kadar kalmamış");
                        }
                        else
                        {
                            int sonuc = top - adet;
                            azalt(sonuc, urunAdi);
                            Temizle();
                            kontrol = false;
                            break;
                        }
                    }
                }
            }
            connection.Close();
            return kontrol;
        }

        public void azalt(int sonuc, string urunAdi)
        {
            string cumle = "update urun set urun_stok=@1 where urun_adi='" + urunAdi + "'";
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            using (SqlCommand cmd = new SqlCommand(cumle, connection))
            {
                cmd.Parameters.AddWithValue("@1", sonuc);
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void VerileriCek()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            string kayit = "SELECT * from fatura";
            SqlCommand komut = new SqlCommand(kayit, connection);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        public void Temizle()
        {
            txt_id.Text = "";
            txt_aciklama.Text="";
            dateTimePicker1.Value = DateTime.Now;
            combo_kullanici.SelectedIndex = 0;
            combo_musteri.SelectedIndex = 0;
            combo_urun.SelectedIndex = 0;
            txt_adet.Clear();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("Delete From fatura where fatura_id=" + txt_id.Text + "", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Başarılı");

                Temizle();
                VerileriCek();
            }
            else
            {
                MessageBox.Show("Bir kayıt Seçiniz");
            }
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
