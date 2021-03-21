using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudyAbstractPattern
{
   public class Client
    {
        ProductFactory productFactory;
        public Client(ProductFactory productFactory)
        {
            this.productFactory = productFactory;
        }
        public void getChannelName(string productType,string channelName)
        {
            

            if (channelName == "Ecommerce")
            {
                productFactory = new EcommerceFactory();
                if (productType == "Electronic")
                {
                    productFactory.makeElectronicOrder();
                }
                if (productType == "Furniture")
                {
                    productFactory.makeFurnitureOrder();
                }
                if (productType == "Toys")
                {
                    productFactory.makeToysOrder();
                }
            }
            else
            {
                productFactory = new TeleCallerAgentFactory();
                if (productType == "Electronic")
                {
                    productFactory.makeElectronicOrder();
                }
                if (productType == "Furniture")
                {
                    productFactory.makeFurnitureOrder();
                }
                if (productType == "Toys")
                {
                    productFactory.makeToysOrder();
                }
            }
           
        }
        
    }
}
