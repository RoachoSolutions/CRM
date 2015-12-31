using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoachoSLN.Utils
{
    public class DateTimeUtils
    {
        public static string TiempoTrascurrido(DateTime? Start, DateTime? End)
        {
            if (!Start.HasValue)
                throw new NullReferenceException("Fecha de inicio nula");
            if (!End.HasValue)
                throw new NullReferenceException("Fecha Final nula");


            TimeSpan diff = End.Value - Start.Value;
            if (diff.Days == 0)
            {
                return "hoy";
            }
            return "ayer";
        }
    }
}
