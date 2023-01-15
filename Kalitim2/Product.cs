using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim2
{
    internal class Product : BaseClass
    {
        private decimal _sellPrice;
        private decimal _buyPricee;
        private decimal _campaignPrice;
        public decimal SellPrice
        {
            get
            { return _sellPrice; }
            set
            {
                if (value > BuyPrice)
                {
                    _sellPrice = value;

                }
                else
                {
                    Console.WriteLine("Yanlış değer girdin kanka");

                }
            }
        }

        // SellPrice > BuyPrice
        public decimal BuyPrice
        {
            get { return _buyPricee; }
            set
            {
                if (SellPrice > value)
                {
                    _buyPricee = value;

                }
                else
                {
                    Console.WriteLine("Yanlış değer girdin kanka");

                }
            }
        } // 
        public decimal CampaignPrice
        {
            get { return _campaignPrice; }
            set
            {
                if (value > 0)
                {
                    _campaignPrice = value;

                }
                else
                {
                    Console.WriteLine("Yanlış değer girdin kanka");

                }
            }

        }


        public string Brand { get; set; } // belirtmiş oldugumuz markalar içerisinde ürün eklenebilsin
        public string Model { get; set; }
    }
}
