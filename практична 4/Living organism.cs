using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace практична_4
{
    public class LivingOrganism
    {
        public LivingOrganism(double energy, int age, double size)
        {
            Energy = energy;
            Age = age;
            Size = size;
        }

        public double Energy { get; set; }
        public int Age { get; set; }
        public double Size { get; set; }

        internal void Update()
        {
            throw new NotImplementedException();
        }
    }
}



