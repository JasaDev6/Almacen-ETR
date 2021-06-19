using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Almacen_ETR
{
    class CD_Users
    {
        private Conexion conexion = new Conexion();

        SqlDataReader read;
        DataTable table = new DataTable();
        SqlCommand comand = new SqlCommand();

        public DataTable show()
        {
            comand.Connection = conexion.Conectar();
            comand.CommandText = "MostrarUsuarios";
            comand.CommandType = CommandType.StoredProcedure;
            read = comand.ExecuteReader();
            table.Load(read);
            conexion.Desconectar();
            return table;
        }

        public void insert(int NEmpleado, string name,string user,string password,int IdtypeUser)
        {
            comand.Connection = conexion.Conectar();
            comand.CommandText = "InsertarUsuario";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@NEmpleado", NEmpleado);
            comand.Parameters.AddWithValue("@Nombre", name);
            comand.Parameters.AddWithValue("@Usuario", user);
            comand.Parameters.AddWithValue("@Contraseña", password);
            comand.Parameters.AddWithValue("@IdUserType", IdtypeUser);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
            conexion.Desconectar();
        }

        public void edit(int NEmpleado, string name, string user, string password, int Id)
        {
            comand.Connection = conexion.Conectar();
            comand.CommandText = "EditarUsuario";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@NEmpleado", NEmpleado);
            comand.Parameters.AddWithValue("@Nombre", name);
            comand.Parameters.AddWithValue("@Usuario", user);
            comand.Parameters.AddWithValue("@Contraseña", password);
            comand.Parameters.AddWithValue("@Id", Id);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
            conexion.Desconectar();
        }

        public void delete(int Id)
        {
            comand.Connection = conexion.Conectar();
            comand.CommandText = "EliminarUsuario";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@Id", Id);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
            conexion.Desconectar();
        }

    }
}
