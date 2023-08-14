using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string UrunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] Meyveler = new string[] { "vxc","zxcz" };

            Urun urun1 = new Urun(); //class ın örneği demek 
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var a in urunler) 
            {
                Console.WriteLine(a.Adi);
                Console.WriteLine(a.Fiyati);
                Console.WriteLine(a.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("----------Metodlar----------");

            //instance-class örneği oluşturuyoruz.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); //metod çağırdık metod bana  tekrar tekrar aynı şeyi kullanabilme imkanını verdi
            sepetManager.Ekle(urun2); //SepetManager de tip olarak Urun u tanımladığımız için urun1 ve urun2 yi yolladık
            sepetManager.Ekle2("Armut","Yeşil Armut",12,9);
            sepetManager.Ekle2("Elma","Yeşil Elma",12,8);
            sepetManager.Ekle2("Karpuz","Diyarbakır Karpuzu",12,5);



        }
    }
}
//Methodlar bizim için tekrar tekrar kullanılmasını sağlayan kod bloklarıdır.