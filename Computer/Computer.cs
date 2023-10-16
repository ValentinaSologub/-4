using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    internal class Computer
    {
        public string IPAddress { get; set; }
        public int Power { get; set; }
        public string OS { get; set; }
        public Computer(string ipAddress, int power, string os)
        {
            IPAddress = ipAddress;
            Power = power;
            OS = os;
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
