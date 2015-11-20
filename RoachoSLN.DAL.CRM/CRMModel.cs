namespace RoachoSLN.DAL.CRM
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Entidades.CRM;

    public partial class CRMModel : DbContext
    {
        public CRMModel()
            : base("name=CRM")
        {
        }

        public virtual DbSet<CatEstados> CatEstados { get; set; }
        public virtual DbSet<CatIndustrias> CatIndustrias { get; set; }
        public virtual DbSet<CatOrigenes> CatOrigenes { get; set; }
        public virtual DbSet<CatPaises> CatPaises { get; set; }
        public virtual DbSet<CatPrefijos> CatPrefijos { get; set; }        
        public virtual DbSet<CatProspectoEstatus> CatProspectoEstatus { get; set; }
        public virtual DbSet<ClienteArchivo> ClienteArchivo { get; set; }
        public virtual DbSet<ClienteContacto> ClienteContacto { get; set; }
        public virtual DbSet<ClienteHistorico> ClienteHistorico { get; set; }
        public virtual DbSet<ClienteNota> ClienteNota { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ContactoArchivo> ContactoArchivo { get; set; }
        public virtual DbSet<ContactoHistorico> ContactoHistorico { get; set; }
        public virtual DbSet<ContactoNota> ContactoNota { get; set; }
        public virtual DbSet<Contactos> Contactos { get; set; }
        public virtual DbSet<ProspectoArchivo> ProspectoArchivo { get; set; }
        public virtual DbSet<ProspectoHistorico> ProspectoHistorico { get; set; }
        public virtual DbSet<ProspectoNota> ProspectoNota { get; set; }
        public virtual DbSet<Prospectos> Prospectos { get; set; }
        public virtual DbSet<TareaRecordatorio> TareaRecordatorio { get; set; }
        public virtual DbSet<TareaRepetir> TareaRepetir { get; set; }
        public virtual DbSet<Tareas> Tareas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatEstados>()
                .HasMany(e => e.Clientes)
                .WithOptional(e => e.CatEstados)
                .HasForeignKey(e => e.estadofacturacion);

            modelBuilder.Entity<CatEstados>()
                .HasMany(e => e.Clientes1)
                .WithOptional(e => e.CatEstados1)
                .HasForeignKey(e => e.estadoenvio);

            modelBuilder.Entity<CatEstados>()
                .HasMany(e => e.Contactos)
                .WithOptional(e => e.CatEstados)
                .HasForeignKey(e => e.estado);

            modelBuilder.Entity<CatEstados>()
                .HasMany(e => e.Prospectos)
                .WithOptional(e => e.CatEstados)
                .HasForeignKey(e => e.estado);

            modelBuilder.Entity<CatIndustrias>()
                .HasMany(e => e.Clientes)
                .WithOptional(e => e.CatIndustrias)
                .HasForeignKey(e => e.idindustria);

            modelBuilder.Entity<CatIndustrias>()
                .HasMany(e => e.Prospectos)
                .WithOptional(e => e.CatIndustrias)
                .HasForeignKey(e => e.idindustria);

            modelBuilder.Entity<CatOrigenes>()
                .HasMany(e => e.Clientes)
                .WithOptional(e => e.CatOrigenes)
                .HasForeignKey(e => e.idorigen);

            modelBuilder.Entity<CatOrigenes>()
                .HasMany(e => e.Contactos)
                .WithOptional(e => e.CatOrigenes)
                .HasForeignKey(e => e.idorigen);

            modelBuilder.Entity<CatOrigenes>()
                .HasMany(e => e.Prospectos)
                .WithOptional(e => e.CatOrigenes)
                .HasForeignKey(e => e.idorigen);

            modelBuilder.Entity<CatPaises>()
                .Property(e => e.cod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CatPaises>()
                .Property(e => e.tel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CatPaises>()
                .HasMany(e => e.CatEstados)
                .WithOptional(e => e.CatPaises)
                .HasForeignKey(e => e.idpais);

            modelBuilder.Entity<CatPrefijos>()
                .Property(e => e.prefijo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CatPrefijos>()
                .HasMany(e => e.Contactos)
                .WithOptional(e => e.CatPrefijos)
                .HasForeignKey(e => e.idprefijo);

            modelBuilder.Entity<CatPrefijos>()
                .HasMany(e => e.Prospectos)
                .WithOptional(e => e.CatPrefijos)
                .HasForeignKey(e => e.idprefijo);

            modelBuilder.Entity<CatProspectoEstatus>()
                .HasMany(e => e.Prospectos)
                .WithOptional(e => e.CatProspectoEstatus)
                .HasForeignKey(e => e.estatus);

            modelBuilder.Entity<ClienteNota>()
                .Property(e => e.nota)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.ingresos)
                .HasPrecision(12, 4);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.codigopostalfacturacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.codigopostalenvio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.textoextra)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.ClienteArchivo)
                .WithOptional(e => e.Clientes)
                .HasForeignKey(e => e.idProspecto);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.ClienteContacto)
                .WithOptional(e => e.Clientes)
                .HasForeignKey(e => e.idProspecto);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.ClienteHistorico)
                .WithOptional(e => e.Clientes)
                .HasForeignKey(e => e.idProspecto);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.ClienteNota)
                .WithOptional(e => e.Clientes)
                .HasForeignKey(e => e.idProspecto);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.Clientes1)
                .WithOptional(e => e.Clientes2)
                .HasForeignKey(e => e.cuentaprincipal);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.Contactos)
                .WithOptional(e => e.Clientes)
                .HasForeignKey(e => e.cuenta);

            modelBuilder.Entity<ContactoNota>()
                .Property(e => e.nota)
                .IsUnicode(false);

            modelBuilder.Entity<Contactos>()
                .Property(e => e.codigopostal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Contactos>()
                .Property(e => e.textoextra)
                .IsUnicode(false);

            modelBuilder.Entity<Contactos>()
                .HasMany(e => e.ClienteContacto)
                .WithOptional(e => e.Contactos)
                .HasForeignKey(e => e.idcontacto);

            modelBuilder.Entity<Contactos>()
                .HasMany(e => e.ContactoArchivo)
                .WithOptional(e => e.Contactos)
                .HasForeignKey(e => e.idContacto);

            modelBuilder.Entity<Contactos>()
                .HasMany(e => e.ContactoHistorico)
                .WithOptional(e => e.Contactos)
                .HasForeignKey(e => e.idContacto);

            modelBuilder.Entity<Contactos>()
                .HasMany(e => e.ContactoNota)
                .WithOptional(e => e.Contactos)
                .HasForeignKey(e => e.idContacto);

            modelBuilder.Entity<ProspectoNota>()
                .Property(e => e.nota)
                .IsUnicode(false);

            modelBuilder.Entity<Prospectos>()
                .Property(e => e.codigopostal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Prospectos>()
                .Property(e => e.ingresos)
                .HasPrecision(12, 4);

            modelBuilder.Entity<Prospectos>()
                .Property(e => e.textoextra)
                .IsUnicode(false);

            modelBuilder.Entity<Prospectos>()
                .HasMany(e => e.Clientes)
                .WithOptional(e => e.Prospectos)
                .HasForeignKey(e => e.lead);

            modelBuilder.Entity<Prospectos>()
                .HasMany(e => e.Contactos)
                .WithOptional(e => e.Prospectos)
                .HasForeignKey(e => e.lead);

            modelBuilder.Entity<Prospectos>()
                .HasMany(e => e.ProspectoArchivo)
                .WithOptional(e => e.Prospectos)
                .HasForeignKey(e => e.idProspecto);

            modelBuilder.Entity<Prospectos>()
                .HasMany(e => e.ProspectoHistorico)
                .WithOptional(e => e.Prospectos)
                .HasForeignKey(e => e.idProspecto);

            modelBuilder.Entity<Prospectos>()
                .HasMany(e => e.ProspectoNota)
                .WithOptional(e => e.Prospectos)
                .HasForeignKey(e => e.idProspecto);

            modelBuilder.Entity<Tareas>()
                .Property(e => e.texto)
                .IsUnicode(false);

            modelBuilder.Entity<Tareas>()
                .HasMany(e => e.TareaRecordatorio)
                .WithOptional(e => e.Tareas)
                .HasForeignKey(e => e.idtarea);

            modelBuilder.Entity<Tareas>()
                .HasMany(e => e.TareaRepetir)
                .WithOptional(e => e.Tareas)
                .HasForeignKey(e => e.idtarea);
        }
    }
}
