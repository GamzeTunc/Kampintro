using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //birşeyleri tekrar etmesi için kullaılır
            //1 den başla; bu şart geçerli old sürece çalış; i yi bir artır
            //i sayaç oluyor



            //for (int i = 1; i <= 10; i=i+2)
            //{
            //    Console.WriteLine(i);
            //}


            string kurs1 = "Yazılım Geliştirici Yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "java";

            //array - dizi
            //GERÇEK HAYATTA KULLANIŞI=string[] kurslar=kurslariGetir();kurslariGetir() bu array yani veri kaynağından geliyor.
            // böyle tek tek tanımlarsak console.writeline yazmamız gerekliydi, bu yüzden liste halinde tutup döngü kurarız o bizim yerimize hepsini yazdırır.
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme kampı", "Programlamaya başlangıç için temel kurs", "Java" };

            // tek tek 
            for (int i = 0; i < 3; i++)  //yada for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            
            foreach (string kurs in kurslar)//Dizilere uygulanır. Tek tek dolaş kurslarda 
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
