using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement2
{
    public class ProductDummyData
    {
        public List<ProductData> getProductData()
        {
            List<ProductData> productList = new List<ProductData>();
            ProductData productData1 = new ProductData(701,"iPhone");
            ProductData productData2 = new ProductData(702,"Samsung Phone");
            ProductData productData3 = new ProductData(703,"OnePlus Tv");
            ProductData productData4 = new ProductData(704,"Sony HeadPhone");
            ProductData productData5 = new ProductData(705,"Asus Laptop");
            ProductData productData6 = new ProductData(706,"Benq Monitor");
            ProductData productData7 = new ProductData(707,"HP Tablet");
            ProductData productData8 = new ProductData(708,"Bose SoundBar");
            //adding objects in productList
            productList.Add(productData1);
            productList.Add(productData2);
            productList.Add(productData3);
            productList.Add(productData4);
            productList.Add(productData5);
            productList.Add(productData6);
            productList.Add(productData7);
            productList.Add(productData8);
            //returning productList
            return productList;
        }
    }
}
