namespace AdminKütüphane
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            idinput = new TextBox();
            passwordinput = new TextBox();
            label3 = new Label();
            Enter = new Button();
            Alert = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 140);
            label1.Name = "label1";
            label1.Size = new Size(29, 18);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 181);
            label2.Name = "label2";
            label2.Size = new Size(46, 18);
            label2.TabIndex = 1;
            label2.Text = "Şifre: ";
            // 
            // idinput
            // 
            idinput.Location = new Point(358, 138);
            idinput.Name = "idinput";
            idinput.Size = new Size(125, 26);
            idinput.TabIndex = 2;
            idinput.TextChanged += idinput_TextChanged;
            // 
            // passwordinput
            // 
            passwordinput.Location = new Point(358, 181);
            passwordinput.Name = "passwordinput";
            passwordinput.PasswordChar = '*';
            passwordinput.Size = new Size(125, 26);
            passwordinput.TabIndex = 3;
            passwordinput.TextChanged += passwordinput_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 107);
            label3.Name = "label3";
            label3.Size = new Size(299, 18);
            label3.TabIndex = 4;
            label3.Text = "Lütfen giriş yapmak için bilglerinizi doldurunuz!";
            // 
            // Enter
            // 
            Enter.BackColor = Color.MediumSpringGreen;
            Enter.Location = new Point(372, 230);
            Enter.Name = "Enter";
            Enter.Size = new Size(94, 26);
            Enter.TabIndex = 5;
            Enter.Text = "Giriş";
            Enter.UseVisualStyleBackColor = false;
            Enter.Click += Enter_Click;
            // 
            // Alert
            // 
            Alert.AutoSize = true;
            Alert.Location = new Point(416, 210);
            Alert.Name = "Alert";
            Alert.Size = new Size(0, 18);
            Alert.TabIndex = 6;
            Alert.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 405);
            Controls.Add(Alert);
            Controls.Add(Enter);
            Controls.Add(label3);
            Controls.Add(passwordinput);
            Controls.Add(idinput);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Giriş Yap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox idinput;
        private TextBox passwordinput;
        private Label label3;
        private Button Enter;
        private Label Alert;
    }
}
