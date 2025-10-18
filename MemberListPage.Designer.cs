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
            TurnBack = new Button();
            searchingBox = new TextBox();
            searchingButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUyeler).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUyeler
            // 
            dataGridViewUyeler.ColumnHeadersHeight = 29;
            dataGridViewUyeler.Location = new Point(50, 50);
            dataGridViewUyeler.MultiSelect = false;
            dataGridViewUyeler.Name = "dataGridViewUyeler";
            dataGridViewUyeler.ReadOnly = true;
            dataGridViewUyeler.RowHeadersWidth = 51;
            dataGridViewUyeler.Size = new Size(1800, 900);
            dataGridViewUyeler.TabIndex = 0;
            // 
            // TurnBack
            // 
            TurnBack.Location = new Point(50, 16);
            TurnBack.Name = "TurnBack";
            TurnBack.Size = new Size(40, 29);
            TurnBack.TabIndex = 1;
            TurnBack.Text = "<";
            TurnBack.UseVisualStyleBackColor = true;
            TurnBack.Click += TurnBack_Click;
            // 
            // searchingBox
            // 
            searchingBox.Location = new Point(119, 16);
            searchingBox.Name = "searchingBox";
            searchingBox.PlaceholderText = "Üye...";
            searchingBox.Size = new Size(345, 27);
            searchingBox.TabIndex = 2;
            // 
            // searchingButton
            // 
            searchingButton.Location = new Point(482, 16);
            searchingButton.Name = "searchingButton";
            searchingButton.Size = new Size(42, 27);
            searchingButton.TabIndex = 3;
            searchingButton.Text = "🔍";
            searchingButton.UseVisualStyleBackColor = true;
            searchingButton.Click += searchingButton_Click;
            // 
            // MemberListPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(searchingButton);
            Controls.Add(searchingBox);
            Controls.Add(TurnBack);
            Controls.Add(dataGridViewUyeler);
            Name = "MemberListPage";
            Size = new Size(1900, 1000);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUyeler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUyeler;
        private Button TurnBack;
        private TextBox searchingBox;
        private Button searchingButton;
    }
}