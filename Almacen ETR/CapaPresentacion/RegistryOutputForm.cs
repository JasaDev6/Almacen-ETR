using Almacen_ETR.CapaNegocio;
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
    public partial class RegistryOutputForm : Form
    {
        CN_Output objectCN = new CN_Output();
        Conexion conexion = new Conexion();
        private string ende = null;
        private int typeUserOutput;
        private int IdUserOutput;
        private bool edit = false;
        private int endeId;

        public RegistryOutputForm(int IdUser, int typeUser, string endeName)
        {
            InitializeComponent();
            LoadDataOne();
            LoadDataTwo();
            LoadDataThree();
            IdUserOutput = IdUser;
            ende = endeName;
            typeUserOutput = typeUser;
            if ("Transmisión".Equals(endeName))
            {
                endeId = 1;
            }
            if ("Corporación".Equals(endeName))
            {
                endeId = 2;
            }
        }

        private void RegistryOutputForm_Load(object sender, EventArgs e)
        {
            show();
        }

        private void LoadDataOne()
        {
            SqlDataAdapter da = new SqlDataAdapter("select COLUMN_NAME from information_schema.columns where table_name = 'Income' or table_name = 'Output' and COLUMN_NAME <> 'Id' and COLUMN_NAME <> 'Id'", conexion.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Desconectar();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxSearchOne.Items.Add(dt.Rows[i]["COLUMN_NAME"].ToString());
            }
            comboBoxSearchOne.Items.Insert(0, "Seleccione un campo");
            comboBoxSearchOne.SelectedIndex = 0;
        }

        private void LoadDataTwo()
        {
            SqlDataAdapter da = new SqlDataAdapter("select COLUMN_NAME from information_schema.columns where table_name = 'Income' or table_name = 'Output' and COLUMN_NAME <> 'Id'", conexion.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Desconectar();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxSearchTwo.Items.Add(dt.Rows[i]["COLUMN_NAME"].ToString());
            }
            comboBoxSearchTwo.Items.Insert(0, "Seleccione un campo");
            comboBoxSearchTwo.SelectedIndex = 0;
        }

        private void LoadDataThree()
        {
            SqlDataAdapter da = new SqlDataAdapter("select COLUMN_NAME from information_schema.columns where table_name = 'Income' or table_name = 'Output' and COLUMN_NAME <> 'Id'", conexion.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Desconectar();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxSearchThree.Items.Add(dt.Rows[i]["COLUMN_NAME"].ToString());
            }
            comboBoxSearchThree.Items.Insert(0, "Seleccione un campo");
            comboBoxSearchThree.SelectedIndex = 0;
        }

        private void cargarDatoComboBoxSearchOne(string camp)
        {
            string query = string.Empty;
            query += " select distinct I." + camp + " from Income as I, JoinEndeIncome as JEI, Ende as E ";
            query += " where I.Id=JEI.IdIncome ";
            query += " and JEI.IdEnde=E.Id and E.Id='" + endeId + "' and " + camp + " is not null";
            SqlCommand cmd = new SqlCommand(query, conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Desconectar();

            DataRow fila = dt.NewRow();
            fila[camp] = "Selecciona un dato";
            dt.Rows.InsertAt(fila, 0);

            comboBoxListOne.ValueMember = camp;
            comboBoxListOne.DisplayMember = camp;
            comboBoxListOne.DataSource = dt;
        }

        private void cargarDatoComboBoxSearchTwo(string camp)
        {
            string query = string.Empty;
            query += " select distinct I." + camp + " from Income as I, JoinEndeIncome as JEI, Ende as E ";
            query += " where I.Id=JEI.IdIncome ";
            query += " and JEI.IdEnde=E.Id and E.Id='" + endeId + "' and " + camp + " is not null";
            SqlCommand cmd = new SqlCommand(query, conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Desconectar();

            DataRow fila = dt.NewRow();
            fila[camp] = "Selecciona un dato";
            dt.Rows.InsertAt(fila, 0);

            comboBoxListTwo.ValueMember = camp;
            comboBoxListTwo.DisplayMember = camp;
            comboBoxListTwo.DataSource = dt;
        }

        private void cargarDatoComboBoxSearchThree(string camp)
        {
            string query = string.Empty;
            query += " select distinct I." + camp + " from Income as I, JoinEndeIncome as JEI, Ende as E ";
            query += " where I.Id=JEI.IdIncome ";
            query += " and JEI.IdEnde=E.Id and E.Id='" + endeId + "'";
            SqlCommand cmd = new SqlCommand(query, conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Desconectar();

            DataRow fila = dt.NewRow();
            fila[camp] = "Selecciona un dato";
            dt.Rows.InsertAt(fila, 0);

            comboBoxListThree.ValueMember = camp;
            comboBoxListThree.DisplayMember = camp;
            comboBoxListThree.DataSource = dt;
        }

        private void show()
        {
            if ("Transmisión".Equals(ende))
            {
                dataGridView.DataSource = objectCN.showETR();
                LabelTitle.Text = "ENDE TRANSMISIÓN SALIDAS DE LABORATORIO";
            }
            if ("Corporación".Equals(ende))
            {
                dataGridView.DataSource = objectCN.showCORP();
                LabelTitle.Text = "ENDE CORPORACIÓN SALIDAS DE LABORATORIO";
            }
        }

        private void btnEditRegisterOutput_Click(object sender, EventArgs e)
        {
            if (typeUserOutput == 1)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    edit = true;
                    string Marca = dataGridView.CurrentRow.Cells["Marca"].Value.ToString();
                    string Modelo = dataGridView.CurrentRow.Cells["Modelo"].Value.ToString();
                    string Tipo = dataGridView.CurrentRow.Cells["Tipo"].Value.ToString();
                    string Nserie = dataGridView.CurrentRow.Cells["Nserie"].Value.ToString();
                    string BDI = dataGridView.CurrentRow.Cells["BDI"].Value.ToString();
                    string ULab = dataGridView.CurrentRow.Cells["Ulab"].Value.ToString();

                    string Destino = dataGridView.CurrentRow.Cells["Destino"].Value.ToString();
                    string TableroDestino = dataGridView.CurrentRow.Cells["TableroDestino"].Value.ToString();
                    string FechaSalida = dataGridView.CurrentRow.Cells["FechaSalida"].Value.ToString();
                    string Observacion = dataGridView.CurrentRow.Cells["Observación"].Value.ToString();
                    string IdOutput = dataGridView.CurrentRow.Cells["Id"].Value.ToString();

                    this.Hide();
                    OutputForm formETR = new OutputForm(Convert.ToInt32(IdUserOutput));
                    formETR.getEditRegisterOutput(Marca, Modelo, Tipo, Nserie, BDI, ULab, Destino, TableroDestino, FechaSalida, Observacion, IdOutput, edit);
                    formETR.ShowDialog();
                    this.Show();
                    show();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila por favor");
                }
            }
            if (typeUserOutput == 2)
            {
                edit = true;

            }
        }

        private void btnDeleteRegisterOutput_Click(object sender, EventArgs e)
        {
            if (typeUserOutput == 1)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    string Id = dataGridView.CurrentRow.Cells["Id"].Value.ToString();
                    objectCN.delete(Id);
                    MessageBox.Show("Eliminado correctamente");
                    show();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila por favor");
                }
            }
            else
            {
                MessageBox.Show("El administrador tiene permiso.");
            }
        }

        private void comboBoxSearchOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(comboBoxSearchOne.Items[comboBoxSearchOne.SelectedIndex].ToString());
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
                //MessageBox.Show(comboBoxListOne.SelectedValue.ToString());
                if (comboBoxListOne.SelectedValue.Equals("Selecciona un dato") == false)
                {
                    string query = string.Empty;

                    query += " select distinct I.*, U.Nombre as 'Usuario' from Output as I, JoinEndeIncome as JEI, Ende as E, Users as U ";
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

                    query += " select distinct I.*, U.Nombre as 'Usuario' from Output as I, JoinEndeIncome as JEI, Ende as E, Users as U ";
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

                    query += " select distinct I.*, U.Nombre as 'Usuario' from Output as I, JoinEndeIncome as JEI, Ende as E, Users as U ";
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
