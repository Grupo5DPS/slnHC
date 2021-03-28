using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class Hospital : Interfaces.IHospital
    {
        //llamar a la capa de datos 
        private Datos datos = new DatosSQL();
        //Propiedad de solo lectura para el mensaje del PAT
        string mensaje;
        public string Mensaje
        {
            get
            {
                return mensaje;
            }
        }

        public string[] Actualizar(HospitalE historia)
        {
            throw new NotImplementedException();
        }

        public string[] Agregar(string idHo, string descricion, string director,
                      string direccion, string contacto, string correo)
        {
            DataRow fila = datos.TraerDataRow("spAgregarHospital", idHo, descricion, director,
                      direccion, contacto, correo);
            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);

            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }

        public string[] Agregar(string idP, HospitalE historia)
        {
            throw new NotImplementedException();
        }

        public DataSet buscar(string texto, string criterio)
        {
            throw new NotImplementedException();
        }

        public string[] Eliminar(HospitalE historia)
        {
            throw new NotImplementedException();
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarTPaciente");
        }
    }
}
