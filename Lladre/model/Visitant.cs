using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Lladre.Db
{
    public class Visitant
    {
        [Column("visitant_id")]
        public string VisitantId { get; set; }
        public string Nom { get; set; }

        [ForeignKey("sexe_id")]
        [Column("sexe_id")]
        public int SexeId { get; set; }
        public virtual Sexe Sexe { get; set; }

        public List<Visita> Visites { get; set; }
    }

    [Table("Sexes")]
    public class Sexe
    {

        [Column("sexe_id")]
        public int SexeId { get; set; }
        public string Valor { get; set; }
    }
}
