using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyAbstractPattern
{
    public abstract class CarFactory
    {
        public abstract void makeLuxuryCar();
        public abstract void makeMiniCar();
        public abstract void makeMicroCar();
    }
}
