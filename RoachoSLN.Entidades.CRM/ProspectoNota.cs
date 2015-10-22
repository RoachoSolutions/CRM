namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.ProspectoNota")]
    public partial class ProspectoNota
    {
        public int id { get; set; }

        public Guid? idProspecto { get; set; }

        [Column(TypeName = "text")]
        public string nota { get; set; }

        public Guid? usuario { get; set; }

        public DateTime? fecha { get; set; }

        public virtual Prospectos Prospectos { get; set; }
    }
}
