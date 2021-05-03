using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Almacen_ETR
{
    class CD_ENDE
    {
        private Conexion conexion = new Conexion();
        SqlDataReader read;
       
        SqlCommand comand = new SqlCommand();
        private int IdEnde;
        private int IdIncome;

        public DataTable showETR()
        {
            DataTable tableOne = new DataTable();
            comand.Connection = conexion.Conectar();
            comand.CommandText = "ShowIncomeETR";
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
            comand.CommandText = "ShowIncomeCORP";
            comand.CommandType = CommandType.StoredProcedure;
            read = comand.ExecuteReader();
            tableTwo.Load(read);
            conexion.Desconectar();
            return tableTwo;
        }

        private int getIdEnde(string ende)
        {
            string mySQL = string.Empty;
            mySQL += "SELECT * FROM Ende ";
            mySQL += "WHERE Nombre = '" + ende + "' ";

            SqlCommand comand = new SqlCommand(mySQL, conexion.Conectar());
            read = comand.ExecuteReader();
            if (read.HasRows != false)
            {
                while (read.Read())
                {
                    IdEnde = read.GetInt32(0);
                }
            }
            read.Close();
            return IdEnde;
        }

        private int getIdIncome()
        {
            string mySQL = string.Empty;
            mySQL += "SELECT TOP 1 * FROM Income ORDER BY ID DESC ";
        
            SqlCommand comand = new SqlCommand(mySQL, conexion.Conectar());
            read = comand.ExecuteReader();
            if (read.HasRows != false)
            {
                while (read.Read())
                {
                    IdIncome = read.GetInt32(0);
                }
            }
            read.Close();
            return IdIncome;
        }

        public void insert(string marca, string description, string modelo, string version, string vnominal, string inominal, string nserie, string BDI, string origen, string ULab, string estado, string tablero, string dateIni, string Obs, string ende, int IdUse)
        {
            comand.Connection = conexion.Conectar();      
            comand.CommandText = "InsertIncome";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@Marca", marca);
            comand.Parameters.AddWithValue("@Descripción", description);
            comand.Parameters.AddWithValue("@Modelo", modelo);
            comand.Parameters.AddWithValue("@Versión", version);
            comand.Parameters.AddWithValue("@Vnominal", vnominal);
            comand.Parameters.AddWithValue("@Inominal", inominal);
            comand.Parameters.AddWithValue("@Nserie", nserie);
            comand.Parameters.AddWithValue("@BDI", BDI);
            comand.Parameters.AddWithValue("@Origen", origen);
            comand.Parameters.AddWithValue("@ULab", ULab);
            comand.Parameters.AddWithValue("@Estado", estado);
            comand.Parameters.AddWithValue("@Tablero", tablero);
            comand.Parameters.AddWithValue("@FechaIngreso", Convert.ToDateTime(dateIni));
            comand.Parameters.AddWithValue("@Observación", Obs);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();

            comand.CommandText = "InsertarJoinEndeIncome";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@IdIncome", getIdIncome());
            comand.Parameters.AddWithValue("@IdEnde", getIdEnde(ende));
            comand.Parameters.AddWithValue("@IdUser", IdUse);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();

            conexion.Desconectar();
        }

        public void edit(string marca, string description, string modelo, string version, string vnominal, string inominal, string nserie, string BDI, string origen, string ULab, string estado, string tablero, string dateIni, string Obs, int idETR, string ende)
        {
            comand.Connection = conexion.Conectar();
            comand.CommandText = "EditIncome";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@Marca", marca);
            comand.Parameters.AddWithValue("@Descripción", description);
            comand.Parameters.AddWithValue("@Modelo", modelo);
            comand.Parameters.AddWithValue("@Versión", version);
            comand.Parameters.AddWithValue("@Vnominal", vnominal);
            comand.Parameters.AddWithValue("@Inominal", inominal);
            comand.Parameters.AddWithValue("@Nserie", nserie);
            comand.Parameters.AddWithValue("@BDI", BDI);
            comand.Parameters.AddWithValue("@Origen", origen);
            comand.Parameters.AddWithValue("@ULab", ULab);
            comand.Parameters.AddWithValue("@Estado", estado);
            comand.Parameters.AddWithValue("@Tablero", tablero);
            comand.Parameters.AddWithValue("@FechaIngreso", Convert.ToDateTime(dateIni));
            comand.Parameters.AddWithValue("@Observación", Obs);
            comand.Parameters.AddWithValue("@Id", idETR);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
            conexion.Desconectar();
        }

        public void delete(int id)
        {
            comand.Connection = conexion.Conectar();
            comand.CommandText = "DeleteIncome";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@Id", id);
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
            conexion.Desconectar();
        }
    }
}
