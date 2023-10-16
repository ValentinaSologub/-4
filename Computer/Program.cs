
using Computer;

class Program 
{
    static void Main(string[] args) 
    {
        Network network = new Network();

        Server server = new Server("192.168.1.1", 1000, "Windows Server");
        Workstation workstation = new Workstation("192.168.1.2", 500, "Windows 10");
        Router router = new Router("192.168.1.3", 100, "Embedded OS");

        network.AddComputer(server);
        network.AddComputer(workstation);
        network.AddComputer(router);

        network.SimulateNetwork();

    }
}