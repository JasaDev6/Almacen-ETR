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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Almacen_ETR
{
    public partial class IncomeStoreForm : Form
    {
        CN_ENDE objectCN = new CN_ENDE();
        private bool edit = false;
        private string Id = null;
        private string ende = null;
        private int IdUse;
        private int typeUser;
        private Conexion conexion = new Conexion();

        public IncomeStoreForm(string e, int IdU, int typeU)
        {
            InitializeComponent();
            ende = e;
            IdUse = IdU;
            typeUser = typeU;
            DateTime date1 = DateTime.Now;
            dateTimeIncome.Text = date1.ToString();
            if ("Transmisión".Equals(ende))
            {
                title.Text = "FORMULARIO DE ENTRADA DE REGISTRO TRANSMISIÓN";
            }
            if ("Corporación".Equals(ende))
            {
                title.Text = "FORMULARIO DE ENTRADA DE REGISTRO CORPORACIÓN";
            }
        }
        
        private void SelectComboBoxMarca()
        {
            comboBoxMarca.Items.Clear();
            conexion.Conectar();
            SqlCommand comand = new SqlCommand("select distinct Marca from NewType where Marca is not null and Marca <> ''", conexion.Conectar());
            SqlDataReader datareader = comand.ExecuteReader();
            while (datareader.Read())
            {
                comboBoxMarca.Items.Add(datareader[0].ToString());
            }
            conexion.Desconectar();
            comboBoxMarca.Items.Insert(0, "Seleccione una marca");
            comboBoxMarca.SelectedIndex = 0;
        }

        private void SelectComboBoxModelo()
        {
            comboBoxModelo.Items.Clear();
            conexion.Conectar();
            SqlCommand comand = new SqlCommand("select distinct Modelo from NewType where Modelo is not null and Modelo <> ''", conexion.Conectar());
            SqlDataReader datareader = comand.ExecuteReader();
            while (datareader.Read())
            {
                comboBoxModelo.Items.Add(datareader[0].ToString());
            }
            conexion.Desconectar();
            comboBoxModelo.Items.Insert(0, "Seleccione un modelo");
            comboBoxModelo.SelectedIndex = 0;
        }

        private void SelectComboBoxTipo()
        {
            comboBoxTipo.Items.Clear();
            conexion.Conectar();
            SqlCommand comand = new SqlCommand("select distinct Tipo from NewType where Tipo is not null and Tipo <> ''", conexion.Conectar());
            SqlDataReader datareader = comand.ExecuteReader();
            while (datareader.Read())
            {
                comboBoxTipo.Items.Add(datareader[0].ToString());
            }
            conexion.Desconectar();
            comboBoxTipo.Items.Insert(0, "Seleccione un Tipo");
            comboBoxTipo.SelectedIndex = 0;   
        }

        private void SelectComboBoxVnominal()
        {
            comboBoxVnominal.Items.Clear();
            conexion.Conectar();
            SqlCommand comand = new SqlCommand("select distinct Vnominal from NewType where Vnominal is not null and Vnominal <> ''", conexion.Conectar());
            SqlDataReader datareader = comand.ExecuteReader();
            while (datareader.Read())
            {
                comboBoxVnominal.Items.Add(datareader[0].ToString());
            }
            conexion.Desconectar();
            comboBoxVnominal.Items.Insert(0, "Seleccione un Vnominal");
            comboBoxVnominal.SelectedIndex = 0;
        }

        private void SelectComboBoxInominal()
        {
            comboBoxInominal.Items.Clear();
            conexion.Conectar();
            SqlCommand comand = new SqlCommand("select distinct Inominal from NewType where Inominal is not null and Inominal <> ''", conexion.Conectar());
            SqlDataReader datareader = comand.ExecuteReader();
            while (datareader.Read())
            {
                comboBoxInominal.Items.Add(datareader[0].ToString());
            }
            conexion.Desconectar();
            comboBoxInominal.Items.Insert(0, "Seleccione un Inominal");
            comboBoxInominal.SelectedIndex = 0;
        }

        private void IncomeStoreForm_Load(object sender, EventArgs e)
        {
            show(); 
            SelectComboBoxMarca();
            SelectComboBoxModelo();
            SelectComboBoxTipo();
            SelectComboBoxVnominal();
            SelectComboBoxInominal();
        }

        private void show()
        {
            if ("Transmisión".Equals(ende))
            {
                dataGridView.DataSource = objectCN.showETR();
            }
            if ("Corporación".Equals(ende))
            {
                dataGridView.DataSource = objectCN.showCORP();
            }
        }

        private bool Ischeckfields()
        {
            if (!string.IsNullOrEmpty(textBoxDescription.Text) && !string.IsNullOrEmpty(comboBoxMarca.Text) && !string.IsNullOrEmpty(comboBoxModelo.Text) && !string.IsNullOrEmpty(comboBoxTipo.Text) && !string.IsNullOrEmpty(textboxNserie.Text) && !string.IsNullOrEmpty(textboxOrigen.Text) && !string.IsNullOrEmpty(textboxEstado.Text)
                && !comboBoxMarca.SelectedItem.Equals("Seleccione una marca") && !comboBoxModelo.SelectedItem.Equals("Seleccione un modelo") && !comboBoxTipo.SelectedItem.Equals("Seleccione un Tipo") && !comboBoxVnominal.SelectedItem.Equals("Seleccione un Vnominal") && !comboBoxInominal.SelectedItem.Equals("Seleccione un Inominal"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos");
                return false;
            }
        }

        public int getLastDataTable()
        {
            Int32 index = dataGridView.Rows.Count - 1;
            string IdLast = dataGridView.Rows[index].Cells["Id"].Value.ToString();
            return Convert.ToInt32(IdLast);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                try
                {
                    if (Ischeckfields())
                    {
                        objectCN.insertETR(comboBoxMarca.Text, textBoxDescription.Text, comboBoxModelo.Text, textboxVersion.Text, comboBoxTipo.Text, comboBoxVnominal.Text, comboBoxInominal.Text, textboxNserie.Text, textboxBDI.Text, textboxOrigen.Text, textboxULab.Text, textboxEstado.Text, textboxTablero.Text, dateTimeIncome.Text, textboxObs.Text, ende, IdUse);
                        MessageBox.Show("Se inserto correctamente");
                        show();
                        cleanForm();
                        SelectComboBoxMarca();
                        SelectComboBoxModelo();
                        SelectComboBoxTipo();
                        SelectComboBoxVnominal();
                        SelectComboBoxInominal();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                }
            }
            if (edit == true)
            {
                try
                {
                    objectCN.editETR(comboBoxMarca.Text, textBoxDescription.Text, comboBoxModelo.Text, textboxVersion.Text, comboBoxTipo.Text, comboBoxVnominal.Text, comboBoxInominal.Text, textboxNserie.Text, textboxBDI.Text, textboxOrigen.Text, textboxULab.Text, textboxEstado.Text, textboxTablero.Text, dateTimeIncome.Text, textboxObs.Text, Id, ende);
                    MessageBox.Show("Se edito correctamente");
                    show();
                    cleanForm();
                    SelectComboBoxMarca();
                    SelectComboBoxModelo();
                    SelectComboBoxTipo();
                    SelectComboBoxVnominal();
                    SelectComboBoxInominal();
                    edit = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puedo editar los datos por: " + ex);
                }
            }
        }

        private void cleanForm()
        {
            comboBoxMarca.Items.Clear();
            textBoxDescription.Clear();
            comboBoxModelo.Items.Clear();
            comboBoxVnominal.Items.Clear();
            comboBoxInominal.Items.Clear();
            textboxVersion.Clear();
            comboBoxTipo.Items.Clear();
            textboxNserie.Clear();
            textboxBDI.Clear();
            textboxOrigen.Clear();
            textboxULab.Clear();
            textboxEstado.Clear();
            textboxTablero.Clear();
            textboxObs.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (typeUser == 1)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    edit = true;
                    comboBoxMarca.Text = dataGridView.CurrentRow.Cells["Marca"].Value.ToString();
                    textBoxDescription.Text = dataGridView.CurrentRow.Cells["Descripción"].Value.ToString();
                    comboBoxModelo.Text = dataGridView.CurrentRow.Cells["Modelo"].Value.ToString();
                    textboxVersion.Text = dataGridView.CurrentRow.Cells["Versión"].Value.ToString();
                    comboBoxTipo.Text = dataGridView.CurrentRow.Cells["Tipo"].Value.ToString();
                    comboBoxVnominal.Text = dataGridView.CurrentRow.Cells["Vnominal"].Value.ToString();
                    comboBoxInominal.Text = dataGridView.CurrentRow.Cells["Inominal"].Value.ToString();
                    textboxNserie.Text = dataGridView.CurrentRow.Cells["Nserie"].Value.ToString();
                    textboxBDI.Text = dataGridView.CurrentRow.Cells["BDI"].Value.ToString();
                    textboxOrigen.Text = dataGridView.CurrentRow.Cells["Origen"].Value.ToString();
                    textboxULab.Text = dataGridView.CurrentRow.Cells["Ulab"].Value.ToString();
                    textboxEstado.Text = dataGridView.CurrentRow.Cells["Estado"].Value.ToString();
                    textboxTablero.Text = dataGridView.CurrentRow.Cells["Tablero"].Value.ToString();
                    textboxObs.Text = dataGridView.CurrentRow.Cells["Observación"].Value.ToString();
                    Id = dataGridView.CurrentRow.Cells["Id"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila por favor");
                }
            }
            if (typeUser == 2)
            {
                DateTime date1 = DateTime.Now;
                string dateNow = date1.ToString();
                if (dataGridView.SelectedRows.Count > 0)
                {
                    //MessageBox.Show(dataGridView.CurrentRow.Cells["dateIncome"].Value.ToString());
                    //MessageBox.Show(dateNow);

                    if (dataGridView.CurrentRow.Cells["dateIncome"].Value.ToString().Equals("14/01/2021 00:00:00"))
                    {
                        edit = true;
                        comboBoxMarca.Text = dataGridView.CurrentRow.Cells["Marca"].Value.ToString();
                        textBoxDescription.Text = dataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                        comboBoxModelo.Text = dataGridView.CurrentRow.Cells["Modelo"].Value.ToString();
                        textboxVersion.Text = dataGridView.CurrentRow.Cells["Version"].Value.ToString();
                        comboBoxTipo.Text = dataGridView.CurrentRow.Cells["Tipo"].Value.ToString();
                        comboBoxVnominal.Text = dataGridView.CurrentRow.Cells["Vnominal"].Value.ToString();
                        comboBoxInominal.Text = dataGridView.CurrentRow.Cells["Inominal"].Value.ToString();
                        textboxNserie.Text = dataGridView.CurrentRow.Cells["Nserie"].Value.ToString();
                        textboxBDI.Text = dataGridView.CurrentRow.Cells["BDI"].Value.ToString();
                        textboxOrigen.Text = dataGridView.CurrentRow.Cells["Origen"].Value.ToString();
                        textboxULab.Text = dataGridView.CurrentRow.Cells["Ulab"].Value.ToString();
                        textboxEstado.Text = dataGridView.CurrentRow.Cells["Estado"].Value.ToString();
                        textboxTablero.Text = dataGridView.CurrentRow.Cells["Tablero"].Value.ToString();
                        textboxObs.Text = dataGridView.CurrentRow.Cells["Observacion"].Value.ToString();
                        Id = dataGridView.CurrentRow.Cells["Id"].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione columna correcta");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila por favor");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (typeUser == 1)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    Id = dataGridView.CurrentRow.Cells["Id"].Value.ToString();
                    objectCN.deleteETR(Id);
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

        private void btnExportIntoExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanForm();
            SelectComboBoxMarca();
            SelectComboBoxModelo();
            SelectComboBoxTipo();
            SelectComboBoxVnominal();
            SelectComboBoxInominal();
        }

    }
}
