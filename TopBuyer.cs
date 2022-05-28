using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class TopBuyer
    {
        public int BuyerId { get; set; }
        public string BuyerName { get; set; }
        public int BuyerIdCount { get; set; }

        public TopBuyer(){}
        public TopBuyer(int buyerId , string buyerName, int idCount)
        {
            this.BuyerId = buyerId;
            this.BuyerName = buyerName;
            this.BuyerIdCount = idCount;
        }

    }
}
