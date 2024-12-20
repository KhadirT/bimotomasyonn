namespace BimOtomasyon
{
    partial class DepoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.txtSearchBarcode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblSearchBarcode = new System.Windows.Forms.Label();
            this.bimOtomasyonDataSet = new Bim.BimOtomasyonDataSet();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunTableAdapter = new Bim.BimOtomasyonDataSetTableAdapters.UrunTableAdapter();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kritikStokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIDDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.kritikStokDataGridViewTextBoxColumn,
            this.barkodDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.urunBindingSource;
            this.dgvProducts.Location = new System.Drawing.Point(12, 200);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(492, 200);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(100, 20);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(150, 22);
            this.txtBarcode.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(100, 50);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(150, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(100, 80);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(150, 22);
            this.txtStock.TabIndex = 3;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(100, 110);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(150, 23);
            this.btnAddUpdate.TabIndex = 4;
            this.btnAddUpdate.Text = "Ürün Ekle/Güncelle";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // txtSearchBarcode
            // 
            this.txtSearchBarcode.Location = new System.Drawing.Point(100, 150);
            this.txtSearchBarcode.Name = "txtSearchBarcode";
            this.txtSearchBarcode.Size = new System.Drawing.Size(150, 22);
            this.txtSearchBarcode.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(270, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(12, 23);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(54, 16);
            this.lblBarcode.TabIndex = 7;
            this.lblBarcode.Text = "Barkod:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 53);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(65, 16);
            this.lblProductName.TabIndex = 8;
            this.lblProductName.Text = "Ürün İsmi:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(12, 83);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(37, 16);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Stok:";
            // 
            // lblSearchBarcode
            // 
            this.lblSearchBarcode.AutoSize = true;
            this.lblSearchBarcode.Location = new System.Drawing.Point(12, 153);
            this.lblSearchBarcode.Name = "lblSearchBarcode";
            this.lblSearchBarcode.Size = new System.Drawing.Size(95, 16);
            this.lblSearchBarcode.TabIndex = 10;
            this.lblSearchBarcode.Text = "Barkoda Göre:";
            // 
            // bimOtomasyonDataSet
            // 
            this.bimOtomasyonDataSet.DataSetName = "BimOtomasyonDataSet";
            this.bimOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "Urun";
            this.urunBindingSource.DataSource = this.bimOtomasyonDataSet;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            this.urunIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.Width = 125;
            // 
            // kritikStokDataGridViewTextBoxColumn
            // 
            this.kritikStokDataGridViewTextBoxColumn.DataPropertyName = "KritikStok";
            this.kritikStokDataGridViewTextBoxColumn.HeaderText = "KritikStok";
            this.kritikStokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kritikStokDataGridViewTextBoxColumn.Name = "kritikStokDataGridViewTextBoxColumn";
            this.kritikStokDataGridViewTextBoxColumn.Width = 125;
            // 
            // barkodDataGridViewTextBoxColumn
            // 
            this.barkodDataGridViewTextBoxColumn.DataPropertyName = "Barkod";
            this.barkodDataGridViewTextBoxColumn.HeaderText = "Barkod";
            this.barkodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barkodDataGridViewTextBoxColumn.Name = "barkodDataGridViewTextBoxColumn";
            this.barkodDataGridViewTextBoxColumn.Width = 125;
            // 
            // DepoForm
            // 
            this.ClientSize = new System.Drawing.Size(577, 411);
            this.Controls.Add(this.lblSearchBarcode);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBarcode);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.dgvProducts);
            this.Name = "DepoForm";
            this.Text = "Depo Görevlisi Paneli";
            this.Load += new System.EventHandler(this.DepoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bimOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.TextBox txtSearchBarcode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblSearchBarcode;
        private Bim.BimOtomasyonDataSet bimOtomasyonDataSet;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private Bim.BimOtomasyonDataSetTableAdapters.UrunTableAdapter urunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kritikStokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
    }
}
