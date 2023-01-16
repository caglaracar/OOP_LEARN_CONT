using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Customer : ICustomer
    {
        int _customerId;
        string _name;
        string _surname;

        public int CustomerId { get { return _customerId; }  set => _customerId = value; }
        public string Name { get {return _name; } set => _name=value; }
        public string Surname { get { return _surname; } set => _surname = value; }


        public int DeleteRegistration(int id)
        {
            Console.WriteLine("Kayıt Silindi");
            return 1;
        }

        public int FixRegistration(int id, string name, string surname)
        {
            Console.WriteLine("Kayıt düzenlendi");
            return 2;
        }

        public int NewCustomerRegistration(string name, string surname)
        {
            Console.WriteLine("Kayıt eklendi");
            return 3;
        }
    }
}
