using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNedir_2
{
    internal class Personel
    {
        public static string domainAdress = "piedpier.com";
        public string Name { get; set; }
        public string Surname { get; set; }

        private string emailAdress;

        public string EmailAdress 
        {
            get { return this.emailAdress; }
            set { emailAdress = value.ToLower() +"@"+ domainAdress; }
        }

        public int Cinsiyet { get; set; }


    }
}
