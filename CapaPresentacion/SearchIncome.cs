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
    public partial class SearchIncome : Form
    {
        CN_ENDE objectCN = new CN_ENDE();
        Conexion conexion = new Conexion();
        private int endeId;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (endeId == 1)
                verifyIfEtrOrCorp("Transmisión");
            if (endeId == 2)
                verifyIfEtrOrCorp("Corporación");
        }

        public void assignNameEtr()
        {
            endeId = 1;
            title.Text = "Buscar Ingresos en Ende Tramisión";
            dataGridView.DataSource = objectCN.showETR();
            dataGridView.Refresh();
        }

        public void assignNameCorp()
        {
            endeId = 2;
            title.Text = "Buscar ingresos en Ende Corporación";
            dataGridView.DataSource = objectCN.showCORP();
            dataGridView.Refresh();
        }

        public void verifyIfEtrOrCorp(string endeName)
        {
            if ("Transmisión".Equals(endeName))
            {
                assignNameEtr();
            }
            if ("Corporación".Equals(endeName))
            {
                assignNameCorp();
            }
        }

        public SearchIncome(string endeName)
        {
            InitializeComponent();
            comboBoxSearchUser_ChangedAllUser();
            verifyIfEtrOrCorp(endeName);
            LoadDataOne();
            LoadDataTwo();
            LoadDataThree();
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

        private void ComboBoxSearchUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchUser.SelectedValue.Equals("Selecciona un usuario") == false || comboBoxSearchUser.SelectedValue.ToString() != "")
            {
                string query = string.Empty;
                query += "select I.* from Income as I, JoinEndeIncome as JEI, Ende as E where I.Id=JEI.IdIncome and JEI.IdEnde=E.Id and E.Id='" + endeId + "' and JEI.IdUser='" + comboBoxSearchUser.SelectedValue.ToString() + "'";
              
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

        private DataTable sqlQuery()
        {
            SqlDataAdapter da = new SqlDataAdapter("select COLUMN_NAME from information_schema.columns where table_name = 'Income' and COLUMN_NAME <> 'Id'", conexion.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Desconectar();
            return dt;
        }

        private void LoadDataOne()
        {
            DataTable dt = sqlQuery();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxSearchOne.Items.Add(dt.Rows[i]["COLUMN_NAME"].ToString());
            }
            comboBoxSearchOne.Items.Insert(0, "Seleccione un campo");
            comboBoxSearchOne.SelectedIndex = 0;
        }

        private void LoadDataTwo()
        {
            DataTable dt = sqlQuery();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxSearchTwo.Items.Add(dt.Rows[i]["COLUMN_NAME"].ToString());
            }
            comboBoxSearchTwo.Items.Insert(0, "Seleccione un campo");
            comboBoxSearchTwo.SelectedIndex = 0;
        }

        private void LoadDataThree()
        {
            DataTable dt = sqlQuery();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxSearchThree.Items.Add(dt.Rows[i]["COLUMN_NAME"].ToString());
            }
            comboBoxSearchThree.Items.Insert(0, "Seleccione un campo");
            comboBoxSearchThree.SelectedIndex = 0;
        }

        private String sqlQuery(string camp)
        {
            string query = string.Empty;
            query += " select distinct I." + camp + " from Income as I, JoinEndeIncome as JEI, Ende as E ";
            query += " where I.Id=JEI.IdIncome ";
            query += " and JEI.IdEnde=E.Id and E.Id='" + endeId + "' and " + camp + " is not null";
            return query;
        }

        private DataTable connectionComboBox(string camp)
        {
            string query = sqlQuery(camp);
            SqlCommand cmd = new SqlCommand(query, conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Desconectar();
            return dt;
        }

        private void cargarDatoComboBoxSearchOne(string camp)
        {
            DataTable dt = connectionComboBox(camp);

            DataRow fila = dt.NewRow();
            fila[camp] = "Selecciona un dato";
            dt.Rows.InsertAt(fila, 0);

            comboBoxListOne.ValueMember = camp;
            comboBoxListOne.DisplayMember = camp;
            comboBoxListOne.DataSource = dt;
        }

        private void cargarDatoComboBoxSearchTwo(string camp)
        {
            DataTable dt = connectionComboBox(camp);

            DataRow fila = dt.NewRow();
            fila[camp] = "Selecciona un dato";
            dt.Rows.InsertAt(fila, 0);

            comboBoxListTwo.ValueMember = camp;
            comboBoxListTwo.DisplayMember = camp;
            comboBoxListTwo.DataSource = dt;
        }

        private void cargarDatoComboBoxSearchThree(string camp)
        {
            DataTable dt = connectionComboBox(camp);

            DataRow fila = dt.NewRow();
            fila[camp] = "Selecciona un dato";
            dt.Rows.InsertAt(fila, 0);

            comboBoxListThree.ValueMember = camp;
            comboBoxListThree.DisplayMember = camp;
            comboBoxListThree.DataSource = dt;
        }

        private void comboBoxSearchOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchOne.Items[comboBoxSearchOne.SelectedIndex].Equals("Seleccione un campo") == false)
            {
                comboBoxListOne.DataSource = null;
                cargarDatoComboBoxSearchOne(comboBoxSearchOne.Items[comboBoxSearchOne.SelectedIndex].ToString());
            }
            else
            {
                comboBoxListOne.DataSource = null;
            }
        }

        private void comboBoxSearchTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchTwo.Items[comboBoxSearchTwo.SelectedIndex].Equals("Seleccione un campo") == false)
            {
                comboBoxListTwo.DataSource = null;
                cargarDatoComboBoxSearchTwo(comboBoxSearchTwo.Items[comboBoxSearchTwo.SelectedIndex].ToString());
            }
            else
            {
                comboBoxListTwo.DataSource = null;
            }
        }

        private void comboBoxSearchThree_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchThree.Items[comboBoxSearchThree.SelectedIndex].Equals("Seleccione un campo") == false)
            {
                comboBoxListThree.DataSource = null;
                cargarDatoComboBoxSearchThree(comboBoxSearchThree.Items[comboBoxSearchThree.SelectedIndex].ToString());
            }
            else
            {
                comboBoxListThree.DataSource = null;
            }
        }

        private void ComboBoxListOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxListOne.DataSource != null)
            {
                if (comboBoxListOne.SelectedValue.Equals("Selecciona un dato") == false)
                {
                    string query = string.Empty;

                    query += " select distinct I.*, U.Nombre as 'Usuario' from Income as I, JoinEndeIncome as JEI, Ende as E, Users as U ";
                    query += " where I.Id=JEI.IdIncome ";
                    query += " and JEI.IdEnde=E.Id and E.Id='" + endeId + "'";
                    query += " and JEI.IdUser=U.Id ";
                    query += " and I." + (comboBoxSearchOne.Items[comboBoxSearchOne.SelectedIndex].ToString()) + " = '" + comboBoxListOne.SelectedValue.ToString() + "'";

                    using (SqlCommand cmd = new SqlCommand(query, conexion.Conectar()))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            dataGridView.DataSource = dt;
                            sda.Update(dt);
                            dt = null;
                        }
                    }
                }
            }
        }

        private void ComboBoxListTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxListTwo.DataSource != null)
            {
                if (comboBoxListTwo.SelectedValue.Equals("Selecciona un dato") == false)
                {
                    string query = string.Empty;

                    query += " select distinct I.*, U.Nombre as 'Usuario' from Income as I, JoinEndeIncome as JEI, Ende as E, Users as U ";
                    query += " where I.Id=JEI.IdIncome ";
                    query += " and JEI.IdEnde=E.Id and E.Id='" + endeId + "'";
                    query += " and JEI.IdUser=U.Id ";
                    query += " and I." + (comboBoxSearchTwo.Items[comboBoxSearchTwo.SelectedIndex].ToString()) + " = '" + comboBoxListTwo.SelectedValue.ToString() + "'";

                    using (SqlCommand cmd = new SqlCommand(query, conexion.Conectar()))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            dataGridView.DataSource = dt;
                            dt = null;
                        }
                    }
                }
            }
        }

        private void ComboBoxListThree_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxListThree.DataSource != null)
            {
                if (comboBoxListThree.SelectedValue.Equals("Selecciona un dato") == false)
                {
                    string query = string.Empty;

                    query += " select distinct I.*, U.Nombre as 'Usuario' from Income as I, JoinEndeIncome as JEI, Ende as E, Users as U ";
                    query += " where I.Id=JEI.IdIncome ";
                    query += " and JEI.IdEnde=E.Id and E.Id='" + endeId + "'";
                    query += " and JEI.IdUser=U.Id ";
                    query += " and I." + (comboBoxSearchThree.Items[comboBoxSearchThree.SelectedIndex].ToString()) + " = '" + comboBoxListThree.SelectedValue.ToString() + "'";

                    using (SqlCommand cmd = new SqlCommand(query, conexion.Conectar()))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            dataGridView.DataSource = dt;
                            dt = null;
                        }
                    }
                }
            }
        }
    }
}
