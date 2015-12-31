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
            _retValue.Add(new System.Web.Mvc.SelectListItem() { Text = "------", Value = Guid.Empty.ToString(), Selected = true });

            foreach (Entidades.CRM.CatPrefijos _prefijo in CatCache.Prefijos.OrderBy(x => x.orden).ToList())
            {
                _retValue.Add(new System.Web.Mvc.SelectListItem() { Text = _prefijo.prefijo, Value = _prefijo.id.ToString() });
            }


            return _retValue;
        }


        public static List<System.Web.Mvc.SelectListItem> ListaOrigenes()
        {
            List<System.Web.Mvc.SelectListItem> _retValue = new List<System.Web.Mvc.SelectListItem>();
            _retValue.Add(new System.Web.Mvc.SelectListItem() { Text = "------", Value = Guid.Empty.ToString(), Selected = true });

            foreach (Entidades.CRM.CatOrigenes _origen in CatCache.Origenes)
            {
                _retValue.Add(new System.Web.Mvc.SelectListItem() { Text = _origen.origen, Value = _origen.id.ToString() });
            }


            return _retValue;
        }


        public static List<System.Web.Mvc.SelectListItem> ListaIndustria()
        {
            List<System.Web.Mvc.SelectListItem> _retValue = new List<System.Web.Mvc.SelectListItem>();
            _retValue.Add(new System.Web.Mvc.SelectListItem() { Text = "------", Value = Guid.Empty.ToString(), Selected = true });

                foreach (Entidades.CRM.CatIndustrias _industria in CatCache.Industrias)
                {
                    _retValue.Add(new System.Web.Mvc.SelectListItem() { Text = _industria.industria, Value = _industria.id.ToString() });
                }
            

            return _retValue;
        }


        public static List<System.Web.Mvc.SelectListItem> ListaEstatusProspecto()
        {
            List<System.Web.Mvc.SelectListItem> _retValue = new List<System.Web.Mvc.SelectListItem>();
            _retValue.Add(new System.Web.Mvc.SelectListItem() { Text = "------", Value = Guid.Empty.ToString(), Selected = true });

            foreach (Entidades.CRM.CatProspectoEstatus _estatus in CatCache.ProspectoEstatus)
            {
                _retValue.Add(new System.Web.Mvc.SelectListItem() { Text = _estatus.estatus, Value = _estatus.id.ToString() });
            }


            return _retValue;
        }
    }
}
