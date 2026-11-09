using PF01_Marwane;
using System;

namespace ProyectoIntermodular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Marwane", 22);

            Console.WriteLine("Modificación de la edad:");

            persona.ModificarEdad(21);

            persona.MostrarDatos();
        }
    }
}