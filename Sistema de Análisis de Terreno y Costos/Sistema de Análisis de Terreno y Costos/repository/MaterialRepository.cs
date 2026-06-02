using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Análisis_de_Terreno_y_Costos.Enums;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.repository
{
    public class MaterialRepository
    {
        private static readonly string RUTA = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db", "materiales.csv");
        MaterialModels material = new MaterialModels();
        public void Crear(String nombre, decimal precio, string estado)
        {
            material.Nombre = nombre;
            material.Precio = precio;
            material.Estado = estado;

            String linea = $"{material.Nombre},{material.Precio},{material.Estado}";

            // Crear el directorio si no existe
            string directorio = Path.GetDirectoryName(RUTA);
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            File.AppendAllText(RUTA, linea + Environment.NewLine);

        }

        public List<MaterialModels> Listar()
        {

            List<MaterialModels> materiales = new List<MaterialModels>();
            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);
                foreach (var linea in lineas)
                {
                    var datos = linea.Split(',');
                    if (datos.Length == 3)
                    {
                        String nombre = datos[0];
                        decimal precio;

                        if (decimal.TryParse(datos[1], out precio))
                        {
                                String estado = datos[2];
                                MaterialModels material = new MaterialModels();
                                material.Nombre = nombre;
                                material.Precio = precio;
                                material.Estado = estado;
                                materiales.Add(material);
                            
                        }

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

        public void Actualizar(String nombre, decimal precio,String estado)
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

        // FUNCION PARA BUSCAR POR NOMBRE DEL MATERIAL //
        public MaterialModels BuscarporMaterial(string nombre)
        {
         
            foreach (var material in Listar())
            {
                if (material.Nombre == nombre)
                {
                    return material;
                }
            }
            return null;
        }

    }
}
