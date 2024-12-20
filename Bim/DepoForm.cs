using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BimOtomasyon
{
    public partial class DepoForm : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=BimOtomasyon;Integrated Security=True;Encrypt=False";

        public DepoForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        // Ürünleri DataGridView'e yükle
        private void LoadProducts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Barkod, UrunAdi, Stok, Fiyat, KritikStok FROM Urun";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvProducts.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürünler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        // Ürün ekle veya güncelle
        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            string barkod = txtBarcode.Text.Trim();
            string urunAdi = txtProductName.Text.Trim();
            string stokText = txtStock.Text.Trim();
            //string fiyatText = txtPrice.Text.Trim();
            //string kritikStokText = txtCriticalStock.Text.Trim();

            //if (string.IsNullOrEmpty(barkod) || string.IsNullOrEmpty(urunAdi) || string.IsNullOrEmpty(stokText) ||
            //    string.IsNullOrEmpty(fiyatText) || string.IsNullOrEmpty(kritikStokText))
            //{
            //    MessageBox.Show("Lütfen tüm alanları doldurun!");
            //    return;
            //}

            //if (!int.TryParse(stokText, out int stok) || !decimal.TryParse(fiyatText, out decimal fiyat) ||
            //    !int.TryParse(kritikStokText, out int kritikStok))
            //{
            //    MessageBox.Show("Stok, kritik stok ve fiyat geçerli birer sayı olmalıdır!");
            //    return;
            //}

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        IF EXISTS (SELECT 1 FROM Urun WHERE Barkod = @Barkod)
                        BEGIN
                            UPDATE Urun SET UrunAdi = @UrunAdi, Stok = Stok + @Stok, Fiyat = @Fiyat, KritikStok = @KritikStok WHERE Barkod = @Barkod
                        END
                        ELSE
                        BEGIN
                            INSERT INTO Urun (Barkod, UrunAdi, Stok, Fiyat, KritikStok) VALUES (@Barkod, @UrunAdi, @Stok, @Fiyat, @KritikStok)
                        END";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Barkod", barkod);
                        command.Parameters.AddWithValue("@UrunAdi", urunAdi);
                        //command.Parameters.AddWithValue("@Stok", stok);
                        //command.Parameters.AddWithValue("@Fiyat", fiyat);
                        //command.Parameters.AddWithValue("@KritikStok", kritikStok);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Ürün başarıyla eklendi/güncellendi!");
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün eklenirken/güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        // Barkoda göre ürün arama
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchBarcode = txtSearchBarcode.Text.Trim();

            if (string.IsNullOrEmpty(searchBarcode))
            {
                MessageBox.Show("Lütfen bir barkod girin!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Barkod, UrunAdi, Stok, Fiyat, KritikStok FROM Urun WHERE Barkod = @Barkod";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Barkod", searchBarcode);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvProducts.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Bu barkoda sahip bir ürün bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün aranırken bir hata oluştu: " + ex.Message);
            }
        }

        private void DepoForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde ürünleri yükle
            LoadProducts();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gerekli olduğunda DataGridView'deki hücreye tıklama işlemleri buraya yazılabilir
        }
    }
}
