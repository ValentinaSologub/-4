using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практична_4
{
    internal class Plant : LivingOrganism
    {
        public Plant(double energy, int age, double size)
            : base(energy, age, size)
        {

        }
        public LivingOrganism Reproduce()
        {
            return new Plant(0, 0, 0);
        }
    }
}
