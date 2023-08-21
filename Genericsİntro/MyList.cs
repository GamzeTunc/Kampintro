using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsİntro
{
    class MyList<T> //<> generic yapı old. belirtir ve içinde yazanda tipini belirtir. bize özel bir type olsun ve T kullanalım.
        //programcı new lerken hangi tip olur derse o olsun istersem T kullanırım.


    {
        T[] items;//classı new lediğimde oluşturmam gerek

        public MyList() //constractor method. Classı bir yerde kullanırsam new lerser otomatik direk çalışır.
        {
            
        }
        public void Add(T item)//item eleman demek 
        {

        }
    }
}
