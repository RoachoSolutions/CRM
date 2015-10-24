using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoachoSLN.BOL.CRM
{
    public class Clientes
    {
        public static List<Entidades.CRM.Clientes> Obtener()
        {
            using(DAL.CRM.CRMModel context=new DAL.CRM.CRMModel())
            {
                return context.Clientes.ToList();
            }
        }
    }
}
