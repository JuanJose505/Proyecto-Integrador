using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Repository
{
    public interface ITerrenoRepository
    {
        IReadOnlyList<PuntoTerreno> ObtenerTodos();
        void Agregar(PuntoTerreno punto);
        void Eliminar(int indice);
        void Limpiar();
    }
}
