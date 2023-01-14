namespace OOP_Nedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer? customer1 = new Customer();
            customer1.Name = "Caglar";
            customer1.Surname = "acar";
            customer1.TCKN = 17735013816;
            customer1.Gender = 1232131;
            Console.WriteLine(customer1.Name);
            Customer? customer2 = customer1;
            Console.WriteLine(customer2.Name);
            customer1.Name = "gilfoyleee";
            Console.WriteLine(customer2.Name);

            customer2 = null;
            customer1 = null;

            customer1.Name = "acar";
            Console.WriteLine(customer1.Name); // null reference exception hatası alır -> Garbage collector alır temizler gösterdiği yeri





        }
    }
}