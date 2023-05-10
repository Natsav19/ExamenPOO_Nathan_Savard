using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public static class Simulateur
    {
        //Partie Centrale Du Programme 
        public static void Simuler()
        {
            Concessionnaire monConcessionnaire = new Concessionnaire("GaRAGE", 10000);
            monConcessionnaire.RemplirInventaire();
            List<Client> listClient = GenererListClient();
            SimulerTransaction(listClient, monConcessionnaire);
            foreach(Facture facture in monConcessionnaire.lstFacture)
            {
                Console.WriteLine(facture.ToString());
            }
            Console.WriteLine(monConcessionnaire.ToString());
        }

        //Lancement de La Simulation de la Transaction
        public static void SimulerTransaction(List<Client> lstClient, Concessionnaire monConcessionnaire)
        {

                foreach (Client clients in lstClient)
                {
                    try
                    {
                        SimulerAchatVehicules(clients, monConcessionnaire);
                    }
                    catch (TransactionException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
        }

        //Partie Gestion des Contraintes + Achat Voiture
        public static void SimulerAchatVehicules(Client clients, Concessionnaire monConcessionnaire)
        {
            if (monConcessionnaire.Vehicules.Count < 2)
            {
                throw new TransactionException("L'Inventaire est Vide");
            }
            else
            {
                int choix1 = FabriqueNom.rand.Next(0, monConcessionnaire.Vehicules.Count);
                int choix2 = FabriqueNom.rand.Next(0, monConcessionnaire.Vehicules.Count);
                if (((monConcessionnaire.Vehicules[choix1] is Motomarine && (monConcessionnaire.Vehicules[choix2] is Motomarine)) || ((monConcessionnaire.Vehicules[choix1] is VTT && (monConcessionnaire.Vehicules[choix2] is VTT)))))
                {
                    if (monConcessionnaire.Vehicules[choix1].Moteurs > monConcessionnaire.Vehicules[choix2].Moteurs)
                    {
                        if (clients.Argent >= monConcessionnaire.Vehicules[choix1].Prix)
                        {
                            Console.WriteLine("test");
                            CreationFacture(clients, monConcessionnaire.Vehicules[choix1], monConcessionnaire);
                            monConcessionnaire.VendreVehicule(monConcessionnaire.Vehicules[choix1]);
                        }
                        else
                        {
                            throw new TransactionException("Le Client n'a pas les moyens !", clients.Nom);
                        }
                    }
                    else
                    {
                        if (clients.Argent >= monConcessionnaire.Vehicules[choix2].Prix)
                        {
                            Console.WriteLine("test");
                            CreationFacture(clients, monConcessionnaire.Vehicules[choix2], monConcessionnaire);
                            monConcessionnaire.VendreVehicule(monConcessionnaire.Vehicules[choix2]);
                        }
                        else
                        {
                            Console.WriteLine("Le Client n'a pas les moyens");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ce n'est pas le meme Véhicules");
                }
            }
        }

        //Fonction Qui Va Créer La Facture
        public static void CreationFacture(Client client, Vehicule vehicules, Concessionnaire monConcessionnaire)
        {
            monConcessionnaire.lstFacture.Add(new Facture(client.Nom, GetDateAleatoire(), vehicules));
            Console.WriteLine("Voiture Acheter");
        }

        //Tire une Date Aléatoirement !
        private static DateTime GetDateAleatoire()
        {
            return new DateTime(2023, FabriqueNom.rand.Next(1, 12), FabriqueNom.rand.Next(1, 28));
        }

        //Création de la Liste Des Clients
        public static List<Client> GenererListClient()
        {
            int rdm = FabriqueNom.rand.Next(2, 5);
            List<Client> listClient = new List<Client>();
            for (int i = 0; i < rdm; i++)
            {
                Client client = new Client();
                listClient.Add(client);
            }
            return listClient;
        }


    }
}
