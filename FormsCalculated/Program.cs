namespace FormsCalculated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Veuillez entrer la forme que vous souhaiter calculer (Triangle, Carre, Rond):");
            string v = Console.ReadLine();
            
            try
            {
                FormVerif formVerif = new FormVerif(v);
                formVerif.GetAllValueUser();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}