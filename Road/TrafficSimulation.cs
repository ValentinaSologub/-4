using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Road
{
    internal class TrafficSimulation
    {
        public void Simulate(Vehicle vehicle, Road road)
        {
            
            double trafficFactor = 1.0 - road.TrafficLevel; 
            double speedOnRoad = vehicle.Speed * trafficFactor;

           
            vehicle.Speed = speedOnRoad;

         
            vehicle.Move();

           
            Console.WriteLine($"{vehicle.Type} moves on a long road {road.Length} meters with speed {vehicle.Speed} km/h.");
        }
    }
}
