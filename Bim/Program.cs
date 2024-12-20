using System;
using System.Windows.Forms;

namespace BimOtomasyon
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Uygulamanın başlangıç formu LoginForm olarak ayarlandı
            Application.Run(new LoginForm());
        }
    }
}
