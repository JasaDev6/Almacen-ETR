using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace Almacen_ETR
{
    class CN_ENDE
    {
        private CD_ENDE objectCD = new CD_ENDE();

        public DataTable showStockETR()
        {
            DataTable tabla = new DataTable();
            tabla = objectCD.showStockETR();
            return tabla;
        }

        public DataTable showStockCORP()
        {
            DataTable tabla = new DataTable();
            tabla = objectCD.showStockCORP();
            return tabla;
        }

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

        public void insertETR(string marca, string description, string modelo, string version, string vnominal, string inominal, string nserie, string BDI, string origen, string ULab, string estado, string tablero, string dateIni, string Obs, string ende, int IdUse)
        {
            objectCD.insert(marca, description, modelo, version, vnominal, inominal, nserie, BDI, origen, ULab, estado, tablero, dateIni, Obs, ende, IdUse);
        }

        public void editETR(string marca, string description, string modelo, string version, string vnominal, string inominal, string nserie, string BDI, string origen, string ULab, string estado, string tablero, string dateIni, string Obs, string id, string ende)
        {
            objectCD.edit(marca, description, modelo, version, vnominal, inominal, nserie, BDI, origen, ULab, estado, tablero, dateIni, Obs, Convert.ToInt32(id), ende);
        }

        public void deleteETR(string id)
        {
            objectCD.delete(Convert.ToInt32(id));
        }
    }
}
