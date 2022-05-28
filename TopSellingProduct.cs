using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class TopSellingProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductIdCount { get; set; }
        public TopSellingProduct(){ }
        public TopSellingProduct(int productId,string productName, int ProductIdCount)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.ProductIdCount = ProductIdCount;

        }
        
    }
}
