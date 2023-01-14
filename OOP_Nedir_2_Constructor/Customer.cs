using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Nedir_2_Constructor
{
    internal class Customer
    {
        public long TCKN { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; }

        public Customer(long tCKN, string name, string surname, int gender)
        {
            TCKN = tCKN;
            Name = name;
            Surname = surname;
            Gender = gender;
        }

        public Customer()
        {
            TCKN = 17735013816;
            
            Console.WriteLine("boş ctor oluşturuldu");
        }

        public bool CustomerControl()
        {
            bool control = CustomerControlDatabase("17735013816");
            return control;
        }

        private bool CustomerControlDatabase(string tckn)
        {
            return true;
        }
    }
}
