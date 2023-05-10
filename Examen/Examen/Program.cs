using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Program
    {
        static void Main(string[] args)
        {
            InitialiserNom();
            Simulateur.Simuler();
        }
        //Initialisation
        static void InitialiserNom()
        {
            try
            {
                FabriqueNom.RemplirListe();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur survenue lors de la Lecture" + ex.Message);
            }
        }
    }
}
