using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PartialClass
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAdress { get; set; }

        public int NewRegist(Customer c)
        {
            Console.WriteLine("Database işlemi tamamlandı");
            return 3;
        }
        public int DeleteRegistration(int id)
        {
            Console.WriteLine("Kayıt Silindi");
            return 1;
        }

        public int FixRegistration(Customer c)
        {
            Console.WriteLine("Müşteri Kayıt düzenlendi");
            return 2;
        }

       

    }
}
