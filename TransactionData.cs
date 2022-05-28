using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class TransactionData
    {
        public int TransactionId { get; set; }
        public int SellerId { get; set; }
        public int ProductId { get; set; }
        public int BuyerId { get; set; }
        public int PriceOfProduct { get; set; }
        public int QuantityOfProduct { get; set; }
        public DateTime SaleDate { get; set; }


        public TransactionData(int id, int sid,int productId,int buyerid,int price, int quantity,DateTime saledate)
        {
            this.TransactionId = id;
            this.SellerId = sid;
            this.ProductId = productId;
            this.BuyerId = buyerid;
            this.PriceOfProduct = price;
            this.QuantityOfProduct = quantity;
            this.SaleDate = saledate;

        }
      
    }
}
