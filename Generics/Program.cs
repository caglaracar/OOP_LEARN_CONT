namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic giriş
            // <T> : T tipi demek .net framework içerisinde olan veya bizim oluşturdugumuz herhangi bir tip demektir...!!
            List<int> ListGeneric = new List<int>();
            ListGeneric.Add(26);
            ListGeneric.Add(27);
            ListGeneric.Add(28);
            ListGeneric.Add(29);
            ListGeneric.Add(30);

            List<string> ListGenericString = new List<string>();
            ListGenericString.Add("acar");
            ListGenericString.Add("ccc");
            ListGenericString.Add("aaa");
            ListGenericString.Add("bbb");
            ListGenericString.Add("ddd");

            #endregion
            #region Generic Sınıf Tipi
            List<Customer> customers = new List<Customer>();

            // uzun yoldan eleman ekleme
            Customer customer1 = new Customer();
            customer1.Id = 123;
            customer1.Name = "gilfoyle";
            customer1.Surname = "bertram";

            customers.Add(customer1);

            // veya hızlı nesne olusuturma işlemiyle yapabilirsin işlemleri
            customers.Add(new Customer() { Id = 1, Name = "Caglar", Surname = "Acar" });
            customers.Add(new Customer() { Id = 2, Name = "Burak", Surname = "erşen" });
            customers.Add(new Customer() { Id = 3, Name = "Burhan", Surname = "Taşkesen" });
            customers.Add(new Customer() { Id = 4, Name = "Said", Surname = "agaga" });

            foreach (Customer item in customers)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Surname}");

            }
            #endregion





            #region Generic  AddRange metodu + diğer özellikler
            int[] myNums = { 1, 2, 3, 4, 5, 6 };
            List<int> MyNumberList = new List<int>();
            MyNumberList.AddRange(myNums);

            // print
            foreach (var item in MyNumberList)
            {
                Console.WriteLine(item);
            }


            MyNumberList.Insert(3, 100);


            //------------------------------------------------
            int capacity = MyNumberList.Capacity;
            int count = MyNumberList.Count;
            MyNumberList.TrimExcess();
            Console.WriteLine($"capacity : {capacity} count:  {count}");

            MyNumberList.ForEach(item => Console.WriteLine(item));
            // ikiside aynı şey
            foreach (int item in MyNumberList)
            {
                Console.WriteLine(item);
            }



            bool kontrol1 = MyNumberList.Any(item => item > 5);
            Console.WriteLine(kontrol1);

            MyNumberList.Sort();
            MyNumberList.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("*");
            MyNumberList.Reverse();
            MyNumberList.ForEach(item => Console.WriteLine(item));

            MyNumberList.RemoveAll(item => item > 25);
            Console.WriteLine("*");
            MyNumberList.Sort();

            MyNumberList.ForEach(item => Console.WriteLine(item));

            #endregion

            #region bazı function's
            int enBuyukDeger = MyNumberList.Max();
            int enKucukDeger = MyNumberList.Min();
            int toplamDeger = MyNumberList.Sum();
            Console.WriteLine(enBuyukDeger);
            Console.WriteLine(enKucukDeger);
            Console.WriteLine(toplamDeger);
            #endregion


            #region CustomerGenericClass

            CustomerGeneric<int> cg1 = new CustomerGeneric<int>()
            {
                Id = 1,
                Name = "caglar",
                Surname = "acar",
                

            };
            cg1.TakeCustomerNumber();

            CustomerGeneric<Guid> cg2 = new CustomerGeneric<Guid>();
            cg2.TakeCustomerNumber();

            #endregion
        }
    }
}