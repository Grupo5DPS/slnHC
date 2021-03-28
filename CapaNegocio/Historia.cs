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
    public class Historia : Interfaces.IHistoria
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


        public string[] Agregar(string idH, string detalle, string nroExpediente, string Antecedente, 
                                string peso, string talla, string motivoConsulta, string sintomas, 
                                string adicciones, string procedimiento, string idP, string idD, 
                                string idU, string idHo, string fechaRegistro)
        {
            DataRow fila = datos.TraerDataRow("spAgregarHistoria", idH, detalle, nroExpediente, Antecedente,
                                peso, talla, motivoConsulta, sintomas,
                                adicciones, procedimiento, idP, idD,
                                idU, idHo, fechaRegistro);
            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);

            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }


        public DataSet Listar()
        {
            throw new NotImplementedException();
        }
    }
}
