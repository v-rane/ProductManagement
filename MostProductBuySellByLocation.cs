using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class MostProductBuySellByLocation
    {
        public string Location { get; set; }
        public int TotalSellForLocation { get; set; }
        public int TotalBuyForLocation { get; set; }
        public MostProductBuySellByLocation() { }
        public MostProductBuySellByLocation(string location, int totalSell, int totalbuy)
        {
            this.Location = location;
            this.TotalSellForLocation = totalSell;
            this.TotalBuyForLocation = totalbuy;
        }

    }
    public class SellByLocation
    {
        public String sellLocation { get; set; }
        public int totalSell { get; set; }

        public SellByLocation() { }
        public SellByLocation(string location ,int totalsell) 
        { 
            this.sellLocation = location;
            this.totalSell = totalsell;   
        }
    }

    public class BuyByLocation
    {
        public String buyLocation { get; set; }
        public int totalbuy { get; set; }

        public BuyByLocation() { }
        public BuyByLocation(string loc, int total)
        {
            this.buyLocation = loc;
            this.totalbuy = total;
        }
    }
}
