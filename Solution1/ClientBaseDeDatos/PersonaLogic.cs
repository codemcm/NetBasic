using DataLayer;
using DTODemo;

namespace ClientBaseDeDatos
{
    public class PersonaLogic
    {
        public int Registrar(Persona persona)
        {
            string queryInsert = "INSERT INTO persona (Nombre) VALUES('"
                + persona.Nombre + "')";
            return new Conexion().Insertar(queryInsert);
        }

        public string mensajeExito(int nRegistrosAfectados)
        {
            string mensaje;
            if (nRegistrosAfectados > 0)
            {
                mensaje = "Se registro con exito";
            }
            else
            {
                mensaje = "Problemas al realizar la insercion";
            }
            return mensaje;
        }
    }
}
