using PF01_Marwane;
using System;

namespace ProyectoIntermodular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Marwane", 20);

            Console.WriteLine("Comprobación de funcionalidades:");

            persona.ModificarEdad(21);

            if (persona.EsMayorDeEdad())
            {
                Console.WriteLine("La persona es mayor de edad.");
            }
            else
            {
                Console.WriteLine("La persona es menor de edad.");
            }

            persona.MostrarDatos();
        }
    }
}