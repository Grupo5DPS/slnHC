using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization; // Serializar la clase p gaeaeae

namespace CapaEntidad
{
    [DataContract]
    public class HistoriaE
    {
        [DataMember]
        public string idH { get; set; }

        [DataMember]
        public string detalle { get; set; }

        [DataMember]
        public string dirnroExpediente { get; set; }

        [DataMember]
        public string Antecedente { get; set; }

        [DataMember]
        public string peso { get; set; }

        [DataMember]
        public string talla { get; set; }

        [DataMember]
        public string motivoConsulta { get; set; }

        [DataMember]
        public string sintomas { get; set; }

        [DataMember]
        public string adicciones { get; set; }

        [DataMember]
        public string procedimiento { get; set; }

        [DataMember]
        public string idD { get; set; }

        [DataMember]
        public string idU { get; set; }

        [DataMember]
        public string idHo { get; set; }

        [DataMember]
        public string fecharegistro { get; set; }
    }
}

