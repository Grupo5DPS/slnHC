using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CapaNegocio.Interfaces
{
    interface IPaciente
    {
        //Declara metodos para una clase (Herencia y polimorfismo)
        DataSet Listar();
        string[] Agregar(string codEscuela, string escuela);
        string[] Eliminar(string codEscuela);
        string[] Actualizar(string codEscuela, string Escuela);
        DataSet buscar(string texto, string criterio);
    }
}
