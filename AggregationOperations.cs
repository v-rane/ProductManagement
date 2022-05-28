using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class AggregationOperations
    {
        public TopSellingProduct getTopSellingProduct(List<TransactionData> transList, List<ProductData> productList)
        {
            //dic with TopSellingProduct as value and ProductId as key
            Dictionary<int, TopSellingProduct> dic = new Dictionary<int, TopSellingProduct>();
            //iterating translist
            foreach (TransactionData transactionData in transList)
            {
                if (dic.ContainsKey(transactionData.ProductId))
                {
                    //if dic has same id then increment in ProductIdCount
                    dic[transactionData.ProductId].ProductIdCount++;
                }
                else
                {
                    //adding values in dic by creating objectof TopSellingProduct for values
                    dic.Add(transactionData.ProductId, new TopSellingProduct());
                    dic[transactionData.ProductId].ProductId = transactionData.ProductId;
                    dic[transactionData.ProductId].ProductIdCount = 1;
                }
            }
            //object of topSellingProduct is created
            TopSellingProduct topSellingProduct = new TopSellingProduct();
            // assigning min value of int 
            topSellingProduct.ProductIdCount = int.MinValue;
            //iterating dic 
            foreach (var data in dic.Values)
            {
                //if count of dic is > than productIdCount of topSellingProduct than add in object of topSellingProduct value of count and id of that key respectively
                if (data.ProductIdCount > topSellingProduct.ProductIdCount)
                {
                    //assigning in object of topSellingProduct values
                    topSellingProduct.ProductIdCount = data.ProductIdCount;
                    topSellingProduct.ProductId = data.ProductId;
                }
            }
            //List of productData is iterated
            foreach (ProductData product in productList)
            {
                //id of productList is equal to id of topSellingProduct then add name in object of topSellingProduct
                if (product.ProductId == topSellingProduct.ProductId)
                {
                    topSellingProduct.ProductName = product.ProductName;
                }
            }
            return topSellingProduct;
        }

        //****************************************************************************************************************
        public TopBuyer getTopBuyer(List<TransactionData> transList, List<BuyerData> buyerList)
        {
            //dic with buyerData objects as value and key as buyerId
            Dictionary<int, TopBuyer> dic = new Dictionary<int, TopBuyer>();
            foreach (TransactionData transactionData in transList)
            {
                if (dic.ContainsKey(transactionData.BuyerId))
                {
                    //if duplicate transaction id comes increment in dic
                    dic[transactionData.BuyerId].BuyerIdCount++;
                }
                else
                {
                    //adding values in dic by creating object of TopBuyer respect to transactionId
                    dic.Add(transactionData.BuyerId, new TopBuyer());
                    dic[transactionData.BuyerId].BuyerId = transactionData.BuyerId;
                    dic[transactionData.BuyerId].BuyerIdCount = 1;
                }
            }
            //new object of topBuyer is created
            TopBuyer topBuyer = new TopBuyer();
            topBuyer.BuyerIdCount = int.MinValue;
            //iterating dic to assign in object of topBuyer
            foreach (TopBuyer buyer in dic.Values)
            {
                //if count of dic buyercount is greater than add in object of topBuyer id and count
                if (buyer.BuyerIdCount > topBuyer.BuyerIdCount)
                {
                    topBuyer.BuyerIdCount = buyer.BuyerIdCount;
                    topBuyer.BuyerId = buyer.BuyerId;
                }
            }
            //iterating buyer list for getting name
            foreach (BuyerData data in buyerList)
            {
                //comparing object of buyerId with object of topBuyer's buyerId for assigning name
                if (data.BuyerId == topBuyer.BuyerId)
                {
                    topBuyer.BuyerName = data.BuyerName;
                }
            }
            return topBuyer;
        }
        //*******************************************************************************************************************
        public TopSeller getTopSeller(List<TransactionData> translist, List<SellerData> sellerList)
        {
            //dic with sellerId as key and object of TopSeller is created as values
            Dictionary<int, TopSeller> dic = new Dictionary<int, TopSeller>();
            foreach (TransactionData transactionData in translist)
            {
                if (dic.ContainsKey(transactionData.SellerId))
                {
                    //increment in count if the dic has same id  
                    dic[transactionData.SellerId].sellerIdCount++;
                }
                else
                {
                    //adding values in dic by creating object of TopSeller
                    dic.Add(transactionData.SellerId, new TopSeller());
                    dic[transactionData.SellerId].sellerId = transactionData.SellerId;
                    dic[transactionData.SellerId].sellerIdCount = 1;
                }
            }
            TopSeller topSeller = new TopSeller();
            topSeller.sellerIdCount = int.MinValue;
            //iterating dic for assigning id and count for getting topSeller
            foreach (var key in dic.Values)
            {
                if (key.sellerIdCount > topSeller.sellerIdCount)
                {
                    topSeller.sellerIdCount = key.sellerIdCount;
                    topSeller.sellerId = key.sellerId;
                }
            }
            //iterating sellerList for getting name of top seller in list
            foreach (SellerData data in sellerList)
            {
                if (data.SellerId == topSeller.sellerId)
                {
                    topSeller.sellerName = data.SellerName;
                }
            }

            return topSeller;
        }
        //*********************************************************************************************************************
        public List<MostProductBuySellByLocation> getBuySellByLocation(List<TransactionData> transList, List<BuyerData> buyerList, List<SellerData> sellerList)
        {
            Dictionary<string, MostProductBuySellByLocation> resultDic = new Dictionary<string, MostProductBuySellByLocation>();
            Dictionary<string, SellByLocation> sellBuyDic = new Dictionary<string, SellByLocation>();
            foreach (SellerData data in sellerList)
            {
                if (sellBuyDic.ContainsKey(data.SellerLocation))
                {
                    sellBuyDic[data.SellerLocation].sellLocation = data.SellerLocation;
                }
                else
                {
                    sellBuyDic.Add(data.SellerLocation, new SellByLocation());
                    sellBuyDic[data.SellerLocation].sellLocation = data.SellerLocation;
                }

                foreach (TransactionData trans in transList)
                {
                    if (trans.SellerId == data.SellerId)
                    {
                        sellBuyDic[data.SellerLocation].totalSell += trans.QuantityOfProduct;
                    }
                }
            } 
            //adding sell for location in list from dic
            List<SellByLocation> sellSellList = new List<SellByLocation>();
            foreach (SellByLocation loc in sellBuyDic.Values)
            {
                    sellSellList.Add(loc);
            }
            //---------------------------------------------------------------------------------------------------
            Dictionary<string, BuyByLocation> buyBydic = new Dictionary<string, BuyByLocation>();
            foreach (BuyerData loc in buyerList)
            {
                if(buyBydic.ContainsKey(loc.BuyerLocation))
                {
                    buyBydic[loc.BuyerLocation].buyLocation = loc.BuyerLocation;
                }
                else
                {
                    buyBydic.Add(loc.BuyerLocation, new BuyByLocation());
                    buyBydic[loc.BuyerLocation].buyLocation = loc.BuyerLocation;
                }

                foreach (TransactionData transData in transList)
                {
                    if (transData.BuyerId == loc.BuyerId)
                    {
                        buyBydic[loc.BuyerLocation].totalbuy += transData.QuantityOfProduct;
                    }     
                }
            }
            //adding buy for location in list from dic
             List<BuyByLocation> buyList = new List<BuyByLocation>();
             foreach (BuyByLocation bkey in buyBydic.Values)
             {
                  buyList.Add(bkey);
             }

            foreach (SellByLocation sData in sellSellList)
            {
                resultDic.Add(sData.sellLocation, new MostProductBuySellByLocation());
                resultDic[sData.sellLocation].Location = sData.sellLocation;
                resultDic[sData.sellLocation].TotalSellForLocation = sData.totalSell;
                resultDic[sData.sellLocation].TotalBuyForLocation = 0;
            }

            foreach (BuyByLocation bData in buyList)
            {
                if (resultDic.ContainsKey(bData.buyLocation))
                {
                    resultDic[bData.buyLocation].TotalBuyForLocation = bData.totalbuy;
                }
                else
                {
                    resultDic.Add(bData.buyLocation, new MostProductBuySellByLocation());
                    resultDic[bData.buyLocation].Location = bData.buyLocation;
                    resultDic[bData.buyLocation].TotalBuyForLocation = bData.totalbuy;
                    resultDic[bData.buyLocation].TotalSellForLocation = 0;
                }
            }
            List<MostProductBuySellByLocation> resultlist = new List<MostProductBuySellByLocation>();
            foreach (var item in resultDic.Values)
            {
                resultlist.Add(item);
            }
         return resultlist;
        }

       //**************************************************************************************************************************************
        public GrossMerchandiseValue getGrossMerchandiseValue(List<TransactionData> translist)
        {
            int gmv = 0;
            foreach (TransactionData trans in translist)
            {
                gmv += trans.QuantityOfProduct * trans.PriceOfProduct;
            }
            return new GrossMerchandiseValue(gmv);
        }
        //**************************************************************************************************************************************

        /*
         * <>
         * iterating transdata to group by sellId and quantity
         * iterating transdata to group by buyId (because both have some different location)
         * iterating sellList's sellId and compare it with sellId to get unique location 
         * iterating buyList's buyId and compare it with sellId to get unique location 
         * merging both list and group by location with adding buyquantity & sellquantity for it
         */
        //public List<MostProductBuySellByLocation> getTotalQuantitybyLocation(List<TransactionData> transList , List<BuyerData> buyerList, List<SellerData> sellerList)
        //{
        //    /*
        //     * @methodName getTotalQuantitybyLocation
        //     * @objective -to get sellQuantity and BuyQuantity at every location
        //     * @para -List<TransactionData>, List<BuyerData> ,List<SellerData>
        //     * @return -List<MostProductBuySellByLocation>
        //     */
            
        //    Dictionary<int,SellCountByLocation> sellIdDic = new Dictionary<int,SellCountByLocation>();
        //    foreach(TransactionData transactionData in transList)
        //    {
        //        if (sellIdDic.ContainsKey(transactionData.SellerId))
        //        {
        //            sellIdDic[transactionData.SellerId].SellQuantity += transactionData.QuantityOfProduct;
        //        }
        //        else
        //        {
        //            sellIdDic.Add(transactionData.SellerId, new SellCountByLocation());
        //            sellIdDic[transactionData.SellerId].SellId = transactionData.SellerId;
        //            sellIdDic[(transactionData.SellerId)].SellQuantity = transactionData.QuantityOfProduct;          
        //        }
        //    }
        //    Dictionary<int, buyCountByLocation> buyIdDic = new Dictionary<int, buyCountByLocation>();
        //    foreach (TransactionData transactionData in transList)
        //    {
        //        if (buyIdDic.ContainsKey(transactionData.BuyerId))
        //        {
        //            buyIdDic[transactionData.BuyerId].BuyQuantity += transactionData.QuantityOfProduct;
        //        }
        //        else
        //        {
        //            buyIdDic.Add(transactionData.BuyerId, new buyCountByLocation());
        //            buyIdDic[transactionData.BuyerId].BuyId = transactionData.BuyerId; 
        //            buyIdDic[(transactionData.BuyerId)].BuyQuantity = transactionData.QuantityOfProduct;
        //        }
        //    }
        //    Dictionary<string, TotalQuantityByLocation> keyValueDic = new Dictionary<string, TotalQuantityByLocation>();
        //    foreach (SellerData sellerData in sellerList)
        //    {
        //        if (keyValueDic.ContainsKey(sellerData.SellerLocation))
        //        {
        //            keyValueDic[sellerData.SellerLocation].Location = sellerData.SellerLocation;
        //            keyValueDic[sellerData.SellerLocation].SellQuantity = sellIdDic[sellerData.SellerId].SellQuantity;
        //            keyValueDic[sellerData.SellerLocation].BuyQuantity = 0;
        //        }
        //        else
        //        {
        //            keyValueDic.Add(sellerData.SellerLocation, new TotalQuantityByLocation());
        //            keyValueDic[sellerData.SellerLocation].Location = sellerData.SellerLocation;
        //            keyValueDic[sellerData.SellerLocation].SellQuantity = sellIdDic[sellerData.SellerId].SellQuantity;
        //            keyValueDic[sellerData.SellerLocation].BuyQuantity = 0;

        //        }
        //        foreach (BuyerData buyerData in buyerList)
        //        {
        //            if (buyerData.BuyerLocation == sellerData.SellerLocation)
        //            {
        //                keyValueDic[buyerData.BuyerLocation].BuyQuantity = buyIdDic[buyerData.BuyerId].BuyQuantity;
        //            }
        //            else
        //            {
        //                keyValueDic.Add(buyerData.BuyerLocation, new TotalQuantityByLocation());    
        //                keyValueDic[buyerData.BuyerLocation].Location = buyerData.BuyerLocation;
        //                keyValueDic[buyerData.BuyerLocation].BuyQuantity= buyIdDic[buyerData.BuyerId].BuyQuantity;
        //                keyValueDic[buyerData.BuyerLocation].SellQuantity = 0;
        //            }
        //        }//
        //    }
         
            //converting dic to list explicitly - resultList
            //List<TotalQuantityByLocation> resultList = new List<TotalQuantityByLocation>();
            //foreach (var totalQuantityByLocation in keyValueDic.Values)
            //{
            //    resultList.Add(totalQuantityByLocation);
            //}
            //foreach (var result in resultList)
            //{
            //    Console.WriteLine(result.Location + " , " + result.BuyQuantity + " , " + result.SellQuantity);
            //}

           //   return  null; 
      //  }
    } 
}

