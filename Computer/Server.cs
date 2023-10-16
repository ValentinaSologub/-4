using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Computer.Server;

namespace Computer
{
    internal class Server : Computer, IConnectable
    {
        public Server(string ipAddress, int power, string os)
                : base(ipAddress, power, os)  { }
        public void Connect(Computer target)  
        {
            Console.WriteLine($"Server {IPAddress} connected with {target.IPAddress}");
        }
        public void Disconnect(Computer target) 
        { 
        Console.WriteLine ($"Server {IPAddress} disconnected from  {target.IPAddress}");
        }
        public void TransmitData(string data) 
        { 
        Console.WriteLine($"Server {IPAddress} transferred the data: {data}");
        }
        public string ReceiveData() 
        {
            return "The data is received on the server";
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
