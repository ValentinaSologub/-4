using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Computer.Workstation;

namespace Computer
{
    internal class Workstation : Computer, IConnectable
    {
        public Workstation(string ipAddress, int power, string os) 
            : base(ipAddress, power, os) { }
        public void Connect(Computer target) 
        {
            Console.WriteLine($"Work station {IPAddress} connected with {target.IPAddress}");
        }
        public void Disconnect(Computer target) 
        {
            Console.WriteLine($"Work station {IPAddress} disconnected from {target.IPAddress}");
        }
        public void TransmitData(string data) 
        {
            Console.WriteLine($"Work station {IPAddress} transferred the data: {data}");
        }
        public string ReceiveData() 
        {
            return "The data is obtained at the workstation";
        }
        public interface IConnectable
        {
            void Connect(Computer target);
            void Disconnect(Computer target);
            void TransmitData(string data);
            string ReceiveData();
        }
    }
}
