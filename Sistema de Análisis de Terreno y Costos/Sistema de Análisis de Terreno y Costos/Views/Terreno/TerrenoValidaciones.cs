using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Views.Terreno
{
    public static class TerrenoValidaciones
    {
        public static string ValidarCoordenadas(
            string xTexto, string yTexto, string zTexto,
            out double x, out double y, out double z)
        {
            x = y = z = 0;
            if (!double.TryParse(xTexto?.Trim(), out x))
                return "El valor de X no es válido.";
            if (!double.TryParse(yTexto?.Trim(), out y))
                return "El valor de Y no es válido.";
            if (!double.TryParse(zTexto?.Trim(), out z))
                return "El valor de Z no es válido.";
            return string.Empty;
        }
    }
}
