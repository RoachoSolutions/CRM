namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.CatPaises")]
    public partial class CatPaises
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatPaises()
        {
            CatEstados = new HashSet<CatEstados>();
        }

        public Guid id { get; set; }

        [StringLength(100)]
        public string nombre { get; set; }

        [StringLength(3)]
        public string cod { get; set; }

        [StringLength(4)]
        public string tel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CatEstados> CatEstados { get; set; }
    }
}
