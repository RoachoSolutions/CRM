using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoachoSolutions.Utils
{
    public class DateTimeUtils
    {
        public static string TiempoTrascurrido(DateTime Start,DateTime End)
        {
            TimeSpan diff = End - Start;
            if (diff.Days == 0)
            {
                return "hoy";
            }
            return "ayer";
        }
    }
}
