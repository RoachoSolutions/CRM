namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.Clientes")]
    public partial class Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clientes()
        {
            ClienteArchivo = new HashSet<ClienteArchivo>();
            ClienteContacto = new HashSet<ClienteContacto>();
            ClienteHistorico = new HashSet<ClienteHistorico>();
            ClienteNota = new HashSet<ClienteNota>();
            Clientes1 = new HashSet<Clientes>();
            Contactos = new HashSet<Contactos>();
        }

        public Guid id { get; set; }

        [StringLength(100)]
        public string nombre { get; set; }

        [StringLength(12)]
        public string telefono { get; set; }

        [StringLength(12)]
        public string telefono2 { get; set; }

        [StringLength(100)]
        public string pagina { get; set; }

        public Guid? idorigen { get; set; }

        public Guid? idindustria { get; set; }

        public Guid? cuentaprincipal { get; set; }

        [StringLength(50)]
        public string numerodecuenta { get; set; }

        public decimal? ingresos { get; set; }

        public int? numempleado { get; set; }

        public int? calificacion { get; set; }

        [StringLength(250)]
        public string callefacturacion { get; set; }

        [StringLength(100)]
        public string ciudadfacturacion { get; set; }

        public Guid? estadofacturacion { get; set; }

        [StringLength(5)]
        public string codigopostalfacturacion { get; set; }

        public bool? mismadireccion { get; set; }

        [StringLength(250)]
        public string calleenvio { get; set; }

        [StringLength(100)]
        public string ciudadenvio { get; set; }

        public Guid? estadoenvio { get; set; }

        [StringLength(5)]
        public string codigopostalenvio { get; set; }

        [Column(TypeName = "text")]
        public string textoextra { get; set; }

        public Guid? iddueño { get; set; }

        public int? estatus { get; set; }

        public Guid? lead { get; set; }

        public DateTime? fec_reg { get; set; }

        public DateTime? fec_mod { get; set; }

        public Guid? usu_reg { get; set; }

        public Guid? usu_mod { get; set; }

        public virtual CatEstados CatEstados { get; set; }

        public virtual CatEstados CatEstados1 { get; set; }

        public virtual CatIndustrias CatIndustrias { get; set; }

        public virtual CatOrigenes CatOrigenes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteArchivo> ClienteArchivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteContacto> ClienteContacto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteHistorico> ClienteHistorico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteNota> ClienteNota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clientes> Clientes1 { get; set; }

        public virtual Clientes Clientes2 { get; set; }

        public virtual Prospectos Prospectos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contactos> Contactos { get; set; }
    }
}
