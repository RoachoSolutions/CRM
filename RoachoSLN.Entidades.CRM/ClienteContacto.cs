namespace RoachoSLN.Entidades.CRM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoachoCRM.ClienteContacto")]
    public partial class ClienteContacto
    {
        public int id { get; set; }

        public Guid? idProspecto { get; set; }

        public Guid? idcontacto { get; set; }

        public Guid? usuario { get; set; }

        public DateTime? fecha { get; set; }

        public virtual Contactos Contactos { get; set; }

        public virtual Clientes Clientes { get; set; }
    }
}
