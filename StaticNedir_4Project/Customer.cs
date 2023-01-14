using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNedir_3Project
{
    internal class Customer
    {
        static ArrayList customerDatabase;

        #region field


        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string emailAdress { get; set; }

        public string Password { get; set; }

        #endregion
        #region encapsulation
        private string userName;
        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                bool controlUserName = isValidUserName(value);
                if (controlUserName)
                {
                    Console.WriteLine("Müşteri kayıtlı - set blogu");

                    this.userName = string.Empty;
                }
                else
                {
                    this.userName = value;
                }
            }
        }
        #endregion
        #region static constructor
        static Customer()
        {
            customerDatabase = new ArrayList();

        }

        #endregion


        #region static Methods
        public static bool isValidUserName(string _userName)
        {
            bool control = false;

            for (int i = 0; i < customerDatabase.Count; i++)
            {
                Customer Temp = (Customer)customerDatabase[i];
                if (Temp.userName == _userName)
                {
                    control = true;
                    break;
                }
            }
            return control;


        }

        public static void AddCustomer(Customer c)
        {
            if (c != null && !string.IsNullOrEmpty(c.emailAdress) && !string.IsNullOrEmpty(c.userName))
            {
                customerDatabase.Add(c);
                Console.WriteLine("Müşteri eklendi");
            }
            else
            {
                Console.WriteLine("Müşteri kayıtlı");
            }
        }

        static bool isValidEmailAdress(string _emailAdress)
        {
            bool control = false;
            for (int i = 0; i < customerDatabase.Count; i++)
            {
                Customer Temp = (Customer)customerDatabase[i];
                if (Temp.emailAdress == _emailAdress)
                {
                    control = true;
                    break;
                }
            }
            return control;
        }


        #endregion



    }
}
