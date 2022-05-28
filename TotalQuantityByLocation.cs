using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class TotalQuantityByLocation
    {
        public string Location { get; set; }
        public int SellQuantity { get; set; }
        public int BuyQuantity { get; set; }
        public TotalQuantityByLocation() { }
        public TotalQuantityByLocation(string loc, int sell, int buy)
        {
            this.Location = loc;
            this.SellQuantity = sell;
            this.BuyQuantity = buy;
        }

    }
    public class SellCountByLocation
    {
        public int SellQuantity { get; set; }
        public int SellId { get; set; }
        public SellCountByLocation(int quantity , int sid) 
        {
            this.SellQuantity = quantity;
            this.SellId = sid;
        }

        public SellCountByLocation()
        {
        }
    }

    public class buyCountByLocation
    {
        public int BuyQuantity { get; set; }
        public int BuyId{ get; set; }

        public buyCountByLocation(int bQuantity , int bid)
        {
            this.BuyQuantity= bQuantity;
            this.BuyId= bid;
        }

        public buyCountByLocation()
        {
        }
    }
       
}
