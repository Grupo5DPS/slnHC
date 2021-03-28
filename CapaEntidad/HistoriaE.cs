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
        public string idHo { get; set; }

        [DataMember]
        public string descripcion { get; set; }

        [DataMember]
        public string director { get; set; }

        [DataMember]
        public string direccion { get; set; }

        [DataMember]
        public string contacto { get; set; }

        [DataMember]
        public string correo { get; set; }
    }
}
