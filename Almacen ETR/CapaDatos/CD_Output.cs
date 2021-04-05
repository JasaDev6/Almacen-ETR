using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen_ETR.CapaDatos
{
    class CD_Output
    {
        private Conexion conexion = new Conexion();
        SqlCommand comand = new SqlCommand();
        private SqlDataReader read;

        public DataTable showETR()
        {
            DataTable tableOne = new DataTable();
            comand.Connection = conexion.Conectar();
            comand.CommandText = "ShowOutputETR";
            comand.CommandType = CommandType.StoredProcedure;
            read = comand.ExecuteReader();
            tableOne.Load(read);
            conexion.Desconectar();
            return tableOne;
        }

        public DataTable showCORP()
        {
            DataTable tableTwo = new DataTable();
            comand.Connection = conexion.Conectar();
            comand.CommandText = "ShowOutputCORP";
            comand.CommandType = CommandType.StoredProcedure;
            read = comand.ExecuteReader();
            tableTwo.Load(read);
            conexion.Desconectar();
            return tableTwo;
        }

        public void insert(string Destino, string TDestino, string DateOutput, string Obs, string IdIncome, int IdUse)
        {
            comand.Connection = conexion.Conectar();
            comand.CommandText = "InsertOutput";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@Destino", Destino);
            comand.Parameters.AddWithValue("@TableroDestino", TDestino);
            comand.Parameters.AddWithValue("@FechaSalida", Convert.ToDateTime(DateOutput));
            comand.Parameters.AddWithValue("@Observación", Obs);
            comand.Parameters.AddWithValue("@IdIncome", IdIncome);
            comand.Parameters.AddWithValue("@IdUser", IdUse);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
            conexion.Desconectar();
        }

        public void edit(string Destino, string TDestino, string DateOutput, string Obs, int IdOutput)
        {
            comand.Connection = conexion.Conectar();
            comand.CommandText = "EditOutput";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@Destino", Destino);
            comand.Parameters.AddWithValue("@TableroDestino", TDestino);
            comand.Parameters.AddWithValue("@FechaSalida", Convert.ToDateTime(DateOutput));
            comand.Parameters.AddWithValue("@Observación", Obs);
            comand.Parameters.AddWithValue("@Id", IdOutput);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
            conexion.Desconectar();
        }

        public void delete(int IdOutput)
        {
            comand.Connection = conexion.Conectar();
            comand.CommandText = "DeleteOutput";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@Id", IdOutput);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
            conexion.Desconectar();
        }

    }
}
