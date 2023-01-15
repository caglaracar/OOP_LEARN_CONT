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
            foreach (var item in MyNumberList)
            {
                Console.WriteLine(item);
            }

            //------------------------------------------------
            int capacity = MyNumberList.Capacity;
            int count = MyNumberList.Count;
            MyNumberList.TrimExcess();
            Console.WriteLine($"capacity : {capacity} count:  {count}");

            MyNumberList.ForEach(i => Console.WriteLine(i));


            bool kontrol1 = MyNumberList.Any(i => i > 5);
            Console.WriteLine(kontrol1);
            #endregion
        }
    }
}