using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using Sistema_de_Análisis_de_Terreno_y_Costos.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


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

            if (!identificacion.All(char.IsDigit))
            {
                return "Ingrese una identificación válida";
            }

            if (!telefono.All(char.IsDigit))
            {
                return "Ingrese un teléfono válido";
            }

            try
            {
                MailAddress mail = new MailAddress(correo);
            }
            catch
            {
                return "Ingrese un correo válido";
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
