using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Simulador_interactivo_de_circuitos_RC_y_RL.Utilidades
{
    public class ArchivodeUsuarios
    {
        private readonly string RutaArchivo = "usuarios.txt";

        public ArchivodeUsuarios() 
        {
            if (!File.Exists(RutaArchivo))
            {
                using (var stream = File.Create(RutaArchivo))
                {
                    
                }
            }
        }

        private List<Persona> CargarDesdeArchivo()
        {
            var lista = new List<Persona>();

            if (!File.Exists(RutaArchivo))
                return lista;

            string[] lineas = File.ReadAllLines(RutaArchivo);

            foreach (string linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                string[] partes = linea.Split('|');

                
                if (partes.Length < 8)
                    continue;

                string tipo = partes[0];
                string nombre = partes[1];
                string apellido = partes[2];
                string usuario = partes[3];
                string contrasena = partes[4];
                string correo = partes[5];
                string documento = partes[6];
                string telefono = partes[7];

                if (tipo == "Profesor")
                {
                    
                    if (partes.Length < 9) continue;

                    string asignatura = partes[8];

                    var prof = new Profesor(
                        nombre,
                        apellido,
                        usuario,
                        contrasena,
                        correo,
                        documento,
                        telefono,
                        asignatura
                    );

                    lista.Add(prof);
                }
                else if (tipo == "Estudiante")
                {
                    // Para estudiante esperamos mínimo 10 campos
                    if (partes.Length < 10) continue;

                    int semestre = int.Parse(partes[8]);
                    string programa = partes[9];

                    var est = new Estudiante(
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

                    lista.Add(est);
                }
            }

            return lista;
        }

        private void GuardarListaEnArchivo(List<Persona> usuarios)
        {
            var lineas = new List<string>();

            foreach (var persona in usuarios)
            {
                if (persona is Profesor prof)
                {
                    string linea = string.Join("|",
                        "Profesor",
                        prof.Nombre,
                        prof.Apellido,
                        prof.Usuario,
                        prof.Contraseña,   
                        prof.Correo,
                        prof.Documento,
                        prof.Telefono,
                        prof.Asignatura
                    );

                    lineas.Add(linea);
                }
                else if (persona is Estudiante est)
                {
                    string linea = string.Join("|",
                        "Estudiante",
                        est.Nombre,
                        est.Apellido,
                        est.Usuario,
                        est.Contraseña,
                        est.Correo,
                        est.Documento,
                        est.Telefono,
                        est.Semestre,
                        est.Programa
                    );

                    lineas.Add(linea);
                }
            }

            File.WriteAllLines(RutaArchivo, lineas);
        }


        public List<Persona> CargarTodos()
        {
            return CargarDesdeArchivo();
        }

        public bool UsuarioExiste(string usuario)
        {
            var usuarios = CargarDesdeArchivo();

            foreach (var persona in usuarios)
            {
                if (string.Equals(persona.Usuario, usuario, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        public Persona BuscarUsuario(string usuario)
        {
            var usuarios = CargarDesdeArchivo();

            foreach (var persona in usuarios)
            {
                if (string.Equals(persona.Usuario, usuario, StringComparison.OrdinalIgnoreCase))
                {
                    return persona;
                }
            }

            return null; 
        }

        public void GuardarUsuario(Persona persona)
        {
            var usuarios = CargarDesdeArchivo();

            
            bool reemplazado = false;

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (string.Equals(usuarios[i].Usuario, persona.Usuario, StringComparison.OrdinalIgnoreCase))
                {
                    usuarios[i] = persona;
                    reemplazado = true;
                    break;
                }
            }

            if (!reemplazado)
            {
                usuarios.Add(persona);
            }

            GuardarListaEnArchivo(usuarios);
        }

        public void ActualizarUsuario(Persona persona)
        {
            
            GuardarUsuario(persona);
        }
    }
}
