using DTODemo;
using System;

namespace ClientBaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Martin2";
            PersonaLogic personaLogic = new PersonaLogic();
            int rows =personaLogic.Registrar(persona);
            ;
            Console.WriteLine(personaLogic.mensajeExito(rows));
        }
    }
}
