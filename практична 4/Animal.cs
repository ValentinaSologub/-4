using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static практична_4.Animal;

namespace практична_4
{
    internal class Animal : LivingOrganism, IReproducible
    {
        public string Species { get; set; }
        public Animal (double energy, int age, double size, string species)
            : base (energy, age, size)
        { 
            Species = species;
        }

        public Animal(double energy, int age, double size) : base(energy, age, size)
        {
        }

        public void Hunt (LivingOrganism target) 
        {
            if (target is Plant) 
            {
                //логіка полювання тварин на рослин
                Energy += 20;
                target.Energy -= 20;
            }
        }
        public LivingOrganism Reproduce() 
        {
            return new Animal(0, 0, 0, Species);
        }
        internal interface IReproducible
        {
            LivingOrganism Reproduce();
        }


    }
}
