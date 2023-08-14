using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type spifity = tip güvenliği
            string KategoriEtiketi = "Kategori";
            bool sistemeGirisYapmisMi = true;


            if(sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
        }
    }
}
