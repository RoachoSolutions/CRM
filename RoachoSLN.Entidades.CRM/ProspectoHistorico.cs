namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.ProspectoHistorico")]
    public partial class ProspectoHistorico
    {
        public int id { get; set; }

        public Guid? idProspecto { get; set; }

        [StringLength(100)]
        public string movimiento { get; set; }

        public Guid? usuario { get; set; }

        public DateTime? fecha { get; set; }

        public virtual Prospectos Prospectos { get; set; }
    }
}
