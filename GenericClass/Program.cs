namespace GenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Database | uygulama
             * Mssql    | CSharp(c#)
             * 
             * tblCustomer
             * id int
             * customerNo uniqueidentify ( Guid)
             * name nvarchar (string)
             * surname nvarchar (string)
             * bornTime datetime datetime
             * 
             * UnitOfWorks => Generic class | Generic Interface
             */

            GenericRepostiry<Customer> repostiryCustomer = new GenericRepostiry<Customer>();
            IEnumerable<Customer> myCustomers= repostiryCustomer.Getir();

            GenericRepostiry<Product> repostiryProduct = new GenericRepostiry<Product>();
            repostiryProduct.Getir();

            repostiryCustomer.newAddRegist(null);
            repostiryProduct.newAddRegist(null);


        }
    }
}