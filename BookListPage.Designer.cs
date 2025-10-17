namespace AdminKütüphane
{
    partial class BookListPage
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewKitaplar = new DataGridView();
            TurnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.ColumnHeadersHeight = 29;
            dataGridViewKitaplar.Location = new Point(50, 50);
            dataGridViewKitaplar.MultiSelect = false;
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.ReadOnly = true;
            dataGridViewKitaplar.RowHeadersWidth = 51;
            dataGridViewKitaplar.Size = new Size(1800, 900);
            dataGridViewKitaplar.TabIndex = 1;
            // 
            // TurnBack
            // 
            TurnBack.Location = new Point(50, 16);
            TurnBack.Name = "TurnBack";
            TurnBack.Size = new Size(40, 29);
            TurnBack.TabIndex = 2;
            TurnBack.Text = "<";
            TurnBack.UseVisualStyleBackColor = true;
            // 
            // BookListPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TurnBack);
            Controls.Add(dataGridViewKitaplar);
            Name = "BookListPage";
            Size = new Size(1900, 1000);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewKitaplar;
        private Button TurnBack;
    }
}
