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
        //string[] Meyveler = new string[] { "vxc","zxcz" }; bunu tanımlamadan string[] Meyveler; gibi normal dizi oluşturdu 

        public MyList() //constractor method. Classı bir yerde kullanırsam new lerser otomatik direk çalışır.
        {
            items = new T[0]; 
        }
        public void Add(T item)//item eleman demek 
        {
            T[] tempArray = items; //yeni dizi oluşturduk adı geçiciDizi onun içine attık mevcut diziyi eski hali de silinmez bu sayede
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
