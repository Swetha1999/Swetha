using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyAbstractPattern
{
    public class ConcreteCarFactory:CarFactory
    {
        public override void makeLuxuryCar()
        {
             new LuxuryCar(CarType.LUXURY,Location.DEFAULT);
        }
        public override void makeMiniCar()
        {
            new MiniCar(CarType.MINI, Location.INDIA);

        }
        public override void makeMicroCar()
        {
            new MicroCar(CarType.MICRO, Location.USA);
        }
    }
}
