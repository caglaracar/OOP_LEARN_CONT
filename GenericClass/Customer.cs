using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public Guid CustomerNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAdress { get; set; }
        public DateTime BornTime { get; set; }
    }
}
