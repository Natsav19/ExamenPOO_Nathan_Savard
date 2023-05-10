using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class TransactionException : Exception
    {

        public TransactionException()//+
        {

        }
        public TransactionException(string message)
        {

        }
        public TransactionException(string message, string nom)
        {
            Console.WriteLine($"CLIENT INFO : {nom}");
        }

        public override string ToString()
        {
            string info = "TransactionException : " + Message + "\n";
            return info;
        }
    }
}
