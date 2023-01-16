using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface ICustomer
    {
        // field 
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        // metot
        int NewCustomerRegistration(string name, string surname);
        int FixRegistration(int id, string name, string surname);
        int DeleteRegistration(int id);

        // delegate

    }
}
