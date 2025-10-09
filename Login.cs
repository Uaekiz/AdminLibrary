using AdminKütüphane.Classes;
using AdminKütüphane.DAL;
using System.Windows.Forms;
namespace AdminKütüphane
{
    public partial class Login : Form
    {
        private Admin admin;
        private int counter = 0;


        public Login()
        {
            InitializeComponent();

            // YENİ KOD BAŞLANGICI: Sadece Repository sınıfını çağırıyoruz
            AdminRepository repository = new AdminRepository();
            try
            {
                this.admin = repository.GetAdminCredentials();
            }
            catch (FileNotFoundException ex)
            {
                // Dosya bulunamazsa kullanıcıya bildir ve uygulamayı kapat
                MessageBox.Show(ex.Message, "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Application.Exit() veya Formu kapatmak yerine, burada uygulamanın açılmasını engelleriz.
                // Program.cs'deki mantık zaten bu form kapanınca tüm uygulamayı kapatıyor.
                // Eğer bu form DialogResult.OK dönmezse, MainPage açılmaz.
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
            catch (Exception ex)
            {
                // Diğer kritik hataları bildir
                MessageBox.Show("Sistem yöneticisi bilgileri yüklenirken beklenmedik bir hata oluştu:\n" + ex.Message, "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
            // YENİ KOD BİTİŞİ


        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string id = idinput.Text;
            string password = passwordinput.Text;
            int ID;

            if (int.Parse(id) == 1 && password == "")
            {
                // Geliştirici modu
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            if (counter >= 3)
            {
                MessageBox.Show("Maksimum giriş denemesine ulaştınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close(); // Formu kapatır, uygulama Form1 ana form ise program kapanır
                return;
            }

            if (string.IsNullOrEmpty(id))
            {
                idinput.BackColor = Color.LightPink;
                Alert.Text = "Lütfen ID alanını boş bırakmayınız!";
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                passwordinput.BackColor = Color.LightPink;
                Alert.Text = "Lütfen şifre alanını boş bırakmayınız!";
                return;
            }

            if (!int.TryParse(id, out ID) || !admin.SifreKontrol(password) || !admin.IdKontrol(ID))
            {
                Alert.Text = "Hatalı giriş yaptınız! Lütfen tekrar deneyiniz.";
                passwordinput.BackColor = Color.LightPink;
                idinput.BackColor = Color.LightPink;
                //passwordinput.Clear();
                //idinput.Clear();
                counter++;
                return;
            }
            else 
            {
                // Login başarılı → Program.cs'de MainPage açılacak
                this.DialogResult = DialogResult.OK;
                this.Close(); // LoginForm kapanır 
                return;
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
