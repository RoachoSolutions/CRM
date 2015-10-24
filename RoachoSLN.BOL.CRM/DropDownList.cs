using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoachoSLN.BOL.CRM
{
    public class DropDownList
    {
        public static List<System.Web.Mvc.SelectListItem> ListaPrefijos()
        {
            List<System.Web.Mvc.SelectListItem> _retValue = new List<System.Web.Mvc.SelectListItem>();

            using (DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
            {
                foreach(Entidades.CRM.CatPrefijos _prefijo in context.CatPrefijos.OrderBy(x=>x.orden).ToList())
                {
                    _retValue.Add(new System.Web.Mvc.SelectListItem() { Text = _prefijo.prefijo, Value = _prefijo.id.ToString() });
                }
            }

            return _retValue;
        }


        public static List<System.Web.Mvc.SelectListItem> ListaOrigenes()
        {
            List<System.Web.Mvc.SelectListItem> _retValue = new List<System.Web.Mvc.SelectListItem>();

            using (DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
            {
                foreach (Entidades.CRM.CatOrigenes _origen in context.CatOrigenes.ToList())
                {
                    _retValue.Add(new System.Web.Mvc.SelectListItem() { Text = _origen.origen, Value = _origen.id.ToString() });
                }
            }

            return _retValue;
        }


        public static List<System.Web.Mvc.SelectListItem> ListaIndustria()
        {
            List<System.Web.Mvc.SelectListItem> _retValue = new List<System.Web.Mvc.SelectListItem>();

            using (DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
            {
                foreach (Entidades.CRM.CatIndustrias _industria in context.CatIndustrias.ToList())
                {
                    _retValue.Add(new System.Web.Mvc.SelectListItem() { Text = _industria.industria, Value = _industria.id.ToString() });
                }
            }

            return _retValue;
        }
    }
}
