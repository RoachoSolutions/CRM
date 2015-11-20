namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.CatProspectoEstatus")]
    public partial class CatProspectoEstatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatProspectoEstatus()
        {
            Prospectos = new HashSet<Prospectos>();
        }

        public Guid id { get; set; }

        [StringLength(50)]
        public string estatus { get; set; }
             

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prospectos> Prospectos { get; set; }
    }
}
