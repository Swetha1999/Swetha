using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudyAbstractPattern
{
    public abstract class ProductFactory
    {
        public abstract void makeElectronicOrder();
        public abstract void makeFurnitureOrder();
        public abstract void makeToysOrder();
    }
}
