using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Road.Vehicle;

namespace Road
{
    internal class Vehicle : IDriveable
    {
        public double Speed { get; set; } 
        public double Size { get; set; }  
        public string Type { get; set; }  

        public Vehicle(double speed, double size, string type)
        {
            Speed = speed;
            Size = size;
            Type = type;
        }
        public void Move()
        {
            Console.WriteLine($" {Type} moving at speed {Speed} km/h.");
        }

        public void Stop()
        {
            Console.WriteLine($" {Type} stopped.");
        }
        public interface IDriveable
        {
            void Move();
            void Stop();
        }
    } 
    
}
