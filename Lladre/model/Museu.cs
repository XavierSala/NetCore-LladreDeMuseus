using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lladre.Db
{
    public class Museu
    {
        [Column("museu_id")]
        public int MuseuId { get; set; }
        public string Nom { get; set; }
        public string Poblacio { get; set; }
        public int Capacitat { get; set; }

        public List<Visita> Visites { get; set; }

    }
}