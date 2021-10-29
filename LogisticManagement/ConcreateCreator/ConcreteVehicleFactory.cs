using LogisticManagement.ConcreateProduct;
using LogisticManagement.Creator;
using LogisticManagement.Interface;
using System;

namespace LogisticManagement.ConcreateCreator
{
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException($"Vehicle {Vehicle} cannot be created");
            }
        }
    }
}
