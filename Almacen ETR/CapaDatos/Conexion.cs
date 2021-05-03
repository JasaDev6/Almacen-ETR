using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Almacen_ETR
{
    class Conexion
    {
        private SqlConnection conexion = new SqlConnection("Data Source = Desktop-Jasa; Initial Catalog = laboratory; Integrated Security = True");

        //@"Data Source=\\10.231.36.70\pipe\MSSQL$INVENTARIO_LAB\sql\query;Initial Catalog=Lab;User ID=sa;Password=Ende123**"
        //"Data Source = Desktop-Jasa; Initial Catalog = laboratory; Integrated Security = True"
        
        public SqlConnection Conectar()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection Desconectar()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }

    }
}
