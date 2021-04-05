using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen_ETR
{
    class CD_Products
    {

        private Conexion conexion = new Conexion();
        SqlDataReader read;
        SqlCommand comand = new SqlCommand();

        public DataTable show()
        {
            DataTable table = new DataTable();
            comand.Connection = conexion.Conectar();
            comand.CommandText = "ShowNewType";
            comand.CommandType = CommandType.StoredProcedure;
            read = comand.ExecuteReader();
            table.Load(read);
            conexion.Desconectar();
            return table;
        }

        public void insert(string Marca, string Modelo, string Tipo, string Vnominal, string Inominal)
        {
            comand.Connection = conexion.Conectar();
            comand.CommandText = "InsertNewType";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@Marca", Marca);
            comand.Parameters.AddWithValue("@Modelo", Modelo);
            comand.Parameters.AddWithValue("@Tipo", Tipo);
            comand.Parameters.AddWithValue("@Vnominal", Vnominal);
            comand.Parameters.AddWithValue("@Inominal", Inominal);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
            conexion.Desconectar();
        }

        public void edit(string Marca, string Modelo, string Tipo, string Vnominal, string Inominal, int Id)
        {
            comand.Connection = conexion.Conectar();
            comand.CommandText = "EditNewType";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@Marca", Marca);
            comand.Parameters.AddWithValue("@Modelo", Modelo);
            comand.Parameters.AddWithValue("@Tipo", Tipo);
            comand.Parameters.AddWithValue("@Vnominal", Vnominal);
            comand.Parameters.AddWithValue("@Inominal", Inominal);
            comand.Parameters.AddWithValue("@Id", Id);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
            conexion.Desconectar();
        }

        public void delete(int id)
        {
            comand.Connection = conexion.Conectar();
            comand.CommandText = "DeleteNewType";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@Id", id);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
            conexion.Desconectar();
        }


    }
}
