using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public enum TypeMotomarine
    {
        jetSki,
        SeaDoo,
    }
    public class Motomarine : Vehicule
    {
        TypeMotomarine typeMotomarine;

        public Motomarine(string nom, string marque, int prix, Moteur moteur) : base(nom,marque,prix,moteur)
        {
            typeMotomarine = TypeMotomarine.SeaDoo;
        }

        public override string ToString()
        {
            string info = base.ToString();

            info += $"Marque: {typeMotomarine}";
            return info;
        }

    }
}
