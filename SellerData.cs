using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class SellerData
    {
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public string SellerLocation { get; set; }
       
        public SellerData(int id, string sellerName,string location)
        {
            this.SellerId = id;
            this.SellerName = sellerName;
            this.SellerLocation = location;
        }
    }
}
