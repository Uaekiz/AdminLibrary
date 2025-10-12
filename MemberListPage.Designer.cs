namespace AdminKütüphane
{
    partial class MemberListPage
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
            dataGridViewUyeler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUyeler).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUyeler
            // 
            dataGridViewUyeler.ColumnHeadersHeight = 29;
            dataGridViewUyeler.Location = new Point(50, 50);
            dataGridViewUyeler.Name = "dataGridViewUyeler";
            dataGridViewUyeler.ReadOnly = true;
            dataGridViewUyeler.RowHeadersWidth = 51;
            dataGridViewUyeler.Size = new Size(1800, 900);
            dataGridViewUyeler.TabIndex = 0;
            // 
            // MemberListPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(dataGridViewUyeler);
            Name = "MemberListPage";
            Size = new Size(1900, 1000);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUyeler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUyeler;
    }
}