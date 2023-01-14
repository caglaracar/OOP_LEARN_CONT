using System.Net.Mail;

namespace StaticNedir_3Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                name = "Caglar",
                surname = "acar",
                emailAdress = "Caglar.acar@gmail.com",
                UserName = "che.acar",
                Password = "14536599"
            };

            Customer.AddCustomer(customer1);

            Customer customer2 = new Customer()
            {
                name = "Caglar",
                surname = "acar",
                emailAdress = "Caglar.acar@gmail.com",
                UserName = "che.acar",
                Password = "14536599"
            };

            Customer.AddCustomer(customer2);

            Customer customer3 = new Customer()
            {
                name = "Caglar",
                surname = "acar",
                emailAdress = "Caglar.acar@gmail.comdasssaa",
                UserName = "che.acarsada",
                Password = "14536599"
            };

            Customer.AddCustomer(customer3);

            Customer customer4 = new Customer()
            {
                name = "Caglar",
                surname = "acar",
                emailAdress = "Caglar.acar@gmail.comdas",
                UserName = "che.acardsada",
                Password = "14536599"
            };

            Customer.AddCustomer(customer4);

            Customer customer5 = new Customer()
            {
                name = "Caglar",
                surname = "acar",
                emailAdress = "Caglar.acar@gmail.com",
                UserName = "che.acar",
                Password = "14536599"
            };

            Customer.AddCustomer(customer5);

        }
    }
}