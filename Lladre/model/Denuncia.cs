using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lladre.Db
{
    public class Denuncia
    {
        [Column("id_denuncia")]
        public string DenunciaId { get; set; }

        [ForeignKey("museu_id")]
        [Column("museu_id")]
        public int MuseuId { get; set; }
        public virtual Museu Museu { get; set; }

        public DateTime Hora { get; set; }
    }
}