using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyAbstractPattern
{
    public class CarClient
    {
        CarFactory carFactory;
        public CarClient(CarFactory carFactory)
        {
            this.carFactory = carFactory;
        }
        public void getCarType(string name)
        {
            if (name == "Micro")
            {
                BuildMicroCar(Location.USA);
            }
            if(name== "Mini")
            {
                BuildMiniCar(Location.INDIA);
            }
            if (name == "Luxury")
            {
                BuildLuxuryCar(Location.DEFAULT);
            }

        }
        public void  BuildMicroCar(Location location)
        {
            carFactory.makeMicroCar();
        }
        public void BuildMiniCar(Location location)
        {
            carFactory.makeMiniCar();
        }
        public void BuildLuxuryCar(Location location)
        {
            carFactory.makeLuxuryCar();
        }
    }
}
