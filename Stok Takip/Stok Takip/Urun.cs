using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class Urun : Form
    {
        public Urun()
        {
            InitializeComponent();
        }
        static SqlConnection connection;
        private void btn_ger_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            this.Hide();
            admin.Show();
        }

        private void btn_turEkle_Click(object sender, EventArgs e)
        {
            UrunTurEkle tur = new UrunTurEkle();
            this.Hide();
            tur.Show();
        }

        private void Urun_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source = DESKTOP-Q9PA9HF; Initial Catalog = stock; Integrated Security = true");
            ComboDoldur();
            if(combo_urunTur.SelectedIndex == 0)
            {
                combo_urunTur.SelectedIndex = 1;
            }
            VerileriCek();
        }
        public void ComboDoldur()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            string query = "select Tur_Adi, Tur_id from Urun_Turleri";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            
            DataSet ds = new DataSet();
            da.Fill(ds, "Urun_Turleri");
            combo_urunTur.DisplayMember = "Tur_Adi";
            combo_urunTur.ValueMember = "Tur_id";
            combo_urunTur.DataSource = ds.Tables["Urun_Turleri"];
            connection.Close();
        }
        public void VerileriCek()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            string kayit = "SELECT *from urun";
            SqlCommand komut = new SqlCommand(kayit, connection);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_sayi.Text != "" && txt_urunAciklama.Text != "" && txt_urunAdi.Text != "")
            {
                string ad = txt_urunAdi.Text;
                string stok = txt_sayi.Text;
                int urunTur = combo_urunTur.SelectedIndex;
                string aciklama = txt_urunAciklama.Text;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sql = "insert into urun (urun_adi, urun_stok, urun_tur_id, urun_aciklama) values(@1, @2, @3, @4)";
                
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@1", ad);
                    cmd.Parameters.AddWithValue("@2", stok);
                    cmd.Parameters.AddWithValue("@3", urunTur);
                    cmd.Parameters.AddWithValue("@4", aciklama);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Eklendi ");
                }
                connection.Close();
                Temizle();
                VerileriCek();
            }
            else
            {
                MessageBox.Show("Lütfen gerekli yerleri doldurunuz");
            }
        }

        public void Temizle()
        {
            txt_sayi.Clear();
            txt_urunAciklama.Clear();
            txt_urunAdi.Clear();
            combo_urunTur.Text = "";
            txt_id.Clear();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                string ad = txt_urunAdi.Text;
                string stok = txt_sayi.Text;
                int urunTur = combo_urunTur.SelectedIndex;
                string aciklama = txt_urunAciklama.Text;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sql = "update urun set urun_adi=@1, urun_tur_id=@2, urun_aciklama=@3, urun_stok=@4 Where urun_id='" + txt_id.Text + "'";
                
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@1", ad);
                    cmd.Parameters.AddWithValue("@2", urunTur);
                    cmd.Parameters.AddWithValue("@3", aciklama);
                    cmd.Parameters.AddWithValue("@4", stok);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Güncellendi ");
                }
                connection.Close();
                Temizle();
                VerileriCek();
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçiniz");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("Delete From urun where urun_id=" + txt_id.Text + "", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Başarılı");
                Temizle();
                VerileriCek();
            }
            else
            {
                MessageBox.Show("Lüften Silinecek Kaydı Seçiniz");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                txt_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                txt_urunAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                txt_urunAciklama.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                txt_sayi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                combo_urunTur.SelectedIndex = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[2].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Tekrar Seçiniz");
            }
        }
    }
}
