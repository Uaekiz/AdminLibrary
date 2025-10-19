namespace AdminKütüphane.UserControls
{
    partial class UserDetayPage
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
            TurnBack = new Button();
            SuspendLayout();
            // 
            // TurnBack
            // 
            TurnBack.Location = new Point(50, 16);
            TurnBack.Name = "TurnBack";
            TurnBack.Size = new Size(40, 29);
            TurnBack.TabIndex = 3;
            TurnBack.Text = "<";
            TurnBack.UseVisualStyleBackColor = true;
            // 
            // UserDetayPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TurnBack);
            Name = "UserDetayPage";
            Size = new Size(1900, 1000);
            ResumeLayout(false);
        }

        #endregion

        private Button TurnBack;
    }
}
