namespace OOP_PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.CustomerId = 1;
            C1.Name = "Caglar";
            C1.Surname = "acar";
            C1.EmailAdress = "acar@gmail.com";

            int sonuc=C1.NewRegist(C1);
            if (sonuc > 0)
            {
                Console.WriteLine("Database yeni kayıt eklendi");
            }

            Student student1 = new Student();
            student1.NewRegist(student1);
        }
    }
}