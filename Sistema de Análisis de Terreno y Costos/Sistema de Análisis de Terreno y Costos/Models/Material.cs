using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Models
{
    public class Material
    {
        private static readonly string RUTA = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db", "materiales.csv");
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Estado { get; set; }

        public Material() { }

        public void Crear(String nombre, decimal precio, String estado)
        {
            Nombre = nombre;
            Precio = precio;
            Estado = estado;

            String linea = $"{Nombre},{Precio},{Estado}";

            // Crear el directorio si no existe
            string directorio = Path.GetDirectoryName(RUTA);
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            File.AppendAllText(RUTA, linea + Environment.NewLine);

        }

        public List<Material> Listar()
        {

            List<Material> materiales = new List<Material>();
            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);
                foreach (var linea in lineas)
                {
                    var datos = linea.Split(',');
                    if (datos.Length == 3)
                    {
                        String nombre = datos[0];
                        decimal precio = decimal.Parse(datos[1]);
                        String estado = datos[2];
                        Material material = new Material();
                        material.Nombre = nombre;
                        material.Precio = precio;
                        material.Estado = estado;
                        materiales.Add(material);
                    }
                }
            }
            return materiales;

        }

        public void Eliminar(String nombre)
        {
            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);
                var lineasActualizadas = lineas.Where(linea => !linea.StartsWith(nombre + ",")).ToArray();
                File.WriteAllLines(RUTA, lineasActualizadas);
            }
        }

        public void Actualizar(String nombre, decimal precio, String estado)
        {
            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);
                for (int i = 0; i < lineas.Length; i++)
                {
                    var datos = lineas[i].Split(',');
                    if (datos.Length == 3 && datos[0] == nombre)
                    {
                        lineas[i] = $"{nombre},{precio},{estado}";
                        break;
                    }
                }
                File.WriteAllLines(RUTA, lineas);
            }
        }
    }
}
