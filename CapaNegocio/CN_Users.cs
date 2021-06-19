using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows.Forms;

namespace Almacen_ETR
{
    class CN_Users
    {
        private CD_Users objectCD = new CD_Users();

        public DataTable showUser()
        {
            DataTable tabla = new DataTable();
            tabla = objectCD.show();
            return tabla;
        }

        public void insertUser(string NEmpleado, string name, string user, string password, int IdtypeUser)
        { 
           objectCD.insert(Convert.ToInt32(NEmpleado), name, user, password, IdtypeUser);
        }

        public void editUser(string NEmpleado, string name, string user, string password, string Id)
        {
            objectCD.edit(Convert.ToInt32(NEmpleado), name, user, password, Convert.ToInt32(Id));
        }

        public void deleteUser(string Id)
        {
            objectCD.delete(Convert.ToInt32(Id));
        }

    }
}
