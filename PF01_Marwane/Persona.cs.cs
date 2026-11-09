using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PF01_Marwane
{
    public class Persona
    {
        public string Nombre { get; set; } = "";
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
        public void ModificarEdad(int nuevaEdad)
        {
            Edad = nuevaEdad;
        }

    }

}
    
