namespace OOP_Nedir_2_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Console.WriteLine(customer1.TCKN);

            Customer customer2 = new Customer(15452132,"gilfoyle","bertram",321321);
            Console.WriteLine("Müşteri varsa true döner : "+customer2.CustomerControl());   


        }
    }
}