using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stok_Takip
{
    public partial class KullanıcıIslemleri : Form
    {
        static SqlConnection connection;
        public KullanıcıIslemleri()
        {
            InitializeComponent();
        }

        private void btn_ger_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            this.Hide();
            admin.Show();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_adSoyad.Text != "" && txt_kullanici_adi.Text != "" && txt_mail.Text != "" && txt_sifre.Text != "")
            {
                string adSoyad = txt_adSoyad.Text;
                string kullanici_adi = txt_kullanici_adi.Text;
                string sifre = txt_sifre.Text;
                string mail = txt_mail.Text;
                string tel = txt_tel.Text;
                string adres = txt_adres.Text;
                connection = new SqlConnection("Data Source = DESKTOP-Q9PA9HF; Initial Catalog = stock; Integrated Security = true");
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sql = "insert into kullanici (kullanici_adi, kullanici_tel, kullanici_mail, kullanici_adres, kullanici_sifre, AdiSoyadi) values(@1, @2, @3, @4, @5, @6)";
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@1", kullanici_adi);
                    cmd.Parameters.AddWithValue("@2", tel);
                    cmd.Parameters.AddWithValue("@3", mail);
                    cmd.Parameters.AddWithValue("@4", adres);
                    cmd.Parameters.AddWithValue("@5", sifre);
                    cmd.Parameters.AddWithValue("@6", adSoyad);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Başarılı");
                }
                connection.Close();
                Temizle();
                VerileriCek();
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doldurun");
            }
        }

        private void KullanıcıIslemleri_Load(object sender, EventArgs e)
        {
            VerileriCek();
        }

        public void VerileriCek()
        {
            connection = new SqlConnection("Data Source = DESKTOP-Q9PA9HF; Initial Catalog = stock; Integrated Security = true");
            connection.Open();
            string kayit = "SELECT kullanici_id,AdiSoyadi,kullanici_adi,kullanici_tel,kullanici_mail,kullanici_adres,kullanici_sifre from kullanici";
            SqlCommand komut = new SqlCommand(kayit, connection);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        public void Temizle()
        {
            txt_id.Clear();
            txt_adSoyad.Clear();
            txt_kullanici_adi.Clear();
            txt_mail.Clear();
            txt_sifre.Clear();
            txt_tel.Clear();
            txt_adres.Clear();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                string adSoyad = txt_adSoyad.Text;
                string kullanici_adi = txt_kullanici_adi.Text;
                string sifre = txt_sifre.Text;
                string mail = txt_mail.Text;
                string tel = txt_tel.Text;
                string adres = txt_adres.Text;
                connection = new SqlConnection("Data Source = DESKTOP-Q9PA9HF; Initial Catalog = stock; Integrated Security = true");
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    string sql = "update kullanici set kullanici_adi=@1, kullanici_tel=@2, kullanici_mail=@3, kullanici_adres=@4, kullanici_sifre=@5, AdiSoyadi=@6 Where kullanici_id='" + txt_id.Text + "'";
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@1", kullanici_adi);
                        cmd.Parameters.AddWithValue("@2", tel);
                        cmd.Parameters.AddWithValue("@3", mail);
                        cmd.Parameters.AddWithValue("@4", adres);
                        cmd.Parameters.AddWithValue("@5", sifre);
                        cmd.Parameters.AddWithValue("@6", adSoyad);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Güncellendi ");
                    }
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata:" + e);
                }
                Temizle();
                VerileriCek();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçin");
            }
        }


        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                connection = new SqlConnection("Data Source = DESKTOP-Q9PA9HF; Initial Catalog = stock; Integrated Security = true");
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Delete From kullanici where kullanici_id=" + txt_id.Text + "", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Başarılı");
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("HAtaaaaaaaaaa: {0}", ex.Message));
                }
                Temizle();
                VerileriCek();
            }
            else
            {
                MessageBox.Show("Lütfen Silinecek Kaydı Seçiin");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_adSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_kullanici_adi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_sifre.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txt_tel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_mail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_adres.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
