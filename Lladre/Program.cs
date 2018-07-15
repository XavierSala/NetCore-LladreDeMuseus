using System;
using System.Collections.Generic;

using Lladre.Db;

namespace Lladre
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            Investigation investigate = new Investigation();

            var denuncies = database.getDenuncies();

            // Investigar totes les denuncies
            foreach (var denuncia in denuncies)
            {
                investigate.addVisitants(database.getVisites(denuncia));
            }

            // Imprimir Resultats
            foreach (var Sospitos in investigate.Sospitosos)
            {
                Console.WriteLine($" {Sospitos.Nom}");
            }
        }

    }
}
