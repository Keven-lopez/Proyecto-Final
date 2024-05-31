using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Resources.Classes
{
    internal class League
    {
        private string connectionString = "Server=localhost;Database=db_final;Uid=root;Pwd=2003";

        public DataTable ActualizarTabla()
        {
            DataTable table = new DataTable();
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string command = "select * from personajes_lol";
                using(MySqlCommand com =  new MySqlCommand(command, con))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(com))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }

        public int CrearRegistro(string nombre, string sexo, string region, string recurso, string alcance, string rol, string tipo, int aspectos)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                    con.Open();
                    string command = "insert into personajes_lol(Nombre,Sexo,Region,Recurso,Alcance,Rol,Tipo_de_Daño,Numero_Aspectos) values (@Nombre,@Sexo,@Region,@Recurso,@Alcance,@Rol,@Tipo_de_Daño,@Numero_Aspectos)";
                    using (MySqlCommand com = new MySqlCommand(command, con))
                    {
                        com.Parameters.AddWithValue("@Nombre", nombre);
                        com.Parameters.AddWithValue("@Sexo", sexo);
                        com.Parameters.AddWithValue("@Region", region);
                        com.Parameters.AddWithValue("@Recurso", recurso);
                        com.Parameters.AddWithValue("@Alcance", alcance);
                        com.Parameters.AddWithValue("@Rol", rol);
                        com.Parameters.AddWithValue("@Tipo_de_Daño", tipo);
                        com.Parameters.AddWithValue("@Numero_Aspectos", aspectos);
                        return com.ExecuteNonQuery();
                    }
                }
        }

        public int ActualizarRegistro(string id, string nombre, string sexo, string region, string recurso, string alcance, string rol, string tipo, int aspectos)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string command = "update personajes_lol set Nombre = @Nombre, Sexo = @Sexo, Region= @Region, Recurso =@Recurso,Alcance=@Alcance,Rol=@Rol,Tipo_de_Daño=@Tipo_de_Daño,Numero_Aspectos=@Numero_Aspectos where id=@id";
                using (MySqlCommand com = new MySqlCommand(command, con))
                {
                    com.Parameters.AddWithValue("@id", id);
                    com.Parameters.AddWithValue("@Nombre", nombre);
                    com.Parameters.AddWithValue("@Sexo", sexo);
                    com.Parameters.AddWithValue("@Region", region);
                    com.Parameters.AddWithValue("@Recurso", recurso);
                    com.Parameters.AddWithValue("@Alcance", alcance);
                    com.Parameters.AddWithValue("@Rol", rol);
                    com.Parameters.AddWithValue("@Tipo_de_Daño", tipo);
                    com.Parameters.AddWithValue("@Numero_Aspectos", aspectos);
                    return com.ExecuteNonQuery();
                }
            }
        }

        public int BorrarRegistro(string id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string command = "delete  from personajes_lol where id=@id";
                using (MySqlCommand com = new MySqlCommand(command, con))
                {
                    com.Parameters.AddWithValue("@id", id);
                    return com.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarPorId(int id)
        {
            DataTable league = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_lol WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(league);
                    }
                }
            }

            return league;
        }

    }
}
