using LogisticManagement.Interface;
using System;

namespace LogisticManagement.ConcreateProduct
{
    public class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine($"Drive the Scooter : {miles} km");
        }
    }
}
