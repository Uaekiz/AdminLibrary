using AdminKütüphane.Classes;
using System;
using System.Windows.Forms;

namespace AdminKütüphane
{
    public partial class MemberListPage : UserControl
    {
        private UyeManager _uyeManager;
        public event EventHandler BackButtonClicked;

        public MemberListPage()
        {
            InitializeComponent();
            _uyeManager = new UyeManager();

            this.Load += new System.EventHandler(this.MemberListPage_Load);
        }

        // Bu metot, UserControl yüklendiğinde otomatik olarak çalışır.
        private void MemberListPage_Load(object sender, EventArgs e)
        {
            // 1. İş mantığı katmanından tüm üyeleri çek.
            var tumUyeler = _uyeManager.GetTumUyeler();

            // 2. DataGridView'in otomatik sütun oluşturmasını kapatıyoruz.
            dataGridViewUyeler.AutoGenerateColumns = false;

            // 3. Veri kaynağını bağlıyoruz ama henüz ekranda bir şey görünmeyecek.
            dataGridViewUyeler.DataSource = tumUyeler;

            // 4. Şimdi göstermek istediğimiz sütunları manuel olarak oluşturuyoruz.
            // Bu, hangi verinin hangi başlıkla gösterileceği üzerinde tam kontrol sağlar.

            // "UyeAdi" verisini "Üye Adı Soyadı" başlığıyla gösteren bir sütun ekle.
            dataGridViewUyeler.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UyeAdi", // Uye sınıfındaki özelliğin adı
                HeaderText = "Üye Adı Soyadı"      // Tabloda görünecek başlık
            });

            // "UyeId" verisini "Üye ID" başlığıyla gösteren bir sütun ekle.
            dataGridViewUyeler.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UyeId",
                HeaderText = "Üye ID"
            });

            // "AlinanKitapSayisi" verisini "Aldığı Kitap Sayısı" başlığıyla gösteren bir sütun ekle.
            dataGridViewUyeler.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AlinanKitapSayisi",
                HeaderText = "Aldığı Kitap Sayısı"
            });

            // 5. Sütunların, panelin genişliğine göre otomatik olarak boyutlanmasını sağla.
            dataGridViewUyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void TurnBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void searchingButton_Click(object sender, EventArgs e)
        {
            var searchingUye = _uyeManager.FindUye(searchingBox.Text.Trim());
            if(searchingUye != null)
            {
                dataGridViewUyeler.DataSource = searchingUye;
            }
            else
            {
                // Aranan üye bulunamazsa tüm üyeleri tekrar listele
                dataGridViewUyeler.DataSource = _uyeManager.GetTumUyeler();
            }
        }
    }
}