using LogisticManagement.ConcreateCreator;
using LogisticManagement.Creator;
using LogisticManagement.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LogisticManagement.Controller
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(20);

            return Ok();
        }
    }
}
