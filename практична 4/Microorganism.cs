using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static практична_4.Animal;

namespace практична_4
{
    internal class Microorganism : LivingOrganism, IPredator, IReproducible
    {
        public Microorganism(double energy, int age, double size)
            : base(energy, age, size)
        {

        }
        public void Hunt(LivingOrganism target)
        {
            if (target is Plant)
            {
                
                Energy += 5;
                target.Energy -= 5;
            }
        }

        public void Hunt(IPredactor target)
        {
            throw new NotImplementedException();
        }

        public LivingOrganism Reproduce()
        {
           
            return new Microorganism(0, 0, 0);
        }
    }

    internal interface IPredator
    {
        void Hunt(IPredactor target);
    }
    public interface IReproduce 
    { 
        LivingOrganism Reproduce();
    }
    public interface IPredactor
    {
        void Hunt(LivingOrganism target);
    }
    public class Ecosystem 
    {
        private List<LivingOrganism> organisms;
        public Ecosystem() 
        {
            organisms = new List<LivingOrganism>();
        }
        public void AddOrganism(LivingOrganism organism) 
        {
            organisms.Add(organism);
        }
        public void SimulateEcosystem(int iterations) 
        {
            for (int i= 0; i < iterations; i++) 
            {
                Console.WriteLine($"interaction {i + 1}:");
                foreach (var organism in organisms)
                {
                    if (organisms is IPredactor) 
                    {
                        var predators = organisms.OfType<IPredactor>().Where (p => p != organisms). ToList();
                        if (predators.Count > 0) 
                        {
                            var target = predators[new Random().Next(predators.Count)];
                            ((IPredator)organisms).Hunt(target);
                            Console.WriteLine($"{organism.GetType().Name}: {target.GetType().Name}");
                        }
                    }
                    if (organisms is IReproducible) 
                    {
                        var reproductionChance = new Random().Next(101);
                        if (reproductionChance < 20) 
                        {
                            var newOrganism = ((IReproducible)organisms).Reproduce();
                            organisms.Add(newOrganism);
                            Console.WriteLine($"{organisms.GetType().Name}multiplied");
                        }
                    }
                    organism.Update();
                }
                foreach (var organism in organisms) 
                {
                    Console.WriteLine($"{organisms.GetType().Name}: Enerdgy - {organism.Energy}, Age - {organism.Age}, Size - {organism.Size}");
                }
                Console.WriteLine();
            }
        }
    }
}
