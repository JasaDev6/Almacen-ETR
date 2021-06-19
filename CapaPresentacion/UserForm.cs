using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Almacen_ETR
{
    public partial class UserForm : Form
    {
        private Conexion conexion = new Conexion();
        SqlDataReader read;
        CN_Users objectCN = new CN_Users();
        private string Id = null;
        private bool edit = false;
        private bool result;
        private int typeUser = 2;

        public UserForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showUser();
        }

        private void showUser() 
        {
            CN_Users objectCN2 = new CN_Users();
            dataGridView1.DataSource = objectCN2.showUser();
        }

        private bool Ischeckfields()
        {
            if (!string.IsNullOrEmpty(textNEmpleado.Text) && !string.IsNullOrEmpty(textName.Text) && !string.IsNullOrEmpty(textUser.Text) && !string.IsNullOrEmpty(textPassword.Text))
            {
                string mySQL = string.Empty;
                mySQL += "SELECT * FROM Users WHERE NEmpleado ='" + Convert.ToInt32(textNEmpleado.Text) + "'";
                SqlCommand comand = new SqlCommand(mySQL, conexion.Conectar());
                read = comand.ExecuteReader();
                if (read.HasRows!=false)
                {
                    MessageBox.Show("Existe usuario registrado con el numero de empleado");
                    result = false;
                }
                else
                {
                    result = true;
                }
                read.Close();
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos");
                result = false;
            }
            return result;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                try
                {
                    if (Ischeckfields())
                    {
                        objectCN.insertUser(textNEmpleado.Text, textName.Text, textUser.Text, textPassword.Text, typeUser);
                        MessageBox.Show("se inserto correctamente");
                        showUser();
                        cleanForm();
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
                    objectCN.editUser(textNEmpleado.Text, textName.Text, textUser.Text, textPassword.Text, Id);
                    MessageBox.Show("se edito correctamente");
                    showUser();
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
            textNEmpleado.Clear();
            textName.Clear();
            textUser.Clear();
            textPassword.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                edit = true;
                Id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                textNEmpleado.Text = dataGridView1.CurrentRow.Cells["NEmpleado"].Value.ToString();
                textName.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textUser.Text = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
                textPassword.Text = dataGridView1.CurrentRow.Cells["Contraseña"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 )
            {
                Id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objectCN.deleteUser(Id);
                MessageBox.Show("Eliminado Correctamente");
                showUser();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

    }
}
