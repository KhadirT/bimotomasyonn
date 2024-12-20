using Bim;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BimOtomasyon
{
    public partial class LoginForm : Form
    {
        // SQL Server bağlantı dizesi
        private string connectionString = @"Server=.;Database=BimOtomasyon;Trusted_Connection=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string rol = cmbRol.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kullanıcıyı doğrulamak için SQL sorgusu
                    string query = "SELECT COUNT(*) FROM Kullanici WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre AND Rol = @Rol";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@Sifre", sifre);
                        cmd.Parameters.AddWithValue("@Rol", rol);

                        int userExists = (int)cmd.ExecuteScalar();

                        if (userExists > 0)
                        {
                            MessageBox.Show($"Giriş Başarılı! {rol} ekranına yönlendiriliyorsunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Rol bazlı ekranlara yönlendirme
                            switch (rol)
                            {
                                case "Depo Görevlisi":
                                    // Admin ekranını aç
                                    DepoForm adminForm = new DepoForm();
                                    adminForm.Show();
                                    break;
                                case "Kasiyer":
                                    // Kasiyer ekranını aç
                                    KasiyerForm kasiyerForm = new KasiyerForm();
                                    kasiyerForm.Show();
                                    break;
                                case "Yönetici":
                                    // Yönetici ekranını aç
                                    YoneticiForm yoneticiForm = new YoneticiForm();
                                    yoneticiForm.Show();
                                    break;
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Giriş başarısız. Bilgilerinizi kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
