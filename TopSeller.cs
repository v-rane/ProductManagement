using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class TopSeller
    {
        public TopSeller() { }
        public int sellerId { get; set; }
        public string sellerName { get; set; }
        public int sellerIdCount { get; set; }
        public TopSeller(int id, string name,int count)
        {
            this.sellerId = id;
            this.sellerName = name;
            this.sellerIdCount = count;
        }
    }
}
