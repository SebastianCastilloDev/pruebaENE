
using System;
using System.Collections.Generic;

namespace CapaData
{
    public static class Data
    {
        public static List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario("Usuario1", "abcd","Admin"),
            new Usuario("Usuario2", "1234","Usuario"),
            new Usuario("Usuario3","pass","Usuario")
        };

        public static List<Trabajador> trabajadores = new Trabajador().GenerarTrabajadores();
    }



    public class Usuario
    {
        public string Nombre { get; set; }
        public string PassWord { get; set; }
        public string Rol { get; set; }

        public Usuario(string nombre, string passWord, string rol)
        {
            Nombre = nombre;
            PassWord = passWord;
            Rol = rol;
        }
    }

    public class Trabajador
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Afp { get; set; }
        public string Salud { get; set; }
        public int HorasTrabajadas { get; set; }
        public int HorasExtra { get; set; }

        public Trabajador(string rut, string nombre, string direccion, string telefono, string afp, string salud, int horasTrabajadas, int horasExtra)
        {
            Rut = rut;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Afp = afp;
            Salud = salud;
            HorasTrabajadas = horasTrabajadas;
            HorasExtra = horasExtra;
        }

        public Trabajador()
        {

        }

        public List<Trabajador> GenerarTrabajadores()
        {

            List<Trabajador> trabajadores = new List<Trabajador>();
            for(int i=0; i < 5; i++)
            {
                trabajadores.Add(new Trabajador("rut" + i, "nombre" + i, "direccion" + i, "telefono" + i, "Modelo", "Banmedica", 10, 10));
            }
            return trabajadores;
        } 
    }

    public static class SistemaSalud
    {
        public static string[] prevision = new string[4] { "Fonasa", "Consalud", "Masvida", "Banmedica" };
    }
    public static class SistemaPensiones
    {
        public static string[] afp = new string[4] { "Cuprum", "Modelo", "Capital", "Provida" };
    }
      
}
