using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class GrossMerchandiseValue
    {
        public int TotalPrice { get; set; }

        public GrossMerchandiseValue() { }
        public GrossMerchandiseValue(int totalPrice)
        {
            this.TotalPrice = totalPrice;
        }
    }
}
