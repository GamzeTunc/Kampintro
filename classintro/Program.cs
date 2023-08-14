using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Gamze";
            int yas = 23;
            //kurs kurs1; //eskiden değişkenimiz stringti şimdi kurs türünde ve aynı zamanda da aslında
            //değişkenimiz kurs içinde birden fazla özellik var. yani 3 ünü birden tutabilen tip tanımladım string gibi int gibi

            Kurs kurs1 = new Kurs(); //kurs gibi bir değişken tanımlıycaksak böyle tanımlarız

            kurs1.KursAdi = "c#";
            kurs1.KursEgitmeni = "Engin Demiroğ";
            kurs1.izlenmeOrani = 10000;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Kerem";
            kurs2.izlenmeOrani =64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.KursEgitmeni = "Berkay";
            kurs3.izlenmeOrani = 80;

            Console.WriteLine(kurs1.KursAdi+" "+kurs1.KursEgitmeni+" "+kurs1.izlenmeOrani);

            //içinde kurs nesnesini barındıran bir array tanımladım
            //kurs tipinde kurslar diye liste-array tanımdım
            //string[] kurslar = new string[] { }; böyle yazarsam içinde string tutarsın 
            //aşağıdaki gibi yazarsan kurslar tutarsın
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (Kurs kurs in kurslar)//kurslari dön düyor kurs1,kurs2,kurs3 dönüyor ve takma isim olan kurs kurs1 oluyor ve onun içindeki kursAdi ni yazıyor
            {
                Console.WriteLine(kurs.KursAdi+" : "+kurs.KursEgitmeni);
            }
            

            
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
