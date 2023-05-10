using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Facture
    {
        public string Nom { get; set; }
        public DateTime DateAchat{ get; set; }
        public Vehicule Vehicules { get; set; }


        public Facture(string nom, DateTime dateAchat, Vehicule vehicules)
        {
            Nom = nom;
            DateAchat = dateAchat;
            Vehicules = vehicules;
        }

        public override string ToString()
        {
            return $"********INFORMATION SUR LA FACTURE******** \n Information - FACTURE \n Date : {DateAchat} \n CLIENT INFO : \n Nom : {Nom} \n Vehicule Acheté : {Vehicules.ToString()}";
        }
    }
}
