namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.TareaRecordatorio")]
    public partial class TareaRecordatorio
    {
        public int id { get; set; }

        public Guid? idtarea { get; set; }

        public DateTime? fecha { get; set; }

        public bool? generada { get; set; }

        public virtual Tareas Tareas { get; set; }
    }
}
