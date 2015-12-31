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

        [IgnoreDataMember]
        public Guid id { get; set; }

        [IgnoreDataMember]
        public Guid? idprefijo { get; set; }

        [DataMember]
        [Required(ErrorMessage = "please enter company name")]
        [StringLength(200)]
        [Display(Name = "compania", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public string compania { get; set; }

        [DataMember]
        [Required(ErrorMessage = "please enter username")]
        [StringLength(100)]
        [Display(Name = "nombre", ResourceType =typeof(RoachoSLN.Resource.prospectos.form))]
        public string nombre { get; set; }

        [StringLength(100)]
        [Display(Name = "apellido1", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public string apellido1 { get; set; }

        [StringLength(100)]
        [Display(Name = "apellido2", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public string apellido2 { get; set; }

        [StringLength(12)]
        [Display(Name = "telefono", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public string telefono { get; set; }

        [StringLength(12)]
        [Display(Name = "telefono2", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public string telefono2 { get; set; }

        [StringLength(12)]
        [Display(Name = "celular", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public string celular { get; set; }

        [StringLength(100)]
        [Display(Name = "correo", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public string correo { get; set; }

        [StringLength(100)]
        [Display(Name = "pagina", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public string pagina { get; set; }

        [StringLength(100)]
        [Display(Name = "skype", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public string skype { get; set; }

        [StringLength(250)]
        [Display(Name = "calle", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public string calle { get; set; }

        [StringLength(100)]
        [Display(Name = "ciudad", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public string ciudad { get; set; }

        [Display(Name = "estado", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public Guid? estado { get; set; }

        [StringLength(5)]
        [Display(Name = "codigopostal", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public string codigopostal { get; set; }

        [Display(Name = "idorigen", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public Guid? idorigen { get; set; }

        [Display(Name = "idindustria", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public Guid? idindustria { get; set; }

        [Display(Name = "ingresos", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public decimal? ingresos { get; set; }

        [Display(Name = "numempleado", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public int? numempleado { get; set; }

        [Display(Name = "calificacion", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public int? calificacion { get; set; }

        [Column(TypeName = "text")]
        [Display(Name = "textoextra", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public string textoextra { get; set; }

        [Display(Name = "iddueño", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public Guid? iddueño { get; set; }

        [Display(Name = "estatus", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public Guid? estatus { get; set; }

        [Display(Name = "convertido", ResourceType = typeof(RoachoSLN.Resource.prospectos.form))]
        public bool? convertido { get; set; }

        [IgnoreDataMember]
        public DateTime? fec_reg { get; set; }

        [IgnoreDataMember]
        public DateTime? fec_mod { get; set; }

        [IgnoreDataMember]
        public Guid? usu_reg { get; set; }

        [IgnoreDataMember]
        public Guid? usu_mod { get; set; }

        [IgnoreDataMember]
        public virtual CatEstados CatEstados { get; set; }
        [IgnoreDataMember]
        public virtual CatIndustrias CatIndustrias { get; set; }
        [IgnoreDataMember]
        public virtual CatOrigenes CatOrigenes { get; set; }
        [IgnoreDataMember]
        public virtual CatPrefijos CatPrefijos { get; set; }
        [IgnoreDataMember]
        public virtual CatProspectoEstatus CatProspectoEstatus { get; set; }

        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clientes> Clientes { get; set; }

        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contactos> Contactos { get; set; }

        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProspectoArchivo> ProspectoArchivo { get; set; }

        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProspectoHistorico> ProspectoHistorico { get; set; }

        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProspectoNota> ProspectoNota { get; set; }
    }
}
