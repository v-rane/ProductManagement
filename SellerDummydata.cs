using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class SellerDummydata
    {
        public List<SellerData> getSellerData()
        {
            List<SellerData> sellerList = new List<SellerData>();
            SellerData sellerData1 = new SellerData(901,"Sajal","Pune");
            SellerData sellerData2 = new SellerData(902,"Vivek","Banglore");
            SellerData sellerData3 = new SellerData(903,"Ravi","Delhi");
            SellerData sellerData4 = new SellerData(904,"Ayush","Indore");
            SellerData sellerData5 = new SellerData(905,"Utkarsh","Bhopal");
            SellerData sellerData6 = new SellerData(906,"Vinod","Vizag");
            SellerData sellerData7 = new SellerData(907,"Rohit","Chennai");
            SellerData sellerData8 = new SellerData(908,"Ramesh","Pune");
            //adding objects in sellerList
            sellerList.Add(sellerData1);
            sellerList.Add(sellerData2);
            sellerList.Add(sellerData3);
            sellerList.Add(sellerData4);
            sellerList.Add(sellerData5);
            sellerList.Add(sellerData6);
            sellerList.Add(sellerData7);
            sellerList.Add(sellerData8);
            //returning list
            return sellerList;
        }
    }
}
