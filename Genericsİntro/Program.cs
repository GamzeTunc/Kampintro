using System;

namespace Genericsİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList isimler = new MyList(); böyle yazarsam kızar derki ben generic yapıda bir classım
            MyList<string> isimler = new MyList<string>();// ne tipte old söyledim istersen kendi oluşturduğun classı ver tip olarak 
            isimler.Add("Engin");//yukarıda string olunca T de string olarakj kabullenir.

            Console.WriteLine(isimler.Length);

            isimler.Add("Gamze");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

        }
    }
}
