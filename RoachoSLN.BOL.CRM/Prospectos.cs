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

        public static bool Guardar(Entidades.CRM.Prospectos _prospecto )
        {
            bool _retValue=false;
            _prospecto.idindustria = _prospecto.idindustria == Guid.Empty ? null : _prospecto.idindustria;
            _prospecto.idorigen = _prospecto.idorigen == Guid.Empty ? null : _prospecto.idorigen;
            _prospecto.idprefijo = _prospecto.idprefijo == Guid.Empty ? null : _prospecto.idprefijo;
            _prospecto.estatus =  _prospecto.estatus == Guid.Empty ? null : _prospecto.estatus;
            using (DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
            {
                context.Entry(_prospecto).State = System.Data.Entity.EntityState.Added;
                if (context.SaveChanges() > 0)
                {
                    _retValue = true;
                }
            }
            return _retValue;
        }
    }
}
