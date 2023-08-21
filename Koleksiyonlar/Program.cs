using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "ali", "veli", "gamze","yaprak" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            ////oluşturduğumuz diziye bu veritabanından filan gelir buna yeni biz eleman eklediğimiz zaman
            ////aşağıdaki gibi ekleme yapabliriz ama bu sefer de 0. elemanı çağırırsak mesala gelir ama boş gelir.
            ////bu yüzden de koleksiyonları kullanırız. List 
            //isimler = new string[5];//isimler dizisini 5 elemana yükselttik
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "ali","veli","gamze","yaprak"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            //Yani koleksiyonlarda arraylar gibi eklediğimizde bozulmaması için altyapı var.


        }
    }
}
