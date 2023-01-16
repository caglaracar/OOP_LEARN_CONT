namespace Enum_s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.CustomerId = 1;
            C1.CustomerNumber = "cglr001";
            C1.Name = "Caglar";
            C1.Surname = "acar";
            C1.EmailAdress = "caglaracar@gmail.com";

            VirtualDB VDB = new VirtualDB();
            CustomerReturnValue crv=VDB.NewRegistCustomer(C1);

            if(crv==CustomerReturnValue.registrationSuccessful)
            {
                Console.WriteLine("Kayıt başarılı");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız");
            }


        }
    }
}