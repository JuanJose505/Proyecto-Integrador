using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_interactivo_de_circuitos_RC_y_RL.Utilidades
{
    public class Registro
    {
        private readonly ArchivodeUsuarios archivo;

        public Registro(ArchivodeUsuarios archivoDeUsuarios)
        {
            archivo = archivoDeUsuarios;
        }

        public bool RegistrarEstudiante(
            string nombre,
            string apellido,
            string usuario,
            string contrasena,
            string correo,
            string documento,
            string telefono,
            int semestre,
            string programa,
            out string mensaje)
        {
            
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contrasena) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(documento) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(programa))
            {
                mensaje = "Hay campos obligatorios vacíos (nombre, apellido, usuario o contraseña).";
                return false;
            }

           
            if (archivo.UsuarioExiste(usuario))
            {
                mensaje = "El nombre de usuario ya está en uso. Elige otro.";
                return false;
            }

            
            var estudiante = new Estudiante(
                nombre,
                apellido,
                usuario,
                contrasena,
                correo,
                documento,
                telefono,
                semestre,
                programa
            );

            
            archivo.GuardarUsuario(estudiante);

            mensaje = "Estudiante registrado correctamente.";
            return true;
        }

       
        public bool RegistrarProfesor(
            string nombre,
            string apellido,
            string usuario,
            string contrasena,
            string correo,
            string documento,
            string telefono,
            string asignatura,
            out string mensaje)
        {
            
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contrasena) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(documento) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(asignatura))


            {
                mensaje = "Hay campos obligatorios vacíos (nombre, apellido, usuario o contraseña).";
                return false;
            }

            
            if (archivo.UsuarioExiste(usuario))
            {
                mensaje = "El nombre de usuario ya está en uso. Elige otro.";
                return false;
            }

            
            var profesor = new Profesor(
                nombre,
                apellido,
                usuario,
                contrasena,
                correo,
                documento,
                telefono,
                asignatura
            );

            
            archivo.GuardarUsuario(profesor);

            mensaje = "Profesor registrado correctamente.";
            return true;
        }

    }
}
