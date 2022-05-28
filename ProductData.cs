using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class ProductData
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public ProductData(int Pid,string Pname)
        {
            this.ProductId = Pid;
            this.ProductName = Pname;
        }
    }
}
