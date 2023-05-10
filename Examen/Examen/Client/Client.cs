using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Client
    {
        public string Nom { get; set; }
        public int Argent { get; set; }

        public Client()
        {
            Nom = FabriqueNom.FabriquerNom();

            //Setting de l'humeur du client 
            Argent = FabriqueNom.rand.Next(5000, 50000);
        }
    }
}
