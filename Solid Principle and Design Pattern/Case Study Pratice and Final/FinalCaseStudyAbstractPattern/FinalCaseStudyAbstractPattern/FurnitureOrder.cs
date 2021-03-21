using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudyAbstractPattern
{
    class FurnitureOrder : Order
    {
        private string productTypes;
        private string channelNames;
        public FurnitureOrder(string productType, string channelName) : base(productType, channelName)
        {
            this.productTypes = productType;
            this.channelNames = channelName;
            OrderProcess();
        }
        public override void OrderProcess()
        {
            Console.WriteLine(productTypes+" order is accepted by "+channelNames+" channel");
        }
    }
}
