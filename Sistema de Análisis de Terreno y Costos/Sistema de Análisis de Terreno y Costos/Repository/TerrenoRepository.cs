using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Repository
{
    public class TerrenoRepository : ITerrenoRepository
    {
        private readonly List<PuntoTerreno> _puntos = new List<PuntoTerreno>();

        public IReadOnlyList<PuntoTerreno> ObtenerTodos() => _puntos.AsReadOnly();

        public void Agregar(PuntoTerreno punto) => _puntos.Add(punto);

        public void Eliminar(int indice) => _puntos.RemoveAt(indice);

        public void Limpiar() => _puntos.Clear();
    }
}
