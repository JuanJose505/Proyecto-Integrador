using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Análisis_de_Terreno_y_Costos.repository;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;


namespace Sistema_de_Análisis_de_Terreno_y_Costos.Controllers
{
    public class ClienteController
    {
        public String Registrar(String nombre, String identificacion, String telefono,String correo)
        {
            ClienteRepository cliente = new ClienteRepository();

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(identificacion) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(correo))
            {
                return "Todos los campos son obligatorios";
            }

            if (ExisteCliente(identificacion))
            {
                return "El cliente ya esta registrado";
            }

            cliente.Registrar(nombre, identificacion, telefono, correo);

            return "ok";
        }

        public List<ClienteModels> Listar()
        {
            ClienteRepository cliente = new ClienteRepository();
            return cliente.Listar();
        }



        public bool ExisteCliente(string identificacion)
        {
            var clientes = Listar();

            foreach (var cliente in clientes)
            {
                if (cliente.Identificacion == identificacion)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
