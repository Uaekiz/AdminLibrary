namespace AdminKütüphane
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Ana formu oluştur
            MainPage mainPage = new MainPage();

            // Login formunu modal olarak aç
            using (Login login = new Login())
            {
                // Login başarılıysa ShowDialog() OK döndürsün
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // Ana formu çalıştır
                    Application.Run(mainPage);
                }
                // Eğer login başarısız veya kapandıysa, uygulama hiç açılmaz
            }
        }
    }
}
