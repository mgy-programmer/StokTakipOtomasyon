using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Stok_Takip
{
    public partial class MusteriIslemleri : Form
    {
        public MusteriIslemleri()
        {
            InitializeComponent();
        }
        static SqlConnection connection;
        private void btn_geri_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            this.Hide();
            admin.Show();
        }

        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
            VerileriCek();
        }

        public void VerileriCek()
        {
            connection = new SqlConnection("Data Source = DESKTOP-Q9PA9HF; Initial Catalog = stock; Integrated Security = true");
            connection.Open();
            string kayit = "SELECT must_id,must_adi,must_soyad,must_adres,must_tel from Musteri";
            SqlCommand komut = new SqlCommand(kayit, connection);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if(txt_musteriAdi.Text!="" && txt_musteriAdres.Text!="" && txt_musteriSoyad.Text!="" && txt_musteriTel.Text != "")
            {
                string ad = txt_musteriAdi.Text;
                string soyad = txt_musteriSoyad.Text;
                string adres = txt_musteriAdres.Text;
                string tel = txt_musteriTel.Text;
                connection = new SqlConnection("Data Source = DESKTOP-Q9PA9HF; Initial Catalog = stock; Integrated Security = true");
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sql = "insert into Musteri (must_adi, must_soyad, must_adres, must_tel) values(@1, @2, @3, @4)";
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@1", ad);
                    cmd.Parameters.AddWithValue("@2", soyad);
                    cmd.Parameters.AddWithValue("@3", adres);
                    cmd.Parameters.AddWithValue("@4", tel);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Eklendi ");
                }
                connection.Close();
                Temizle();
                VerileriCek();
            }
            else
            {
                MessageBox.Show("Lütfen gerekli yerleri doldurun");
            }
        }

        public void Temizle()
        {
            txt_musteriAdi.Clear();
            txt_musteriAdres.Clear();
            txt_musteriSoyad.Clear();
            txt_musteriTel.Clear();
            txt_id.Clear();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                string ad = txt_musteriAdi.Text;
                string soyad = txt_musteriSoyad.Text;
                string adres = txt_musteriAdres.Text;
                string tel = txt_musteriTel.Text;
                connection = new SqlConnection("Data Source = DESKTOP-Q9PA9HF; Initial Catalog = stock; Integrated Security = true");
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    string sql = "update Musteri set must_adi=@1, must_soyad=@2, must_adres=@3, must_tel=@4 Where must_id='" + txt_id.Text + "'";
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@1", ad);
                        cmd.Parameters.AddWithValue("@2", soyad);
                        cmd.Parameters.AddWithValue("@3", adres);
                        cmd.Parameters.AddWithValue("@4", tel);
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
                MessageBox.Show("Lütfen Güncellenecek kayıt seçiniz");
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
                    SqlCommand command = new SqlCommand("Delete From Musteri where must_id=" + txt_id.Text + "", connection);
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
                MessageBox.Show("Lütfen Silinecek Kayıt Seçiniz");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                txt_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                txt_musteriAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                txt_musteriSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                txt_musteriAdres.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                txt_musteriTel.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Tekrar Deneyin");
            }
        }
    }
}
