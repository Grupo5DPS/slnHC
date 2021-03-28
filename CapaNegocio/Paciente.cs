using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class Paciente : Interfaces.IPaciente
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

        public string[] Actualizar(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        //public string[] Agregar(PacienteE paciente 
        public string[] Agregar(string idP, string nombre, string apellidos, 
                      string fechaNacimiento, string sexo, string estadoCivil, 
                    string ocupacion, string direccion, string telefono)
        {
            //DataRow fila = datos.TraerDataRow("spAgregarPaciente", paciente.idP, paciente.nombre, paciente.apellidos
            //                        , paciente.fechaNacimiento, paciente.sexo, paciente.estadoCivil
            //                        , paciente.ocupacion, paciente.direccion, paciente.telefono);

            DataRow fila = datos.TraerDataRow("spAgregarPaciente", idP, nombre, apellidos
                                    , fechaNacimiento, sexo, estadoCivil
                                    , ocupacion, direccion, telefono);

            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);

            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }

        public DataSet buscar(string texto, string criterio)
        {
            throw new NotImplementedException();
        }

        public string[] Eliminar(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarTPaciente");
        }
    }
}
