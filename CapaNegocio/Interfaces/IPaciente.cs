    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;

namespace CapaNegocio.Interfaces
{
    interface IPaciente
    {
        //Declara metodos para una clase (Herencia y polimorfismo)
        DataSet Listar();
        string[] Agregar(string idP, string nombre, string apellidos, 
                      string fechaNacimiento, string sexo, string estadoCivil, 
                    string ocupacion, string direccion, string telefono);
        //string[] Agregar(PacienteE paciente);
        //string[] Agregar(PacienteE idP, PacienteE nombre, PacienteE apellidos, 
        //              PacienteE fechaNacimiento, PacienteE sexo, PacienteE estadoCivil, 
        //            PacienteE ocupacion, PacienteE direccion, PacienteE telefono);
        //string[] Eliminar(Paciente paciente);
        //string[] Actualizar(Paciente paciente);
        //DataSet buscar(string texto, string criterio);
    }
}
