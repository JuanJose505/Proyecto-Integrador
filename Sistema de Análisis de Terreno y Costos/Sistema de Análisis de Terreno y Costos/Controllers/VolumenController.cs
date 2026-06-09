using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using Sistema_de_Análisis_de_Terreno_y_Costos.Repository;
//using Sistema_de_Análisis_de_Terreno_y_Costos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Controllers
{
    //public class TerrenoController
    //{
    //    private readonly ITerrenoRepository _repo;
    //    private readonly List<PuntoTerreno> _puntosEnMemoria = [];

    //    public IReadOnlyList<PuntoTerreno> Puntos => _puntosEnMemoria;

    //    public TerrenoController(ITerrenoRepository repo)
    //    {
    //        _repo = repo;
    //        _puntosEnMemoria.AddRange(_repo.ObtenerPuntos());
    //    }

    //    public string AgregarPunto(string xTexto, string yTexto, string zTexto)
    //    {
    //        var error = TerrenoValidaciones.ValidarCoordenadas(xTexto, yTexto, zTexto,
    //            out double x, out double y, out double z);
    //        if (!string.IsNullOrEmpty(error)) return error;

    //        _puntosEnMemoria.Add(new PuntoTerreno(x, y, z));
    //        _repo.GuardarPuntos(_puntosEnMemoria);
    //        return string.Empty;
    //    }

    //    public void EliminarUltimo()
    //    {
    //        if (_puntosEnMemoria.Count == 0) return;
    //        _puntosEnMemoria.RemoveAt(_puntosEnMemoria.Count - 1);
    //        _repo.GuardarPuntos(_puntosEnMemoria);
    //    }

    //    public void Limpiar()
    //    {
    //        _puntosEnMemoria.Clear();
    //        _repo.Limpiar();
    //    }
    }
}
