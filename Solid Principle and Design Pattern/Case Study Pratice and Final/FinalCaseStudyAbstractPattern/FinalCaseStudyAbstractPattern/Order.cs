using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudyAbstractPattern
{
    public abstract class Order
    {
        public string channelName;
        public string productType;
        public Order(string channelName,string productType)
        {
            this.channelName = channelName;
            this.productType = productType;
        }
        public abstract void OrderProcess();
    }
}
