namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.CatIndustrias")]
    public partial class CatIndustrias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatIndustrias()
        {
            Clientes = new HashSet<Clientes>();
            Prospectos = new HashSet<Prospectos>();
        }

        public Guid id { get; set; }

        [StringLength(100)]
        public string industria { get; set; }

        public bool? protegido { get; set; }

        public DateTime? fec_reg { get; set; }

        public DateTime? fec_mod { get; set; }

        public Guid? usu_reg { get; set; }

        public Guid? usu_mod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clientes> Clientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prospectos> Prospectos { get; set; }
    }
}
