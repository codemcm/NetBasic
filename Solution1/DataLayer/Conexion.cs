using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class Conexion
    {
        string cadenaConexion = "Server=DESKTOP-5CIT38A;DataBase= gente;Integrated Security=true";
        SqlConnection con;
        public Conexion()
        {
            con = new SqlConnection(cadenaConexion);
        }

        public bool EsAbierta()
        {
            return con.State.Equals("Open");
        }

        public int Insertar(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con)
            {
                CommandType = CommandType.Text
            };
            int rowAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowAffected;
        }
    }
}
