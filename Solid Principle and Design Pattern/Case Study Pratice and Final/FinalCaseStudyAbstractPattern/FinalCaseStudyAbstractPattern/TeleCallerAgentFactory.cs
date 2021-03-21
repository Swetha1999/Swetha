using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudyAbstractPattern
{
    public class TeleCallerAgentFactory:ProductFactory
    {
        public override void makeElectronicOrder()
        {

            new ElectronicOrder("Electronic", "Tell Caller Agent");
        }
        public override void makeFurnitureOrder()
        {
            new FurnitureOrder("Furniture", "Tell Caller Agent");
        }

        public override void makeToysOrder()
        {
            new ToysOrder("Toys", "Tell Caller Agent");
        }
    }
}
