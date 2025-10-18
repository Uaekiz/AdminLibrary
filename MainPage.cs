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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        public void ShowPage(UserControl page, string title)
        {
            PanelContainer.Dock = DockStyle.Fill;
            PanelContainer.Controls.Clear();      // Paneli temizle
            page.Dock = DockStyle.Fill;           // Paneli doldur
            PanelContainer.Controls.Add(page);    // UserControl’ü ekle
            this.Text = title;                    // Form başlığını ayarla
        }

        private void ShowMainMenu()
        {
            PanelContainer.Controls.Clear(); // İçerik panelini temizle
            PanelContainer.Dock = DockStyle.None; // Paneli doldurmayı durdur
            this.Text = "Ana Sayfa";        // Form başlığını eski haline getir
        }



        private void memberlist_Click(object sender, EventArgs e)
        {
            MemberListPage memberList = new MemberListPage();
            memberList.BackButtonClicked += (s, args) => ShowMainMenu();
            ShowPage(memberList, "Üye Listesi");
        }

        private void booklist_Click(object sender, EventArgs e)
        {
            BookListPage bookList = new BookListPage();
            bookList.BackButtonClicked += (s, args) => ShowMainMenu();
            ShowPage(bookList, "Kitap Listesi");
        }
    }
}