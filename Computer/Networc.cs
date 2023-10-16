using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    internal class Network
    {
        private List<Computer> computers;
        public Network() 
        {
        computers = new List<Computer>();
        }
        public void AddComputer(Computer computer) 
        {
        computers.Add(computer);
        }
        public void SimulateNetwork(Computer computer) 
        {
            if (computers.Count < 2) 
            {
                Console.WriteLine("The network must be configured with at least two computers.");
                return;
            }
            var computer1 = computers[0];
            var computer2 = computers[1];

            if (computer1 is IConnectable && computer2 is IConnectable) 
            {
                var connectableComputer1 = (IConnectable)computer1;
                var connectableComputer2 = (IConnectable)computer2;

                connectableComputer1.Connect(computer2);
                connectableComputer1.TransmitData("Дані від Computer1 до Computer2");
                Console.WriteLine(connectableComputer2.ReceiveData());
                connectableComputer1.Disconnect(computer2);
            }
        }

        internal void SimulateNetwork()
        {
            throw new NotImplementedException();
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
