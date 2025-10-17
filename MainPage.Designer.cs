namespace AdminKütüphane
{
    partial class MainPage
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
            welcome = new Label();
            memberlist = new Button();
            booklist = new Button();
            PanelContainer = new Panel();
            SuspendLayout();
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.Font = new Font("Segoe UI", 25F);
            welcome.ForeColor = SystemColors.ControlDarkDark;
            welcome.Location = new Point(950, 9);
            welcome.Name = "welcome";
            welcome.Size = new Size(285, 57);
            welcome.TabIndex = 0;
            welcome.Text = "HOŞGELDİNİZ";
            // 
            // memberlist
            // 
            memberlist.Location = new Point(152, 121);
            memberlist.Name = "memberlist";
            memberlist.Size = new Size(250, 150);
            memberlist.TabIndex = 1;
            memberlist.Text = "Üye Listesi";
            memberlist.UseVisualStyleBackColor = true;
            memberlist.Click += memberlist_Click;
            // 
            // booklist
            // 
            booklist.Location = new Point(509, 121);
            booklist.Name = "booklist";
            booklist.Size = new Size(250, 150);
            booklist.TabIndex = 2;
            booklist.Text = "Kitap Listesi";
            booklist.UseVisualStyleBackColor = true;
            booklist.Click += booklist_Click;
            // 
            // PanelContainer
            // 
            PanelContainer.BackColor = Color.Transparent;
            PanelContainer.Location = new Point(1872, 942);
            PanelContainer.Name = "PanelContainer";
            PanelContainer.Size = new Size(10, 10);
            PanelContainer.TabIndex = 3;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1882, 953);
            Controls.Add(PanelContainer);
            Controls.Add(booklist);
            Controls.Add(memberlist);
            Controls.Add(welcome);
            Name = "MainPage";
            Text = "Ana Sayfa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome;
        private Button memberlist;
        private Button booklist;
        private Panel PanelContainer;
    }
}