using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Road
{
    internal class Road
    {
        public double Length { get; set; } 
        public double Width { get; set; }  
        public int NumberOfLanes { get; set; } 
        public double TrafficLevel { get; set; } 

        public Road(double length, double width, int numberOfLanes, double trafficLevel)
        {
            Length = length;
            Width = width;
            NumberOfLanes = numberOfLanes;
            TrafficLevel = trafficLevel;
        }
    }
}
