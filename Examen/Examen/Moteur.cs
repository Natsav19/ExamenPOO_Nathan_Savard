using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public enum TypeRefroidissement
    {
        air,
        liquide,
    }
    public class Moteur
    {
        public string Marque { get; set; }
        public int Force { get; set; }
        public TypeRefroidissement Type { get; set; }

        //Mes Constructeurs!
        public Moteur()
        {
            Marque = "Yamaha";
            Force = 50;
            Type = TypeRefroidissement.air;
        }

        public Moteur(string marque, int force, TypeRefroidissement type)
        {
            Marque = marque;
            Force = force;
            Type = type;
        }


        //Redéfinition des opérateurs 
        public static bool operator > (Moteur moteur1, Moteur moteur2)
        {
            return moteur1.Force > moteur2.Force;
        }
        public static bool operator <(Moteur moteur1, Moteur moteur2)
        {
            return moteur1.Force < moteur2.Force;
        }

        public override string ToString()
        {
            return $"-------------------------- \n Marque Du Moteur : {Marque} \n Force du Moteur : {Force} \n Type de Refroidissement : {Type} \n -------------------------- \n";
        }
    }
}
