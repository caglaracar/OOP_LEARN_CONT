namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Name = "Gilfoyle";
            C1.Surname = "Bertram";
            C1.CustomerId = 1234;
            Console.WriteLine(C1);

            C1.PrintScreen("mrb");

            BaseClass B1 = new BaseClass();
            B1.PrintScreen("mrb");

            Computer Cmp1 = new Computer();
            Cmp1.PrintScreen("mrb");


        }
    }
}