namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.Tareas")]
    public partial class Tareas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tareas()
        {
            TareaRecordatorio = new HashSet<TareaRecordatorio>();
            TareaRepetir = new HashSet<TareaRepetir>();
        }

        public Guid id { get; set; }

        [StringLength(100)]
        public string asunto { get; set; }

        public Guid? idcontacto { get; set; }

        public int? tipocontacto { get; set; }

        public int? estatus { get; set; }

        public int? prioridad { get; set; }

        public DateTime? fecha { get; set; }

        public bool? recordatorio { get; set; }

        public bool? repetir { get; set; }

        public Guid? iddueño { get; set; }

        [Column(TypeName = "text")]
        public string texto { get; set; }

        public DateTime? fec_reg { get; set; }

        public DateTime? fec_mod { get; set; }

        public Guid? usu_reg { get; set; }

        public Guid? usu_mod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TareaRecordatorio> TareaRecordatorio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TareaRepetir> TareaRepetir { get; set; }
    }
}
