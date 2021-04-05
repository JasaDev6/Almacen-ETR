﻿using System;
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
    public partial class SearchIncome : Form
    {
        CN_ENDE objectCN = new CN_ENDE();
        Conexion conexion = new Conexion();
        private int IdUser;
        private int endeId;

        public SearchIncome(string endeName, int IdUse)
        {
            InitializeComponent();
            LoadDataOne();
            LoadDataTwo();
            LoadDataThree();
            IdUser = IdUse;
            if ("Transmisión".Equals(endeName))
            {
                endeId = 1;
                title.Text = "BUSQUEDA DE INGRESOS ENDE TRANSMISIÓN";
                dataGridView.DataSource = objectCN.showETR();
            }
            if ("Corporación".Equals(endeName))
            {
                endeId = 2;
                title.Text = "BUSQUEDA DE INGRESOS ENDE CORPORACIÓN";
                dataGridView.DataSource = objectCN.showCORP();
            }
        }

        private void LoadDataOne()
        {
            SqlDataAdapter da = new SqlDataAdapter("select COLUMN_NAME from information_schema.columns where table_name = 'Income' and COLUMN_NAME <> 'Id'", conexion.Conectar());
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
            SqlDataAdapter da = new SqlDataAdapter("select COLUMN_NAME from information_schema.columns where table_name = 'Income' and COLUMN_NAME <> 'Id'", conexion.Conectar());
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
            SqlDataAdapter da = new SqlDataAdapter("select COLUMN_NAME from information_schema.columns where table_name = 'Income' and COLUMN_NAME <> 'Id'", conexion.Conectar());
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

        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                string Marca = dataGridView.CurrentRow.Cells["Marca"].Value.ToString();
                string Modelo = dataGridView.CurrentRow.Cells["Modelo"].Value.ToString();
                string Tipo = dataGridView.CurrentRow.Cells["Tipo"].Value.ToString();
                string Nserie = dataGridView.CurrentRow.Cells["Nserie"].Value.ToString();
                string BDI = dataGridView.CurrentRow.Cells["BDI"].Value.ToString();
                string ULab = dataGridView.CurrentRow.Cells["Ulab"].Value.ToString();
                string Id = dataGridView.CurrentRow.Cells["Id"].Value.ToString();
                this.Hide();
                OutputForm formETR = new OutputForm(IdUser);
                formETR.getDataProducts(Marca, Modelo, Tipo, Nserie, BDI, ULab, Id);
                formETR.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
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

        private void SearchIncome_Load(object sender, EventArgs e)
        {
     
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

    }
}
