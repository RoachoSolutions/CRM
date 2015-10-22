namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.Contactos")]
    public partial class Contactos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contactos()
        {
            ClienteContacto = new HashSet<ClienteContacto>();
            ContactoArchivo = new HashSet<ContactoArchivo>();
            ContactoHistorico = new HashSet<ContactoHistorico>();
            ContactoNota = new HashSet<ContactoNota>();
        }

        public Guid id { get; set; }

        public int? prefijo { get; set; }

        [StringLength(100)]
        public string nombre { get; set; }

        [StringLength(100)]
        public string apellido1 { get; set; }

        [StringLength(100)]
        public string apellido2 { get; set; }

        [StringLength(12)]
        public string telefono { get; set; }

        [StringLength(12)]
        public string telefono2 { get; set; }

        [StringLength(12)]
        public string celular { get; set; }

        [StringLength(100)]
        public string correo { get; set; }

        [StringLength(100)]
        public string correo2 { get; set; }

        [StringLength(100)]
        public string skype { get; set; }

        public Guid? idorigen { get; set; }

        [StringLength(100)]
        public string departamento { get; set; }

        public DateTime? fechanac { get; set; }

        [StringLength(250)]
        public string calle { get; set; }

        [StringLength(100)]
        public string ciudad { get; set; }

        public Guid? estado { get; set; }

        [StringLength(5)]
        public string codigopostal { get; set; }

        [Column(TypeName = "text")]
        public string textoextra { get; set; }

        public Guid? cuenta { get; set; }

        public Guid? iddueño { get; set; }

        public int? estatus { get; set; }

        public Guid? lead { get; set; }

        public DateTime? fec_reg { get; set; }

        public DateTime? fec_mod { get; set; }

        public Guid? usu_reg { get; set; }

        public Guid? usu_mod { get; set; }

        public virtual CatEstados CatEstados { get; set; }

        public virtual CatOrigenes CatOrigenes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteContacto> ClienteContacto { get; set; }

        public virtual Clientes Clientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactoArchivo> ContactoArchivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactoHistorico> ContactoHistorico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactoNota> ContactoNota { get; set; }

        public virtual Prospectos Prospectos { get; set; }
    }
}
