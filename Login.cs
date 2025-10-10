using AdminKütüphane.Classes;
using AdminKütüphane.DAL;
using System.Windows.Forms;
namespace AdminKütüphane
{
    public partial class Login : Form
    {
        private AdminManager admin;
        private int counter = 0;


        public Login()
        {
            InitializeComponent();

            // YENİ KOD BAŞLANGICI: Sadece Repository sınıfını çağırıyoruz
            admin = new AdminManager();
            
            // YENİ KOD BİTİŞİ


        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string id = idinput.Text;
            string password = passwordinput.Text;

            idinput.BackColor = SystemColors.Window;
            passwordinput.BackColor = SystemColors.Window;

            if (id == "1" && password == "")
            {
                // Geliştirici modu
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            if (counter >= 2)
            {
                MessageBox.Show("Maksimum giriş denemesine ulaştınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Abort;
                this.Close(); // Formu kapatır, uygulama Form1 ana form ise program kapanır
                return;
            }

            var (resultCode, message) = admin.Authenticate(id, password);

            // Gelen sonuca göre UI'ı güncelle
            switch (resultCode)
            {
                case "SUCCESS":
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;

                case "ID_EMPTY":
                    Alert.Text = message;
                    idinput.BackColor = Color.LightPink;
                    break;

                case "PASSWORD_EMPTY":
                    Alert.Text = message;
                    passwordinput.BackColor = Color.LightPink;
                    break;

                case "INVALID_CREDENTIALS":
                case "INVALID_ID_FORMAT":
                    Alert.Text = message;
                    idinput.BackColor = Color.LightPink;
                    passwordinput.BackColor = Color.LightPink;
                    counter++;
                    break;

                case "CRITICAL_ERROR":
                    MessageBox.Show(message, "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                    break;
            }
        }


        private void passwordinput_TextChanged(object sender, EventArgs e)
        {
            passwordinput.BackColor = SystemColors.Window;
        }

        private void idinput_TextChanged(object sender, EventArgs e)
        {
            idinput.BackColor= SystemColors.Window;
        }

    }
}
