using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoachoSLN.BOL.CRM
{
    public class Prospectos
    {

        public static List<RoachoSLN.Entidades.CRM.Prospectos> Lista()
        {
            using(DAL.CRM.CRMModel context=new DAL.CRM.CRMModel())
            {
                return context.Prospectos.ToList();
            }
        }

        public static RoachoSLN.Entidades.CRM.Prospectos Obtener(Guid id,bool withreferences=false)
        {
            using (DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
            {
                context.Configuration.ProxyCreationEnabled = false;
                if (withreferences)
                {
                    return context.Prospectos.Include("ProspectoHistorico").Include("ProspectoNota").Where(x => x.id == id).FirstOrDefault();
                }
                else {
                    return context.Prospectos.Where(x => x.id == id).FirstOrDefault();
                }
            }
        }

        public static bool Guardar(Entidades.CRM.Prospectos _prospecto )
        {
            bool nuevo = _prospecto.id == Guid.Empty ? true : false;
            bool _retValue=false;

            _prospecto.id= _prospecto.id == Guid.Empty ? Guid.NewGuid() : _prospecto.id;
            _prospecto.idindustria = _prospecto.idindustria == Guid.Empty ? null : _prospecto.idindustria;
            _prospecto.idorigen = _prospecto.idorigen == Guid.Empty ? null : _prospecto.idorigen;
            _prospecto.idprefijo = _prospecto.idprefijo == Guid.Empty ? null : _prospecto.idprefijo;
            _prospecto.estatus =  _prospecto.estatus == Guid.Empty ? null : _prospecto.estatus;            
            _prospecto.fec_reg = _prospecto.fec_reg==null ? DateTime.Now : _prospecto.fec_reg;

            _prospecto.fec_mod = DateTime.Now;

            
            Entidades.CRM.ProspectoHistorico _historial = new Entidades.CRM.ProspectoHistorico();
            _historial.idProspecto = _prospecto.id;
            _historial.fecha = DateTime.Now;

            using (DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
            {
                 if (nuevo)
                    context.Entry(_prospecto).State = System.Data.Entity.EntityState.Added;                    
                 else
                    context.Entry(_prospecto).State = System.Data.Entity.EntityState.Modified;

                if (!nuevo)
                {
                    Entidades.CRM.Prospectos source = context.Prospectos.Where(x => x.id == _prospecto.id).FirstOrDefault();
                    //Log = Diff(source, _prospecto);
                    _historial.movimiento = "Actualizacion de datos";
                }
                else
                {
                    _historial.movimiento = "Creacion del Prospecto";
                }
                context.Entry(_historial).State = System.Data.Entity.EntityState.Added;

                if (context.SaveChanges() > 0)
                {
                    _retValue = true;
                }

                

            }
            return _retValue;
        }

        public static bool AgregarNota(string nota,Guid idProspecto,Guid idUsuario)
        {
            bool _retValue = false;
            Entidades.CRM.ProspectoNota _nota = new Entidades.CRM.ProspectoNota() ;
            _nota.nota = nota;
            _nota.idProspecto = idProspecto;
            _nota.fecha = DateTime.Now;
            _nota.usuario = idUsuario;
            using (DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
            {
                context.Entry(_nota).State = System.Data.Entity.EntityState.Added;

                if (context.SaveChanges() > 0)
                {
                    _retValue = true;
                }
            }
            return _retValue;
        }


     

        public static string Diff(Entidades.CRM.Prospectos Source, Entidades.CRM.Prospectos Target)
        {
            if (Source != Target)
            {
                
            }
            return "";
        }


    }
}
