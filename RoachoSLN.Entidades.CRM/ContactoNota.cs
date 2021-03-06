namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.ContactoNota")]
    public partial class ContactoNota
    {
        public int id { get; set; }

        public Guid? idContacto { get; set; }

        [Column(TypeName = "text")]
        public string nota { get; set; }

        public Guid? usuario { get; set; }

        public DateTime? fecha { get; set; }

        public virtual Contactos Contactos { get; set; }
    }
}
