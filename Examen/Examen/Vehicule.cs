using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Vehicule
    {
        string nom;
        string marque;
        public int Prix { get; set; }
        public Moteur Moteurs { get; set; }

        
        public Vehicule(string nom, string marque, int prix, Moteur moteur)
        {
            this.nom = nom;
            this.marque = marque;
            Prix = prix;
            Moteurs = moteur;
        }

        public override string ToString()
        {
            return $"\n -------------------------- \n Nom : {nom}\n Marque: {marque} \n Prix: {Prix} \n -------------------------- \n Moteur: \n {Moteurs.ToString()} \n";
        }
    }
}
