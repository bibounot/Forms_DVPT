using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsCalculated 
{
    internal class Rond : Forms, IFormsR
    {
        public double Aire(double R)
        {
            return Math.PI * R * R;
        }

        public double Perimetre(double R)
        {
            return 2 * Math.PI * R;
        }
    }
}

