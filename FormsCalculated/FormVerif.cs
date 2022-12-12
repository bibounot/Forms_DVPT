using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsCalculated
{
    internal class FormVerif
    {
        private Forms _formOptions;
        enum FormType
        {
            Carre,
            Triangle,
            Rond
        }

        public FormVerif(String formType)
        {
            switch (formType)
            {
                case "Carre":
                    _formOptions = new Carre();
                    break;
                case "Triangle":
                    _formOptions = new Triangle();
                    break;
                case "Rond":
                    _formOptions = new Rond();
                    break;
                default:
                    throw new Exception("Forme non reconnue");
            }
        }

        internal void GetAllValueUser()
        {
            if (_formOptions is IFormsHxB)
            {
                Console.WriteLine("Entrez la hauteur");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Entrez la base");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Aire: " + (_formOptions as IFormsHxB).Aire(h, b));
                Console.WriteLine("Perimetre: " + (_formOptions as IFormsHxB).Perimetre(h, b));
            }
            else if (_formOptions is IFormsR)
            {
                Console.WriteLine("Entrez le rayon");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Aire: " + (_formOptions as IFormsR).Aire(r));
                Console.WriteLine("Perimetre: " + (_formOptions as IFormsR).Perimetre(r));
            }
        }
    }
}
