using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    internal class Customer
    {
        #region tekil

        public int CustomerId { get; set; }
        public string TCKN { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime createdTime { get; set; }
        public string UserNameId { get; set; }

        #endregion

        #region Inner Type gerektiren fieldlar
        //public string AdressType { get; set; }
        //public string City { get; set; }
        //public string Town { get; set; }
        //public string Adress { get; set; }
        public CustomerAdress[] customerAdressList;
        public CustomerCommunication[] CustomerCommunicationList;
        public CustomerOrderDetail[] CustomerOrderDetailList;

        public Customer()
        {
            customerAdressList = new CustomerAdress[5];
            CustomerCommunicationList = new CustomerCommunication[3];
            CustomerOrderDetailList = new CustomerOrderDetail[10];
        }
        #endregion
    }
}
