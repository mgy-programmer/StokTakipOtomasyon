using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class UrunTurEkle : Form
    {
        public UrunTurEkle()
        {
            InitializeComponent();
        }
        static SqlConnection connection;
        private void btn_ger_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            this.Hide();
            urun.Show();
        }

        private void UrunTurEkle_Load(object sender, EventArgs e)
        {
            VerileriCek();
        }
        public void VerileriCek()
        {
            connection = new SqlConnection("Data Source = DESKTOP-Q9PA9HF; Initial Catalog = stock; Integrated Security = true");
            connection.Open();
            string kayit = "SELECT * from Urun_Turleri";
            SqlCommand komut = new SqlCommand(kayit, connection);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_turAdi.Text != "")
            {
                string tur = txt_turAdi.Text;
                connection = new SqlConnection("Data Source = DESKTOP-Q9PA9HF; Initial Catalog = stock; Integrated Security = true");
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sql = "insert into Urun_Turleri (Tur_Adi) values(@1)";
                
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@1", tur);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Eklendi ");
                }
                connection.Close();
                Temizle();
                VerileriCek();
            }
            else
            {
                MessageBox.Show("Tür Adını Yazınız");
            }
        }
        public void Temizle()
        {
            txt_tuId.Clear();
            txt_turAdi.Clear();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_tuId.Text != "")
            {
                string tur = txt_turAdi.Text;
                connection = new SqlConnection("Data Source = DESKTOP-Q9PA9HF; Initial Catalog = stock; Integrated Security = true");
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    string sql = "update Urun_Turleri set Tur_Adi=@1 Where Tur_id='" + txt_tuId.Text + "'";
                    
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@1", tur);
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
                MessageBox.Show("Lütfen Güncellenecek Kaydı Seçiniz");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_tuId.Text != "")
            {
                connection = new SqlConnection("Data Source = DESKTOP-Q9PA9HF; Initial Catalog = stock; Integrated Security = true");
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    SqlCommand command = new SqlCommand("Delete From Urun_Turleri where Tur_id=" + txt_tuId.Text + "", connection);
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
                MessageBox.Show("Lütfen Silinecek Kaydı Seçiniz");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_tuId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_turAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
