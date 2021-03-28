using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;

namespace CapaNegocio.Interfaces
{
    interface IHospital
    {
        //Declara metodos para una clase (Herencia y polimorfismo)
        DataSet Listar();
        string[] Agregar(string idHo, string descricion, string director,
                      string direccion, string contacto, string correo);
        //string[] Eliminar(HistoriaE historia);
        //string[] Actualizar(HistoriaE historia);
        //DataSet buscar(string texto, string criterio);
    }
}
