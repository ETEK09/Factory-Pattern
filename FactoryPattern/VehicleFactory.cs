using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount) 
        { 
            switch (wheelCount) 
            {
                case 2:
                    return new Motorcycle();
                case 4: 
                    return new Car();
                case 16: 
                    return new Truck();
                default:
                    return new Car();
    

            }
        }


    }
}
