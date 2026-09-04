    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smash_The_Math
{
    public static class GlobalVariables
    {
        // Veritabanı bağlantı cümlesi
        //public static string ConnectionString = @"Data Source=DESKTOP-PR7BV4J\SQLEXPRESS;Initial Catalog=SmashTheMathDB;Integrated Security=True";

        // YENİ BAĞLANTI CÜMLENİZ (Proje İçindeki Dosyaya Bağlanmak İçin)
        public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Veritabani\SmashTheMathDB.mdf;Integrated Security=True";



        // Giriş yapan kullanıcının adı
        public static string KullaniciAdi = string.Empty;
    }
}


