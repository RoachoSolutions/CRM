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
            RoachoSLN.Entidades.CRM.Prospectos _retvalue = new Entidades.CRM.Prospectos();
            using (DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
            {
                context.Configuration.ProxyCreationEnabled = false;              
              
                _retvalue= context.Prospectos.Where(x => x.id == id).FirstOrDefault();

                if (withreferences)
                {
                    _retvalue.ProspectoNota = context.ProspectoNota.Where(x=>x.idProspecto== id).OrderByDescending(x=>x.fecha).Take(5).ToList();
                }
              
                return _retvalue;
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

        public static bool AgregarNota(string nota, Guid idProspecto, Guid idUsuario)
        {
            bool _retValue = false;
            Entidades.CRM.ProspectoNota _nota = new Entidades.CRM.ProspectoNota();
            _retValue = AgregarNota(nota, idProspecto, idUsuario, out _nota);
            return _retValue;
        }


        public static bool AgregarNota(string nota,Guid idProspecto,Guid idUsuario, out Entidades.CRM.ProspectoNota resultado)
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
            resultado = _nota;
            return _retValue;
        }

        public static List<Entidades.CRM.ProspectoNota> ObtenerNotas(Guid idProspectos,int idnota,bool desc = true,int limit =5)
        {
            using (DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
            {
                if (desc)
                    return context.ProspectoNota.Where(x => x.id < idnota).OrderByDescending(x => x.fecha).Take(limit).ToList();
                else
                    return context.ProspectoNota.Where(x => x.id > idnota).OrderBy(x => x.fecha).Take(limit).ToList();
            }
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
