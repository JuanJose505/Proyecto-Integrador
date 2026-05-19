using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Controllers
{
    public class ClienteController
    {
        public String Registrar(String nombre, String identificacion, String telefono,String correo)
        {
            Models.Cliente cliente = new Models.Cliente();

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

        public List<Models.Cliente> Listar()
        {
            Models.Cliente cliente = new Models.Cliente();
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
