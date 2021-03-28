using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization; // Serializar la clase p gaeaeae

namespace CapaEntidad
{   
    [DataContract]
    public class PacienteE
    {
       [DataMember]
        public string idP { get; set; }

        [DataMember]
        public string nombre { get; set; }

        [DataMember]
        public string apellidos { get; set; }

        [DataMember]
        public string fechaNacimiento { get; set; }

        [DataMember]
        public string sexo { get; set; }

        [DataMember]
        public string estadoCivil { get; set; }

        [DataMember]
        public string ocupacion { get; set; }

        [DataMember]
        public string direccion { get; set; }

        [DataMember]
        public string telefono { get; set; }
    }
}
