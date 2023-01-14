using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class Product
    {
        public string ProductId { get; set; }
        public string definition { get; set; }
        public decimal fiyat { get; set; }
        public Product()
        {
            Console.WriteLine("Product yapıcı metot calıstı");

        }
        public void ProductTestMethod()
        {
            Console.WriteLine("ProductTestMethod çalıştı");
        }
    }

}
