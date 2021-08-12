namespace DTODemo
{

    /*
        CREATE DATABASE gente;
        USE gente
        CREATE TABLE Persona(
        PersonaId int IDENTITY(1,1),  
        Nombre varchar (20));

     */
    public class Persona
    {
        public string Nombre { get; set; }
        public int PersonaId { get; set; }

    }
}