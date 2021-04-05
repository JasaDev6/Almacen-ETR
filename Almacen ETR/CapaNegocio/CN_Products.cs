using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen_ETR.CapaNegocio
{
    class CN_Products
    {

        private CD_Products objectCD = new CD_Products();

        public DataTable show()
        {
            DataTable tabla = new DataTable();
            tabla = objectCD.show();
            return tabla;
        }

        public void insert(string Marca, string Modelo, string Tipo, string Vnominal, string Inominal)
        {
            objectCD.insert(Marca, Modelo, Tipo, Vnominal, Inominal);
        }

        public void edit(string Marca, string Modelo, string Tipo, string Vnominal, string Inominal, string Id)
        {
            objectCD.edit(Marca, Modelo, Tipo, Vnominal, Inominal, Convert.ToInt32(Id));
        }

        public void delete(string id)
        {
            objectCD.delete(Convert.ToInt32(id));
        }


    }
}
