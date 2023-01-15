using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Customer : BaseClass
    {
        public int id { get; set; }
        public Customer()
        {
            id = 1;
        }

        public override void TestAbstract()
        {
            Console.WriteLine("test abstract metodu  override edildi");
        }
    }
}
