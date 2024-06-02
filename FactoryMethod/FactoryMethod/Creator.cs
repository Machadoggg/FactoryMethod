using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Creator
    {
        public const int MOTORCYCLE = 1;
        public const int CAR = 2;
        public const int TRUCK = 3;

        public static Vehicle VehicleCreator(int type)
        { 
            switch (type) 
            { 
                case MOTORCYCLE:
                    return new Motorcycle();
                case CAR: 
                    return new Car();
                case TRUCK:
                    return new Truck();
                default:
                    return null;
            
            }
        }
    }
}
