using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_Análisis_de_Terreno_y_Costos.Models;
using Sistema_de_Análisis_de_Terreno_y_Costos.repository;
using Sistema_de_Análisis_de_Terreno_y_Costos.Repository;
using Sistema_de_Análisis_de_Terreno_y_Costos.Views;

namespace Sistema_de_Análisis_de_Terreno_y_Costos.Controllers
{
    public class CotizacionController
    {
        CotizacionRepository repositoryCotizacion = new CotizacionRepository();
        ClienteRepository clienteRepo = new ClienteRepository();
        MaterialRepository materialRepo = new MaterialRepository();
        public string CrearCotizacion(string idCliente,string nombreMaterial, decimal volumen)
        {
            ClienteModels cliente = clienteRepo.BuscarporID(idCliente);
            MaterialModels material = materialRepo.BuscarporMaterial(nombreMaterial);


            if (cliente == null)
                return "Cliente no encontrado";

            if (material == null)
                return "Material no encontrado";

            if (volumen <= 0)
                return "El volumen debe ser mayor a 0";


            var cotizacion = new CotizacionModels
            {
                id = Guid.NewGuid().ToString(),
                Cliente = cliente,
                Material = material,
                Volumen = volumen,
                Fecha = DateTime.Now,
                Estado = true
            };

            cotizacion.CalcularTotal();
            

            repositoryCotizacion.GuardarCotizacion(cotizacion);
            return "ok";
        }


        public List<CotizacionModels> Listar()
        {
            return repositoryCotizacion.ListarCotizaciones();
        }
       

        public CotizacionModels BuscarporID(string id)
        {
            return repositoryCotizacion.BuscarPorID(id);
        }


        public void CambiarEstado(string id, bool nuevoEstado)
        {
            repositoryCotizacion.CambiarEstado(id,nuevoEstado);
        }

        public void Editar(string id, decimal nuevoVolumen)
        {
            repositoryCotizacion.Editar(id, nuevoVolumen);
        }
    }
}
