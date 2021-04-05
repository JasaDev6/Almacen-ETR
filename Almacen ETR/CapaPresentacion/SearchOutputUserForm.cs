using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen_ETR.CapaPresentacion
{
    public partial class SearchOutputUserForm : Form
    {
        Conexion conexion = new Conexion();
        private int endeId;

        public SearchOutputUserForm(string endeName)
        {
            InitializeComponent();
            comboBoxSearchUser_ChangedAllUser();
            if (endeName.Equals("Transmisión"))
            {
                endeId = 1;
                LabelTitle.Text = "BUSQUEDA POR USUARIO SALIDAS ENDE TRANSMISIÓN";
            }
            if (endeName.Equals("Corporación"))
            {
                endeId = 2;
                LabelTitle.Text = "BUSQUEDA POR USUARIO SALIDAS ENDE CORPORACIÓN";
            }
        }

        private void SearchOutputUserForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxSearchUser_ChangedAllUser()
        {
            SqlCommand cmd = new SqlCommand("select Id,Nombre from Users", conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Desconectar();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Selecciona un usuario";
            dt.Rows.InsertAt(fila, 0);

            comboBoxSearchUser.ValueMember = "Id";
            comboBoxSearchUser.DisplayMember = "Nombre";
            comboBoxSearchUser.DataSource = dt;
        }

        private void comboBoxSearchUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchUser.SelectedValue.Equals("Selecciona un usuario") == false || comboBoxSearchUser.SelectedValue.ToString() != "")
            {
                //MessageBox.Show(comboBoxSearchUser.SelectedValue.ToString());
                string query = string.Empty;
                query += "select I.* from Output as I, JoinEndeIncome as JEI, Ende as E where I.Id=JEI.IdIncome and JEI.IdEnde=E.Id and E.Id='" + endeId + "' and JEI.IdUser='" + comboBoxSearchUser.SelectedValue.ToString() + "'";

                using (SqlCommand cmd = new SqlCommand(query, conexion.Conectar()))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView.DataSource = dt;
                    }
                }
            }
        }
    }
}
