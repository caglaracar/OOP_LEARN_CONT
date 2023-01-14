using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class CustomerCommunication
    {
        public int CommunicationType { get; set; } // 717 : mobil - 718 : sabit hat
        public string Number { get; set; }
        public string AreaCode { get; set; }
        public bool ActivePassive { get; set; }

        public CustomerCommunication()
        {
            Console.WriteLine("CustomerCommunication Yapıcı metot calıstı");

        }
        
        public void CustomerCommunicationTestMethod()
        {
            Console.WriteLine("CustomerCommunicationTestMethod Calıstı");
        }
    }
}
