using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stok_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            var cevap = MessageBox.Show("Çıkmak istediğinize eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btn_giris_Click(object sender, EventArgs e)
        {
            if(txt_kullaniciAdi.Text!="" && txt_sifre.Text != "")
            {
                SqlConnection scn = new SqlConnection();
                scn.ConnectionString = @"Data Source=DESKTOP-Q9PA9HF;Initial Catalog=login_database;database=stock;integrated security=SSPI";
                if (scn.State != ConnectionState.Open)
                {
                    scn.Open();
                }
                SqlCommand scmd = new SqlCommand("select kullanici_adi, kullanici_sifre from login", scn);
                SqlDataReader reader = scmd.ExecuteReader();
                while (reader.Read())
                {

                    if (txt_kullaniciAdi.Text == reader[0].ToString() && txt_sifre.Text == reader[1].ToString())
                    {


                        this.Hide();
                        AdminPanel admin = new AdminPanel();
                        admin.Show();

                    }

                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                    }


                }

                scn.Close();

            }
            else
            {
                MessageBox.Show("Lütfen gerekli yerleri doldurun");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_kullaniciAdi;
        }
    }
}
