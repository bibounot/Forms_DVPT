using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsCalculated
{
    internal class Carre : Forms, IFormsHxB
    {

        public double Aire(double h, double b)
        {
            return h * b;
        }

        public double Perimetre(double h, double b)
        {
            return 2 * (h + b);
        }
    }
}
