namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("RoachoCRM.Prospectos")]
    [DataContract]
    public partial class Prospectos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prospectos()
        {
            Clientes = new HashSet<Clientes>();
            Contactos = new HashSet<Contactos>();
            ProspectoArchivo = new HashSet<ProspectoArchivo>();
            ProspectoHistorico = new HashSet<ProspectoHistorico>();
            ProspectoNota = new HashSet<ProspectoNota>();
        }

        public Guid id { get; set; }

        public Guid? idprefijo { get; set; }

        [DataMember]
        [Required(ErrorMessage = "please enter username")]
        [StringLength(100)]
        [Display(Name = "Prospecto_Nombre", ResourceType =typeof(RoachoSLN.Resource.Resource))]
        public string nombre { get; set; }

        [StringLength(100)]
        [Display(Name = "Prospecto_Apellido1", ResourceType = typeof(RoachoSLN.Resource.Resource))]
        public string apellido1 { get; set; }

        [StringLength(100)]
        [Display(Name = "Prospecto_Apellido2", ResourceType = typeof(RoachoSLN.Resource.Resource))]
        public string apellido2 { get; set; }

        [StringLength(12)]
        [Display(Name = "Prospecto_Telefono", ResourceType = typeof(RoachoSLN.Resource.Resource))]
        public string telefono { get; set; }

        [StringLength(12)]
        [Display(Name = "Prospecto_Telefono2", ResourceType = typeof(RoachoSLN.Resource.Resource))]
        public string telefono2 { get; set; }

        [StringLength(12)]
        [Display(Name = "Prospecto_Celular", ResourceType = typeof(RoachoSLN.Resource.Resource))]
        public string celular { get; set; }

        [StringLength(100)]
        [Display(Name = "Prospecto_Correo", ResourceType = typeof(RoachoSLN.Resource.Resource))]
        public string correo { get; set; }

        [StringLength(100)]
        public string pagina { get; set; }

        [StringLength(100)]
        public string skype { get; set; }

        [StringLength(250)]
        public string calle { get; set; }

        [StringLength(100)]
        public string ciudad { get; set; }

        public Guid? estado { get; set; }

        [StringLength(5)]
        public string codigopostal { get; set; }

        public Guid? idorigen { get; set; }

        public Guid? idindustria { get; set; }

        public decimal? ingresos { get; set; }

        public int? numempleado { get; set; }

        public int? calificacion { get; set; }

        [Column(TypeName = "text")]
        public string textoextra { get; set; }

        public Guid? iddueño { get; set; }

        public int? estatus { get; set; }

        public bool? convertido { get; set; }

        public DateTime? fec_reg { get; set; }

        public DateTime? fec_mod { get; set; }

        public Guid? usu_reg { get; set; }

        public Guid? usu_mod { get; set; }

        public virtual CatEstados CatEstados { get; set; }

        public virtual CatIndustrias CatIndustrias { get; set; }

        public virtual CatOrigenes CatOrigenes { get; set; }

        public virtual CatPrefijos CatPrefijos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clientes> Clientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contactos> Contactos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProspectoArchivo> ProspectoArchivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProspectoHistorico> ProspectoHistorico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProspectoNota> ProspectoNota { get; set; }
    }
}
