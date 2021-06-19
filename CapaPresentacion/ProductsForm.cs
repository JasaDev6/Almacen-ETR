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
    public partial class ProductsForm : Form
    {

        private Conexion conexion = new Conexion();
        CN_Products objectCN = new CN_Products();
        private string Id = null;
        private bool edit = false;

        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            show();
        }

        private void show()
        {
            dataGridView1.DataSource = objectCN.show();
        }

        private void Ischeckfields()
        {
            //if (!string.IsNullOrEmpty(textBoxMarca.Text))
            //{
               
            //}
            //else
            //{
            //    textBoxMarca.SelectedText = null;
            //}
            //if (!string.IsNullOrEmpty(textBoxModelo.Text))
            //{
            //    return true;
            //}
            //if (!string.IsNullOrEmpty(textBoxVnominal.Text))
            //{
            //    return true;
            //}
            //if (!string.IsNullOrEmpty(textBoxInominal.Text))
            //{
            //    return true;
            //}
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                try
                {
                    Ischeckfields();
                    objectCN.insert(textBoxMarca.Text, textBoxModelo.Text, textBoxVnominal.Text, textBoxInominal.Text);
                    MessageBox.Show("se inserto correctamente");
                    show();
                    cleanForm();
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
                    objectCN.edit(textBoxMarca.Text, textBoxModelo.Text, textBoxVnominal.Text, textBoxInominal.Text, Id);
                    MessageBox.Show("se edito correctamente");
                    show();
                    cleanForm();
                    edit = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }
            }
        }

        private void cleanForm()
        {
            textBoxMarca.Clear();
            textBoxModelo.Clear();
            textBoxVnominal.Clear();
            textBoxInominal.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                edit = true;
                Id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                textBoxMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                textBoxModelo.Text = dataGridView1.CurrentRow.Cells["Modelo"].Value.ToString();
                textBoxVnominal.Text = dataGridView1.CurrentRow.Cells["Vnominal"].Value.ToString();
                textBoxInominal.Text = dataGridView1.CurrentRow.Cells["Inominal"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objectCN.delete(Id);
                MessageBox.Show("Eliminado Correctamente");
                show();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanForm();
        }
    }
}
