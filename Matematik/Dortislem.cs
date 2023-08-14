using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class Dortislem
    {
        //parametre kısmı sizin metodunuzun ihtiyacı olanlar
        //parametre yaparız çünkü hep aynı sayılar gelmez başka bir sayfada 5ve 6 toplanırken diğerinde 8ve 9 toplanır
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("sonuç: "+ toplam);
        }
    }
}
