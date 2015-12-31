using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace RoachoSLN.BOL.CRM
{
    public class CatCache
    {
        public static List<RoachoSLN.Entidades.CRM.CatOrigenes> Origenes
        {
            get
            {
                if (HttpContext.Current.Cache["CatOrigen"] != null)
                {
                    return (List<RoachoSLN.Entidades.CRM.CatOrigenes>)HttpContext.Current.Cache["CatOrigen"];
                }
                else
                {
                    List<RoachoSLN.Entidades.CRM.CatOrigenes> _retvalue = new List<Entidades.CRM.CatOrigenes>();
                    using (RoachoSLN.DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
                    {
                        context.Configuration.ProxyCreationEnabled = false;
                        _retvalue = context.CatOrigenes.ToList();
                        HttpContext.Current.Cache.Insert("CatOrigen", _retvalue, null, DateTime.Now.AddHours(1), Cache.NoSlidingExpiration);

                    }
                    return _retvalue;
                }
            }
        }

        public static List<RoachoSLN.Entidades.CRM.CatIndustrias> Industrias
        {
            get
            {
                if (HttpContext.Current.Cache["CatIndustria"] != null)
                {
                    return (List<RoachoSLN.Entidades.CRM.CatIndustrias>)HttpContext.Current.Cache["CatIndustria"];
                }
                else
                {
                    List<RoachoSLN.Entidades.CRM.CatIndustrias> _retvalue = new List<Entidades.CRM.CatIndustrias>();
                    using (RoachoSLN.DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
                    {
                        context.Configuration.ProxyCreationEnabled = false;
                        _retvalue = context.CatIndustrias.ToList();
                        HttpContext.Current.Cache.Insert("CatIndustria", _retvalue, null, DateTime.Now.AddHours(1), Cache.NoSlidingExpiration);
                    }
                    return _retvalue;
                }
            }
        }

        public static List<RoachoSLN.Entidades.CRM.CatPrefijos> Prefijos
        {
            get
            {
                if (HttpContext.Current.Cache["CatPrefijo"] != null)
                {
                    return (List<RoachoSLN.Entidades.CRM.CatPrefijos>)HttpContext.Current.Cache["CatCatPrefijoIndustria"];
                }
                else
                {
                    List<RoachoSLN.Entidades.CRM.CatPrefijos> _retvalue = new List<Entidades.CRM.CatPrefijos>();
                    using (RoachoSLN.DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
                    {
                        context.Configuration.ProxyCreationEnabled = false;
                        _retvalue = context.CatPrefijos.ToList();
                        HttpContext.Current.Cache.Insert("CatPrefijo", _retvalue, null, DateTime.Now.AddHours(1), Cache.NoSlidingExpiration);
                    }
                    return _retvalue;
                }
            }
        }


        public static List<RoachoSLN.Entidades.CRM.CatProspectoEstatus> ProspectoEstatus
        {
            get
            {
                if (HttpContext.Current.Cache["CatProspectoEstatus"] != null)
                {
                    return (List<RoachoSLN.Entidades.CRM.CatProspectoEstatus>)HttpContext.Current.Cache["CatProspectoEstatus"];
                }
                else
                {
                    List<RoachoSLN.Entidades.CRM.CatProspectoEstatus> _retvalue = new List<Entidades.CRM.CatProspectoEstatus>();
                    using (RoachoSLN.DAL.CRM.CRMModel context = new DAL.CRM.CRMModel())
                    {
                        context.Configuration.ProxyCreationEnabled = false;
                        _retvalue = context.CatProspectoEstatus.ToList();
                        HttpContext.Current.Cache.Insert("CatProspectoEstatus", _retvalue, null, DateTime.Now.AddHours(1), Cache.NoSlidingExpiration);
                    }
                    return _retvalue;
                }
            }
        }
    }
    
}
