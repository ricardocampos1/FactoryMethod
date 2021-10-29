using LogisticManagement.Interface;

namespace LogisticManagement.Creator
{
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string vehicle);
    }
}
