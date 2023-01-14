using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Nedir_3_Encapsulation
{
    internal class Customer
    {
        public Customer()
        {
            this.id = IdGenerator();
        }
        private string emailAdres;
        private int id;
        public int Id
        {
            get
            {
                return this.id;
            }
            private set { }

        }

        public string EmailAdres
        {
            get
            {
                return this.emailAdres;
            }
            set
            {
                this.emailAdres = value;
            }
        }

        private int IdGenerator()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 10000);

        }
    }
}
