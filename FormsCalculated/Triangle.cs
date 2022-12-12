using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsCalculated
{
    internal class Triangle : Forms, IFormsHxB
    {
        public double Aire(double h, double b)
        {
            return (h * b) / 2;
        }

        public double Perimetre(double h, double b)
        {
            return h + b + Math.Sqrt(Math.Pow(h, 2) + Math.Pow(b, 2));
        }
    }
}
