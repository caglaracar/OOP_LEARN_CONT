using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class CustomerAdress
    {
    
      
        public string Adresstype { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Adress { get; set; }

        public CustomerAdress()
        {
            Console.WriteLine("CustomerAdress Yapıcı metot calıstı");
        }
        public void CustomerAdressTestMethod()
        {
            Console.WriteLine("CustomerAdressTestMethod Calıstı");
        }
    }
}
