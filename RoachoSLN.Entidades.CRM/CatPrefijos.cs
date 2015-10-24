
namespace RoachoSLN.Entidades.CRM
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.CatPrefijos")]
    public partial class CatPrefijos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatPrefijos()
        {
            Contactos = new HashSet<Contactos>();
            Prospectos = new HashSet<Prospectos>();
        }

        public Guid id { get; set; }

        [StringLength(20)]
        public string prefijo { get; set; }

        public int orden { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contactos> Contactos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prospectos> Prospectos { get; set; }
    }
}
