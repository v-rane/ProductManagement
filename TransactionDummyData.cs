using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class TransactionDummyData
    {
        public List<TransactionData> getTransactionData()
        {
            List<TransactionData> transList = new List<TransactionData>();
            TransactionData transactionData1 = new TransactionData(101,901,701,501,120,2,new DateTime(2022,4,5));
            TransactionData transactionData2 = new TransactionData(102,902,702,502,230,1,new DateTime(2022,4,6));
            TransactionData transactionData3 = new TransactionData(103,901,703,503,240,2,new DateTime(2022,4,6));
            TransactionData transactionData4 = new TransactionData(104,903,702,503,110,4, new DateTime(2022, 4, 5));
            TransactionData transactionData5 = new TransactionData(105,901,702,501,150,3, new DateTime(2022, 4, 5));
            TransactionData transactionData6 = new TransactionData(106,904,701,503,220,3, new DateTime(2022, 4, 6));
            TransactionData transactionData7 = new TransactionData(107,905,704,504,225,2, new DateTime(2022, 4, 6));
            TransactionData transactionData8 = new TransactionData(108,906,705,505,250,4, new DateTime(2022, 4, 6));
            //adding objects in transList
            transList.Add(transactionData1);
            transList.Add(transactionData2);
            transList.Add(transactionData3);
            transList.Add(transactionData4);
            transList.Add(transactionData5);
            transList.Add(transactionData6);
            transList.Add(transactionData7);
            transList.Add(transactionData8);    
            //returning list
            return transList;
        }
    }
}
