using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Models
{
    public class Cliente
    {
        private static readonly string RUTA = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db", "clientes.csv");
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public Cliente() { }

        public void Registrar(String nombre, String identificacion, String telefono, String correo)
        {
            Nombre = nombre;
            Identificacion = identificacion;
            Telefono = telefono;
            Correo = correo;

            String linea = $"{Nombre},{Identificacion},{Telefono},{Correo}";

            // Crear el directorio si no existe
            string directorio = Path.GetDirectoryName(RUTA);
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            File.AppendAllText(RUTA, linea + Environment.NewLine);

        }

        public List<Cliente> Listar()
        {

            List<Cliente> clientes = new List<Cliente>();
            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);
                foreach (var linea in lineas)
                {
                    var datos = linea.Split(',');
                    if (datos.Length == 4)
                    {
                        String nombre = datos[0];
                        String identificacion = datos[1];
                        String telefono = datos[2];
                        String correo = datos[3];
                        Cliente cliente = new Cliente();
                        cliente.Nombre = nombre;
                        cliente.Identificacion = identificacion;
                        cliente.Telefono = telefono;
                        cliente.Correo = correo;
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }


    }
}
