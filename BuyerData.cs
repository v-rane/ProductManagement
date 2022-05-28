using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class BuyerData
    {
        public int BuyerId { get; set; }
        public string BuyerName { get; set; }
        public string BuyerLocation { get; set; }

        public BuyerData(int id,string name,string location)
        {
            this.BuyerId = id;
            this.BuyerName = name;
            this.BuyerLocation = location;
        }
    }
}
