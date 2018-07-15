using System;
using System.Collections.Generic;
using Lladre.Db;

namespace Lladre
{
    public class Investigation
    {
        public HashSet<Sospitos> Sospitosos { get; }
        int NumVisitants;

        public Investigation()
        {
            Sospitosos = new HashSet<Sospitos>();
            NumVisitants = 0;
        }

        public void addVisitants(HashSet<Sospitos> visitants)
        {
            NumVisitants++;
            if (NumVisitants == 1)
            {
                Sospitosos.UnionWith(visitants);
            }
            else
            {
                Sospitosos.IntersectWith(visitants);
            }
        }

    }
}