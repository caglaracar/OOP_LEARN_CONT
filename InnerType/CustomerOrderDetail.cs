using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class CustomerOrderDetail
    {
        public string OrderNumber { get; set; }
        public Product[] products;
       

        public CustomerOrderDetail()
        {
            products = new Product[40];
            Console.WriteLine("CustomerOrderDetail Yapıcı metot calıstı");

        }

        public void CustomerOrderDetailTestMethod()
        {
            Console.WriteLine("CustomerOrderDetailTestMethod Calıstı");
        }
    }
}
