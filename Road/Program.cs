using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Road
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Vehicle car = new Vehicle(100, 4, "Автомобіль");

            
            Road road = new Road(10000, 10, 2, 0.2);

           
            TrafficSimulation simulation = new TrafficSimulation();
            simulation.Simulate(car, road);
        }
    }
}
