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
            dataGridViewKitaplar.CellFormatting += dataGridViewKitaplar_CellFormatting;
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

        private void dataGridViewKitaplar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Sadece satırların verisi bağlandıktan sonra çalışmasını sağla
            if (e.RowIndex >= 0 && dataGridViewKitaplar.Rows[e.RowIndex].DataBoundItem is Kitap kitap)
            {
                // Kitap nesnesindeki 'Bulunma' özelliğini kontrol et
                if (!kitap.Bulunma) // Eğer kitap bulunmuyorsa (false ise)
                {
                    // Tüm satırın arka plan rengini LightCoral yap
                    dataGridViewKitaplar.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    // İsteğe bağlı: Durum sütunundaki metni de değiştirebilirsin
                    if (dataGridViewKitaplar.Columns[e.ColumnIndex].DataPropertyName == "Bulunma")
                    {
                        e.Value = "Ödünç Verildi"; // Boolean yerine metin göster
                        e.FormattingApplied = true; // Değeri bizim ayarladığımızı belirt
                    }
                }
                else // Eğer kitap bulunuyorsa (true ise)
                {
                    // Tüm satırın arka plan rengini LightGreen yap
                    dataGridViewKitaplar.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    // İsteğe bağlı: Durum sütunundaki metni de değiştirebilirsin
                    if (dataGridViewKitaplar.Columns[e.ColumnIndex].DataPropertyName == "Bulunma")
                    {
                        e.Value = "Mevcut"; // Boolean yerine metin göster
                        e.FormattingApplied = true; // Değeri bizim ayarladığımızı belirt
                    }
                }
            }
            // Eğer satır veriye bağlı değilse (örn. yeni eklenen boş satır), rengi varsayılan yap
            else if (e.RowIndex >= 0)
            {
                dataGridViewKitaplar.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Window;
            }
        }

        private void searchingButton_Click(object sender, EventArgs e)
        {
            var searchingBook = _kitapManager.FindKitap(searchingBox.Text.Trim());
            if (searchingBook != null)
            {
                dataGridViewKitaplar.DataSource = searchingBook;
            }
            else
            {
                // Eğer arama kutusu boşsa veya sonuç bulunamazsa, tüm kitapları göster
                dataGridViewKitaplar.DataSource = _kitapManager.GetTumKitaplar();
            }
        }

        
    }
}
