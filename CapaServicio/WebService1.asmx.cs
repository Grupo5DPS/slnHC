using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaEntidad;
using CapaNegocio;
using System.Data;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //---------------------------------- PACIENTE ------------------------------------------

        [WebMethod(Description = "Listar pacientes")]
        public DataSet Listar()
        {
            Paciente pacientee = new Paciente();
            return pacientee.Listar();
        }
        /*
        [WebMethod(Description = "Buscar pacientes escuelas")]
        public DataSet Buscar(string texto, string criterio)
        {
            Escuela escuela = new Escuela();
            return escuela.buscar(texto, criterio);
        }
        
        [WebMethod(Description = "Listar escuelas")]
        public string[] Eliminar(string codEscuela)
        {
            Escuela escuela = new Escuela();
            return escuela.Eliminar(codEscuela);
        }
        */

        [WebMethod(Description = "Agregar paciente")]
        public string[] Agregar(string idP, string nombre, string apellidos
                                    , string fechaNacimiento, string sexo, string estadoCivil
                                    , string ocupacion, string direccion, string telefono)
        { 
            //PacienteE paciente = new PacienteE();
            Paciente pacientee = new Paciente();
            return pacientee.Agregar(idP, nombre, apellidos
                                    , fechaNacimiento, sexo, estadoCivil
                                    , ocupacion, direccion, telefono);
        }

        /*
         
        [WebMethod(Description = "Listar escuelas")]
        public string[] Actualizar(string codEscuela, string Escuela)
        {
            Escuela escuela = new Escuela();
            return escuela.Actualizar(codEscuela, Escuela);
        }
        */


        //---------------------------------- HOSPITAL ------------------------------------------

        [WebMethod(Description = "Listar hospitales")]
        public DataSet ListarHo()
        {
            Paciente pacientee = new Paciente();
            return pacientee.Listar();
        }



        [WebMethod(Description = "Agregar hospitales")]
        public string[] AgregarHo(string idHo, string descricion, string director,
                      string direccion, string contacto, string correo)
        {
            Hospital hospitall = new Hospital();
            return hospitall.Agregar(idHo, descricion, director,
                      direccion, contacto, correo);
        }


        //---------------------------------- HISTORIA ------------------------------------------

        [WebMethod(Description = "Listar historias")]
        public DataSet ListarHi()
        {
            Historia historiaa = new Historia();
            return historiaa.Listar();
        }



        [WebMethod(Description = "Agregar historia")]
        public string[] AgregarHi(string idH, string detalle, string nroExpediente, string Antecedente,
                                    string peso, string talla, string motivoConsulta, string sintomas,
                                    string adicciones, string procedimiento, string idP, string idD,
                                    string idU, string idHo, string fechaRegistro)
        {
            Historia historiaa = new Historia();
            return historiaa.Agregar(idH, detalle, nroExpediente, Antecedente,
                                    peso, talla, motivoConsulta, sintomas,
                                    adicciones, procedimiento, idP, idD,
                                    idU, idHo, fechaRegistro);
        }

    }

}
