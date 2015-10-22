namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.TareaRepetir")]
    public partial class TareaRepetir
    {
        public int id { get; set; }

        public Guid? idtarea { get; set; }

        public DateTime? fechainicio { get; set; }

        public DateTime? fechafin { get; set; }

        public int? tipo { get; set; }

        public virtual Tareas Tareas { get; set; }
    }
}
