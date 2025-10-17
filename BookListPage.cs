using AdminKütüphane.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminKütüphane
{
    public partial class BookListPage : UserControl
    {
        private KitapManager _kitapManager;
        public event EventHandler BackButtonClicked;
        public BookListPage()
        {
            InitializeComponent();
            _kitapManager = new KitapManager();
            this.Load += new System.EventHandler(this.BookListPage_Load);
        }

        private void BookListPage_Load(object sender, EventArgs e)
        {
            // 1. İş mantığı katmanından tüm üyeleri çek.
            var tumUyeler = _kitapManager.GetTumKitaplar();

            // 2. DataGridView'in otomatik sütun oluşturmasını kapatıyoruz.
            dataGridViewKitaplar.AutoGenerateColumns = false;

            // 3. Veri kaynağını bağlıyoruz ama henüz ekranda bir şey görünmeyecek.
            dataGridViewKitaplar.DataSource = tumUyeler;

            // 4. Şimdi göstermek istediğimiz sütunları manuel olarak oluşturuyoruz.
            // Bu, hangi verinin hangi başlıkla gösterileceği üzerinde tam kontrol sağlar.

            // "UyeAdi" verisini "Üye Adı Soyadı" başlığıyla gösteren bir sütun ekle.
            dataGridViewKitaplar.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "KitapAdi", // Uye sınıfındaki özelliğin adı
                HeaderText = "Kitap Adı"      // Tabloda görünecek başlık
            });

            // "UyeId" verisini "Üye ID" başlığıyla gösteren bir sütun ekle.
            dataGridViewKitaplar.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "YazarAdi",
                HeaderText = "Yazar Adı"
            });

            // "AlinanKitapSayisi" verisini "Aldığı Kitap Sayısı" başlığıyla gösteren bir sütun ekle.
            dataGridViewKitaplar.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ISBN",
                HeaderText = "ISBN"
            });

            dataGridViewKitaplar.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Bulunma",
                HeaderText = "Bulunma"
            });

            // 5. Sütunların, panelin genişliğine göre otomatik olarak boyutlanmasını sağla.
            dataGridViewKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TurnBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
