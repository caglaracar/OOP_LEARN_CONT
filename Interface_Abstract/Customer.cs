using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract
{
    internal class Customer : BaseClass
    {
        public int id { get; set; }
        public Customer(int id) base(registerTime, updatedTime)
        {
            this.id = id;
        }

        public Customer(DateTime registerTime, DateTime updatedTime) : base(registerTime, updatedTime)
        {
        }
    }
}
