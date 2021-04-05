using Almacen_ETR.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen_ETR.CapaNegocio
{
    class CN_Output
    {
        private CD_Output objectCD = new CD_Output();

        public DataTable showETR()
        {
            DataTable tabla = new DataTable();
            tabla = objectCD.showETR();
            return tabla;
        }

        public DataTable showCORP()
        {
            DataTable tabla = new DataTable();
            tabla = objectCD.showCORP();
            return tabla;
        }

        public void insert(string Destino, string TDestino, string DateOutput, string Obs, string IdIncome, int IdUse)
        {
            objectCD.insert(Destino, TDestino, DateOutput, Obs, IdIncome, IdUse);
        }

        public void edit(string Destino, string TDestino, string DateOutput, string Obs, string IdOutput)
        {
            objectCD.edit(Destino, TDestino, DateOutput, Obs, Convert.ToInt32(IdOutput));
        }

        public void delete(string idOutput)
        {
            objectCD.delete(Convert.ToInt32(idOutput));
        }
    }
}
