using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudyAbstractPattern
{
    public class EcommerceFactory:ProductFactory
    {
        public override void makeElectronicOrder()
        {

            new ElectronicOrder("Electronic", "Ecommerce");
        }
        public override void makeFurnitureOrder()
        {
            new FurnitureOrder("Furniture", "Ecommerece");
        }

        public override void makeToysOrder()
        {
            new ToysOrder("Toys", "Ecommerce");
        }
    }
}
