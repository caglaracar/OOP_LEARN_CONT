using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_1
{
    internal class BaseType
    {
        public int Id { get; set; }
        public string ReferenceCode { get; set; }
        public string TCKN { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int cinsiyet { get; set; }
        public DateTime RegisterDate { get; set; }
        public int UpdateUser { get; set; }
        public bool deleted { get; set; }

        public BaseType()
        {
            Console.WriteLine("BaseType Instance's CTOR invoked and ran! ");
            IdGenerator();

        }

        private void IdGenerator()
        {
            Random rnd = new Random();
            this.Id=rnd.Next(1000, 10000);
        }

        public void BaseType1()
        {
            Console.WriteLine("Temel tip => Metot 1");

            //BaseTypeMethod2(); buradan çağırabilirsin knk
        }
        protected void BaseTypeMethod2()
        {
            Console.WriteLine("Protected metodum");
        }
    }
}
