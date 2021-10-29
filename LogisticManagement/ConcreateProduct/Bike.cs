using LogisticManagement.Interface;
using System;

namespace LogisticManagement.ConcreateProduct
{
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine($"Drive the Bike : {miles} km");
        }
    }
}
