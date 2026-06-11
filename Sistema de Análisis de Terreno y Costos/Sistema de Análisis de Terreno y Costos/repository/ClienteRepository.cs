using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;


namespace Sistema_de_Análisis_de_Terreno_y_Costos.repository
{
    public class ClienteRepository
    {
        private static readonly string RUTA = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db", "clientes.csv");
        ClienteModels modelo = new ClienteModels();

        public void Registrar(string nombre, string identificacion, string telefono, string correo)
        {
            modelo.Nombre = nombre;
            modelo.Identificacion = identificacion;
            modelo.Telefono = telefono;
            modelo.Correo = correo;

            string linea = $"{modelo.Nombre};{modelo.Identificacion};{modelo.Telefono};{modelo.Correo}";

            // Crear el directorio si no existe
            string directorio = Path.GetDirectoryName(RUTA);
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            File.AppendAllText(RUTA, linea + Environment.NewLine);

        }

        public List<ClienteModels> Listar()
        {

            List<ClienteModels> clientes = new List<ClienteModels>();
            if (File.Exists(RUTA))
            {
                var lineas = File.ReadAllLines(RUTA);
                foreach (var linea in lineas)
                {
                    var datos = linea.Split(';');
                    if (datos.Length == 4)
                    {
                        string nombre = datos[0];
                        string identificacion = datos[1];
                        string telefono = datos[2];
                        string correo = datos[3];
                        ClienteModels cliente = new ClienteModels();
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

        //FUNCION PARA BUSCAR USANDO EL ID DEL CLIENTE//
        public ClienteModels BuscarporID(string id)
        {
            foreach (var cliente in Listar())
            {
                if(cliente.Identificacion == id)
                {
                    return cliente;
                }
            }
            return null;
        }

    }
}
