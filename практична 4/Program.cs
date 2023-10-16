using практична_4;

public class Program 
{
    static void Main(string[] args) 
    {
        Ecosystem ecosystem = new Ecosystem();
        Animal lion = new(100, 5, 2);
        Plant grass = new Plant(50, 1, 1);
        Microorganism bacteria = new Microorganism(10, 1, 0.1);

        ecosystem.AddOrganism(lion);
        ecosystem.AddOrganism(grass);
        ecosystem.AddOrganism(bacteria);

        ecosystem.SimulateEcosystem(100);
    }
}