using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class CustomerGeneric<T>
    {
        public T Id { get; set; }
        public T CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public T TakeCustomerNumber()
        {
            return CustomerNumber;
        }
    }
}
