using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Controllers
{
    public class MaterialController
    {
        public String Crear(String nombre, decimal precio, String estado)
        {
            Models.Material material = new Models.Material();

            if (ExisteMaterial(nombre))
            {
                return "El material con el nombre " + nombre + " ya existe.";
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                return "El nombre es obligatorio";
            }

            if (precio <= 0)
            {
                return "Ingrese un precio valido";
            }

            if (estado == "")
            {
                return "El estado es obligatorio";
            }

            material.Crear(nombre, precio, estado);

            return "ok";
        }

        public List<Models.Material> Listar()
        {
            Models.Material material = new Models.Material();
            return material.Listar();
        }

        public String Eliminar(String nombre)
        {
            Models.Material material = new Models.Material();
            if (!ExisteMaterial(nombre))
            {
                return "El material con el nombre " + nombre + " no existe.";
            }
            material.Eliminar(nombre);
            return "ok";
        }

        public String Actualizar(String nombre, decimal precio, String estado)
        {
            Models.Material material = new Models.Material();
            if (!ExisteMaterial(nombre))
            {
                return "El material con el nombre " + nombre + " no existe.";
            }
            material.Actualizar(nombre, precio, estado);
            return "ok";
        }

        public bool ExisteMaterial(string nombre)
        {
            var materiales = Listar();

            foreach (var material in materiales)
            {
                if (material.Nombre == nombre)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
