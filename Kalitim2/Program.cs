namespace Kalitim2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer C1 = new Computer()
            {
                //Id = 1, // ID değeri girilmesin  set edilemesin
                Brand="MSI",
                Model="GE 63",
                CPU="İ7 8750H",
                GPU="RTX 3070",
                RAM="32 GB",
                SellPrice = 2000M,
                BuyPrice = 1700M,
                CampaignPrice=1850M,
                Barcode="14521#sda2"

            };
            VirtualDB.AddNewProduct(C1);

            Computer C2 = new Computer()
            {
               
                Brand = "MSI",
                Model = "Gf75 THIN",
                CPU = "İ7 10750H",
                GPU = "RTX 3080",
                RAM = "64 GB",
                SellPrice = 2750M,
                BuyPrice = 2300M,
                CampaignPrice = 2550M,
                Barcode = "312DSA#sda2"

            };
        }
    }
}