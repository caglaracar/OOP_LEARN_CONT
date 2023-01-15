namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseClass B1 = new BaseClass(DateTime.Now, DateTime.Now);
            Customer c1 = new Customer();
            c1.Test();
            c1.TestAbstract();

            SuperCustoemr sp1 = new SuperCustoemr();
            sp1.TestAbstract();
             
        }
    }
}