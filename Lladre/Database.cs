using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using Lladre.Db;

namespace Lladre
{
    public class Database
    {

        public HashSet<Sospitos> getVisites(Denuncia denuncia)
        {
            using (var context = new LladreContext())
            {
                var museu = context.Museus
                        .Single(m => m.MuseuId == denuncia.MuseuId);

                var visitants = context.Entry(museu)
                    .Collection(v => v.Visites)
                    .Query()
                    .Where(vi => vi.Hora == denuncia.Hora)
                    .Include(vi => vi.Visitant)
                    .Select(t => new Sospitos(t.Visitant.VisitantId, t.Visitant.Nom))
                    .ToList();
                return new HashSet<Sospitos>(visitants);
            }
        }

        public List<Denuncia> getDenuncies()
        {
            using (var context = new LladreContext())
            {
                return context.Denuncies
                    .Include(d => d.Museu)
                    .ToList();
            }
        }


    }
}