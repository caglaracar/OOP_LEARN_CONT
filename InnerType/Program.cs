namespace InnerType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer()
            {
                CustomerId = 1,
                TCKN = "1834232312",
                name = "Caglar",
                surname = "Acar",
                createdTime = DateTime.Now,
                UserNameId = "26"
            };

            //C1.customerAdressList = new CustomeDrAdress[5]; // ctor'da ornekle asla yapma

            C1.customerAdressList[0] = new CustomerAdress()
            {
                City = "Sakarya",
                Town = "Serdivan",
                Adress = "sakarya serdivan kemalpaşa 39a ",
                Adresstype = "İş yeri"

            };

            C1.CustomerOrderDetailList[0] = new CustomerOrderDetail()
            {
                OrderNumber = "1",
                
            };

            C1.CustomerCommunicationList[0] = new CustomerCommunication()
            {
                ActivePassive = true,
                AreaCode = "2626",
                CommunicationType=717,
                Number="255"
            };
            C1.CustomerOrderDetailList[0] = new CustomerOrderDetail()
            {
                OrderNumber = "1"
            };
            C1.customerAdressList[0].CustomerAdressTestMethod();
            C1.CustomerOrderDetailList[0].products[0] = new Product()
            {
                definition = "laptop",
                fiyat = 26322,
                ProductId="21"

            };

        }
    }
}