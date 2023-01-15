using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Customer : BaseClass // FrameWork standart olarak tüm nesleleri objectten türetiyor
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override void PrintScreen(string data)
        {
            Console.WriteLine("Urun=>"+data);
        }

        public override string ToString()
        {
            return $"İsim: {Name} soyisim: {Surname} Id: {CustomerId}";
        }
    }
}
