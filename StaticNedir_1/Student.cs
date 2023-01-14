using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNedir_1
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAdress { get; set; }

        public void Test1()
        {
            Console.WriteLine("Nesne örneği alındıktan sonra çalışan metot");
        }

        public static void Test2()
        {
            Console.WriteLine("Nesne örneği alınmadan kullanılabilir");
        }

    }
}
