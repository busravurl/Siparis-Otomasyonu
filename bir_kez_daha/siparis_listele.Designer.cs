namespace bir_kez_daha
{
    partial class siparis_listele
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sipariş_otomasyonDataSet6 = new bir_kez_daha.Sipariş_otomasyonDataSet6();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sipariş_otomasyonDataSet5 = new bir_kez_daha.Sipariş_otomasyonDataSet5();
            this.ordersTableAdapter = new bir_kez_daha.Sipariş_otomasyonDataSet5TableAdapters.OrdersTableAdapter();
            this.ordersTableAdapter1 = new bir_kez_daha.Sipariş_otomasyonDataSet6TableAdapters.OrdersTableAdapter();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıtemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pieceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.shippingWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topShippingWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipariş_otomasyonDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipariş_otomasyonDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.ıtemIdDataGridViewTextBoxColumn,
            this.pieceDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewCheckBoxColumn,
            this.shippingWeightDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.topShippingWeightDataGridViewTextBoxColumn,
            this.topPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(944, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.sipariş_otomasyonDataSet6;
            // 
            // sipariş_otomasyonDataSet6
            // 
            this.sipariş_otomasyonDataSet6.DataSetName = "Sipariş_otomasyonDataSet6";
            this.sipariş_otomasyonDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.sipariş_otomasyonDataSet5;
            // 
            // sipariş_otomasyonDataSet5
            // 
            this.sipariş_otomasyonDataSet5.DataSetName = "Sipariş_otomasyonDataSet5";
            this.sipariş_otomasyonDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "Sipariş Numarası";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıtemIdDataGridViewTextBoxColumn
            // 
            this.ıtemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.ıtemIdDataGridViewTextBoxColumn.HeaderText = "Ürün Kodu";
            this.ıtemIdDataGridViewTextBoxColumn.Name = "ıtemIdDataGridViewTextBoxColumn";
            this.ıtemIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pieceDataGridViewTextBoxColumn
            // 
            this.pieceDataGridViewTextBoxColumn.DataPropertyName = "piece";
            this.pieceDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.pieceDataGridViewTextBoxColumn.Name = "pieceDataGridViewTextBoxColumn";
            this.pieceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Sipariş Tarihi";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderStatusDataGridViewCheckBoxColumn
            // 
            this.orderStatusDataGridViewCheckBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewCheckBoxColumn.HeaderText = "Sipariş Durumu";
            this.orderStatusDataGridViewCheckBoxColumn.Name = "orderStatusDataGridViewCheckBoxColumn";
            this.orderStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // shippingWeightDataGridViewTextBoxColumn
            // 
            this.shippingWeightDataGridViewTextBoxColumn.DataPropertyName = "shippingWeight";
            this.shippingWeightDataGridViewTextBoxColumn.HeaderText = "Kargo Ağırlığı";
            this.shippingWeightDataGridViewTextBoxColumn.Name = "shippingWeightDataGridViewTextBoxColumn";
            this.shippingWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // topShippingWeightDataGridViewTextBoxColumn
            // 
            this.topShippingWeightDataGridViewTextBoxColumn.DataPropertyName = "topShippingWeight";
            this.topShippingWeightDataGridViewTextBoxColumn.HeaderText = "Toplam Kargo Ağırlığı";
            this.topShippingWeightDataGridViewTextBoxColumn.Name = "topShippingWeightDataGridViewTextBoxColumn";
            this.topShippingWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // topPriceDataGridViewTextBoxColumn
            // 
            this.topPriceDataGridViewTextBoxColumn.DataPropertyName = "topPrice";
            this.topPriceDataGridViewTextBoxColumn.HeaderText = "Toplam Fiyat";
            this.topPriceDataGridViewTextBoxColumn.Name = "topPriceDataGridViewTextBoxColumn";
            this.topPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparis_listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bir_kez_daha.Properties.Resources.b83ffb5a6b74b5ef38c6ce2a640ee956;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "siparis_listele";
            this.Text = "Sipariş Listeleme";
            this.Load += new System.EventHandler(this.siparis_listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipariş_otomasyonDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipariş_otomasyonDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Sipariş_otomasyonDataSet5 sipariş_otomasyonDataSet5;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Sipariş_otomasyonDataSet5TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private Sipariş_otomasyonDataSet6 sipariş_otomasyonDataSet6;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private Sipariş_otomasyonDataSet6TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıtemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn orderStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topShippingWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topPriceDataGridViewTextBoxColumn;
    }
}