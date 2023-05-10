using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Concessionnaire
    {
        public string Nom { get; set; }
        public List<Vehicule> Vehicules { get; set; }
        public List<Facture> lstFacture { get; set; }
        public double MontantArgent { get; set; }


        public Concessionnaire(string nom, double montantArgent)
        {
            Nom = nom;
            Vehicules = new List<Vehicule>();
            lstFacture= new List<Facture>();
            MontantArgent = montantArgent;
        }

        public void AjouterVehicule(Vehicule vehicule)
        {
            Vehicules.Add(vehicule);
        }
        public void VendreVehicule(Vehicule vehicule)
        {
                Console.WriteLine($"Nous avons cette voiture en inventaire");
                Vehicules.Remove(vehicule);
                MontantArgent += vehicule.Prix;
        }
        public string GetInfoInventaire()
        {
            string info = "";
            foreach(Vehicule voiture in Vehicules)
            {
                info += $"\n{voiture.ToString()}";
            }
            return info;
        }
        public void RemplirInventaire()
        {
            //MotoMarine
            Vehicules.Add(  new Motomarine("Spark", "BRP", 12000, new Moteur()));
            Vehicules.Add(new Motomarine("Spark GTI", "BRP", 15000, new Moteur()));

            Vehicules.Add(new Motomarine("GP1800R", "Yanhama", 11000, new Moteur()));
            Vehicules.Add(new Motomarine("GTX", "BRP", 18000, new Moteur("Rotax",230,TypeRefroidissement.air)));

            Vehicules.Add(new Motomarine("MarineLand", "Yanhama", 14000, new Moteur()));
            Vehicules.Add(new Motomarine("GTX-18", "BRP", 21000, new Moteur()));

            //VTT
            Vehicules.Add(new VTT("XP 1000", "Polaris", 32000, new Moteur()));
            Vehicules.Add(new VTT("Ride Command", "Polaris", 15000, new Moteur("Evo", 570, TypeRefroidissement.liquide)));

            Vehicules.Add(new VTT("Foreman 500", "Honda", 8000, new Moteur()));
            Vehicules.Add(new VTT("hdzshdhhh", "Polaris", 10000, new Moteur()));

            Vehicules.Add(new VTT("VTT Plastique", "Walmart", 35, new Moteur()));
            Vehicules.Add(new VTT("BIGVTT", "PolarisDuFutur", 5000, new Moteur("Evo4500", 5700, TypeRefroidissement.air)));
        }

        public override string ToString()
        {
            return $"\n Information Sur le Concessionnaire : \n Nom : {Nom} PorteFeuille: {MontantArgent} \n";
        }

    }
}
