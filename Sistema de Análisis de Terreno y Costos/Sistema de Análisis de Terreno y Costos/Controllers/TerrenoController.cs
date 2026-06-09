using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using Sistema_de_Análisis_de_Terreno_y_Costos.Repository;
using Sistema_de_Análisis_de_Terreno_y_Costos.Views.Terreno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Controllers
{
    /// <summary>
    /// Coordina las acciones del usuario sobre los puntos del terreno.
    /// La vista solo llama métodos de este controller; nunca toca el repository directamente.
    /// </summary>
    public class TerrenoController
    {
        private readonly ITerrenoRepository _repo;

        public TerrenoController(ITerrenoRepository repo) 
        {
            _repo = repo;
        }

        public IReadOnlyList<PuntoTerreno> ObtenerPuntos() =>
            _repo.ObtenerTodos();

        /// <summary>
        /// Valida y agrega un punto. Devuelve mensaje de error o string vacío si OK.
        /// </summary>
        public string AgregarPunto(string xTexto, string yTexto, string zTexto)
        {
            var error = TerrenoValidaciones.ValidarCoordenadas(
                xTexto, yTexto, zTexto,
                out double x, out double y, out double z);

            if (!string.IsNullOrEmpty(error))
                return error;

            // Verificar duplicado (misma X e Y)
            if (_repo.ObtenerTodos().Any(p => p.X == x && p.Y == y))
                return $"Ya existe un punto con X={x} e Y={y}.";

            _repo.Agregar(new PuntoTerreno(x, y, z));
            return string.Empty;
        }

        /// <summary>Elimina el punto en la posición indicada (0-based).</summary>
        public string EliminarPunto(int indice)
        {
            try
            {
                _repo.Eliminar(indice);
                return string.Empty;
            }
            catch (ArgumentOutOfRangeException)
            {
                return "Seleccione un punto válido para eliminar.";
            }
        }

        public void LimpiarTodo() => _repo.Limpiar();
    }

}
