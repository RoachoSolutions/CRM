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

        public static RoachoSLN.Entidades.CRM.Prospectos Obtener(Guid id)
        {
            using (DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
            {
                return context.Prospectos.Where(x=>x.id== id).FirstOrDefault();
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
            using (DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
            {               
                 if(nuevo)
                    context.Entry(_prospecto).State = System.Data.Entity.EntityState.Added;
                 else
                    context.Entry(_prospecto).State = System.Data.Entity.EntityState.Modified;

                if (context.SaveChanges() > 0)
                {
                    _retValue = true;
                }
            }
            return _retValue;
        }


    }
}
