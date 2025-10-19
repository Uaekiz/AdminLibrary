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

namespace AdminKütüphane.UserControls
{
    public partial class UserDetayPage : UserControl
    {
        public event EventHandler BackButtonClicked;

        public UyeManager _uyeManager;
        public Uye _secilenUye;
        public UserDetayPage(int uyeId)
        {
            InitializeComponent();
            _uyeManager = new UyeManager();
            _secilenUye = _uyeManager.GetElementById(uyeId);
            if (_secilenUye != null)
            {
                // Üye bilgilerini burada kullanabilirsiniz.
                // Örneğin, etiketlere atayabilirsiniz:
                // lblUyeAdi.Text = _secilenUye.UyeAdi;
            }
            else
            {
                MessageBox.Show("Üye bulunamadı.");
            }
        }


        private void TurnBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
