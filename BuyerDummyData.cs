using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class BuyerDummyData
    {
        public List<BuyerData> getBuyerData()
        {
            List<BuyerData> buyerList = new List<BuyerData>();
            BuyerData buyerData1 = new BuyerData(501,"Ritika","Indore");
            BuyerData buyerData2 = new BuyerData(502,"Shraddha","Bhopal");
            BuyerData buyerData3 = new BuyerData(503,"Shreya","Jaipur");
            BuyerData buyerData4 = new BuyerData(504,"Varsha","Pune");
            BuyerData buyerData5 = new BuyerData(505,"Aaliya","Chennai");
            BuyerData buyerData6 = new BuyerData(506,"Bhawna","Mumbai");
            BuyerData buyerData7 = new BuyerData(507,"Vaishnavi","Delhi");
            BuyerData buyerData8 = new BuyerData(508,"Sonal","Banglore");
            //adding objects in buyerlist
            buyerList.Add(buyerData1);
            buyerList.Add(buyerData2);
            buyerList.Add(buyerData3);
            buyerList.Add(buyerData4);
            buyerList.Add(buyerData5);
            buyerList.Add(buyerData6);
            buyerList.Add(buyerData7);
            buyerList.Add(buyerData8);
            //returning buyerlist
            return buyerList;
        }
    }
}
