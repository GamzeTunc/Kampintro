using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun) //bir yerde normal parantez görürseniz orda metot çalışıyor demektir.
            //ürün eklerken onun bilgilerine ulaşabilmem lazım Urun clasının tipinde urun diye parametre ekledik.
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : "+urun.Adi); //bana gönderilen ürünün ismini
        }
        public void Ekle2(string urunAdi,string Aciklama,double fiyat,int stokAdeti)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + urunAdi);
        }
    }
}
//Sonunda manager controller filan varsa cs dosyasında içinde bir operasyon tutuyor demektir.
//cs c# tan geliyor onun bir c# projesi old anlıyoruz.