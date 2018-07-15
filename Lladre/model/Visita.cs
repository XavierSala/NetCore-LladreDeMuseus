using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Lladre.Db
{
    public class Visita
    {
        [Column("id_visita")]
        public string VisitaId { get; set; }
        [ForeignKey("museu_id")]
        [Column("museu_id")]
        public int MuseuId { get; set; }
        public virtual Museu Museu { get; set; }

        [ForeignKey("visitant_id")]
        public virtual Visitant Visitant { get; set; }
        public DateTime Hora { get; set; }
    }
}