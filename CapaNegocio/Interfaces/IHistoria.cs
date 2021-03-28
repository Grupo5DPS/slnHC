using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;

namespace CapaNegocio.Interfaces
{
    interface IHistoria
    {
        //Declara metodos para una clase (Herencia y polimorfismo)
        DataSet Listar();
        string[] Agregar(HistoriaE historia);
        string[] Eliminar(HistoriaE historia);
        string[] Actualizar(HistoriaE historia);
        DataSet buscar(string texto, string criterio);
    }
}
