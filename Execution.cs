using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class Program
    {
        static void Main(string[] args)
        {
            TransactionDummyData transactionDummyData = new TransactionDummyData();
            List< TransactionData> translist = transactionDummyData.getTransactionData();
            Console.WriteLine("data of transaction is as follows:-");
            foreach (TransactionData data in translist)
            {
                Console.WriteLine(data.TransactionId+" , "+ data.SellerId+ " , "+ data.ProductId+ " , "+data.BuyerId+" , "+ data.PriceOfProduct);
            }
            Console.WriteLine("*******************************************************************************************");

            Console.WriteLine("Seller data is displayed as followed:-");
            SellerDummydata sellerDummydata = new SellerDummydata();
            List<SellerData> sellerList=sellerDummydata.getSellerData();
            foreach(SellerData data in sellerList)
            {
                Console.WriteLine(data.SellerId +" , "+ data.SellerName+ " , "+ data.SellerLocation);
            }
            Console.WriteLine("*********************************************************************************************");

            Console.WriteLine("Product data is displayed as followed:-");
            ProductDummyData productDummyData = new ProductDummyData();
            List<ProductData> productList= productDummyData.getProductData();
            foreach(ProductData data in productList)
            {
                Console.WriteLine(data.ProductId + " , " + data.ProductName);
            }
            Console.WriteLine("***********************************************************************************************");

            Console.WriteLine("Buyer Data is displayed as followed:-");
            BuyerDummyData buyerDummydata = new BuyerDummyData();
            List<BuyerData> buyerList= buyerDummydata.getBuyerData();
            foreach(BuyerData data in buyerList)
            {
                Console.WriteLine(data.BuyerId + " , " + data.BuyerName + " , " + data.BuyerLocation);
            }
             Console.WriteLine("**********************************************************************************************");
             
            Console.WriteLine("1. Find top selling product:-");
            //creating object of AggregationOperations for calling several methods
            AggregationOperations aggregationOperations = new AggregationOperations();
            TopSellingProduct topSellingProduct = aggregationOperations.getTopSellingProduct(translist, productList);
            Console.WriteLine(topSellingProduct.ProductId+ " , "+topSellingProduct.ProductName);
            Console.WriteLine("************************************************************************************************");

            Console.WriteLine("2. Find top buyer (most product bought by Buyer");
            TopBuyer topBuyer = aggregationOperations.getTopBuyer(translist, buyerList);
            Console.WriteLine( topBuyer.BuyerId+ " , "+ topBuyer.BuyerName );
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine("3. Top seller (Most product sold by Seller)");
            TopSeller topSeller = aggregationOperations.getTopSeller(translist, sellerList);
            Console.WriteLine(topSeller.sellerId+ " , "+ topSeller.sellerName );
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine("4. Most product sell and buy by location");
            aggregationOperations.getBuySellByLocation(translist, buyerList, sellerList);
            List<MostProductBuySellByLocation> res =aggregationOperations.getBuySellByLocation(translist, buyerList, sellerList);
            foreach(MostProductBuySellByLocation item in res)
            {
                Console.WriteLine(item.Location + " , " + item.TotalSellForLocation + ", " + item.TotalBuyForLocation);
            }
            Console.WriteLine("****************************************************************************************************");

            Console.WriteLine("5. Total GMV ");
            GrossMerchandiseValue gmv= aggregationOperations.getGrossMerchandiseValue(translist);
            Console.WriteLine(gmv.TotalPrice);
            Console.WriteLine("************************************************************************************************");

            Console.WriteLine("4.2. Most product sell and buy by location");
            aggregationOperations.getTotalQuantitybyLocation(translist, buyerList, sellerList);
            List<MostProductBuySellByLocation> res2 = aggregationOperations.getBuySellByLocation(translist, buyerList, sellerList);
            foreach (MostProductBuySellByLocation item in res)
            {
                Console.WriteLine(item.Location + " , " + item.TotalSellForLocation + ", " + item.TotalBuyForLocation);
            }

        }
    }
}
