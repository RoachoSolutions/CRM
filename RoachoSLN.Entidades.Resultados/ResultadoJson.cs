using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RoachoSLN.Entidades.Resultados
{
    [DataContract]
    public class ResultadoJson
    {
        [DataMember]
        public string id { get; set; }

        [DataMember]
        public int status { get; set; }

        [DataMember]
        public string error { get; set; }
    }
}
