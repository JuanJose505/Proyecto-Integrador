using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sistema_de_Análisis_de_Terreno_y_Costos.Controllers;
using Sistema_de_Análisis_de_Terreno_y_Costos.Enums;
using Sistema_de_Análisis_de_Terreno_y_Costos.repository;   

namespace Sistema_de_Análisis_de_Terreno_y_Costos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UsuarioRepository repo =
                new UsuarioRepository();

            if (!repo.HayUsuarios())
            {
                UsuarioController controller =
                    new UsuarioController();

                controller.GuardarUsuario(
                    "admin",
                    "admin@gmail.com",
                    "3000000000",
                    "Admin123*",
                    RolUsuario.Administrador
                );
            }
            Application.Run(new Login());
        }
    }
}
