namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.CatOrigenes")]
    public partial class CatOrigenes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatOrigenes()
        {
            Clientes = new HashSet<Clientes>();
            Contactos = new HashSet<Contactos>();
            Prospectos = new HashSet<Prospectos>();
        }

        public Guid id { get; set; }

        [StringLength(100)]
        public string origen { get; set; }

        public bool? protegido { get; set; }

        public DateTime? fec_reg { get; set; }

        public DateTime? fec_mod { get; set; }

        public Guid? usu_reg { get; set; }

        public Guid? usu_mod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clientes> Clientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contactos> Contactos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prospectos> Prospectos { get; set; }
    }
}
