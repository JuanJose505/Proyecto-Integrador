using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Análisis_de_Terreno_y_Costos.repository;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Controllers
{
    public class MaterialController
    {
        // SIMPLIFIQUE CODIGO PONIENDO USING REPOSITORY EN LA PARTE SUPERIOR Y AHORA SE DELEGA AL REPOSITORY, NO AL MODELO//
        public String Crear(String nombre, decimal precio, String estado)
        {
            MaterialRepository material = new MaterialRepository();

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

            if (string.IsNullOrWhiteSpace(estado))
            {
                return "El estado es obligatorio";
            }

            material.Crear(nombre, precio, estado);

            return "ok";
        }

        public List<MaterialModels> Listar()
        {
            MaterialRepository material = new MaterialRepository();
            return material.Listar();
        }

        public String Eliminar(String nombre)
        {
            MaterialRepository material = new MaterialRepository();
            if (!ExisteMaterial(nombre))
            {
                return "El material con el nombre " + nombre + " no existe.";
            }
            material.Eliminar(nombre);
            return "ok";
        }

        public String Actualizar(String nombre, decimal precio, String estado)
        {
            MaterialRepository material = new MaterialRepository();
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
