using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //forin key olarak kullanacağız
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //unit price=ürün fiyatı
        public int UnitInStock { get; set; } //ürünün stok adeti

    }
}
