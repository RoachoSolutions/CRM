namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.ContactoArchivo")]
    public partial class ContactoArchivo
    {
        public int id { get; set; }

        public Guid? idContacto { get; set; }

        [StringLength(100)]
        public string archivo { get; set; }

        public Guid? usuario { get; set; }

        public DateTime? fecha { get; set; }

        public virtual Contactos Contactos { get; set; }
    }
}
