using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PartialClass
{
    internal partial class Student
    {
      public int NewRegist(Student s)
        {
            Console.WriteLine("Ogrenci Kayıt işlemi başarılı");
            return 1;
        }

        public int DeleteRegistration(int id)
        {
            Console.WriteLine("Ogrenci Kayıt Silindi");
            return 1;
        }

        public int FixRegistration(Student s)
        {
            Console.WriteLine("Ogrenci Kayıt düzenlendi");
            return 2;
        }
    }
}
