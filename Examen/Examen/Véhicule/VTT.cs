using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{

    public class VTT : Vehicule
    {
        int grandeurRoue;
        string marqueRoue;

        public VTT(string nom, string marque, int prix, Moteur moteur) : base(nom, marque, prix, moteur)
        {
            grandeurRoue = 20;
            marqueRoue = "4Roue";
        }

        public VTT(string nom, string marque, int prix, Moteur moteur, int grandeurRoue, string marqueRoue) : base(nom, marque, prix, moteur)
        {
            this.grandeurRoue = grandeurRoue;
            this.marqueRoue = marqueRoue;
        }

        //Fonction ToString
        public override string ToString()
        {
            string info = base.ToString();

            info += $"Roue: \n --------------------- \n Marque : {marqueRoue} Grandeur : {grandeurRoue} \n -------------------------- \n";
            return info;
        }
    }
}
