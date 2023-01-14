namespace OOP_Nedir_3_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.EmailAdres = "acar@gmail.com";

        

            Console.WriteLine(customer.Id.ToString());
        }
    }
}