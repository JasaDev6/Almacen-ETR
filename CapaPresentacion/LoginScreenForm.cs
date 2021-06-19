using Almacen_ETR.CapaPresentacion;
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

namespace Almacen_ETR
{
    public partial class LoginScreenForm : Form
    {
       
        Conexion conexion = new Conexion();
        SqlDataReader read;
        private int type;
        public int IdUse;

        public LoginScreenForm()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*';
        }

        private void LoginScreenForm_Load(object sender, EventArgs e)
        {
            textUser.Select();
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPasswordCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == false)
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }

        public int getIdUse()
        {
            return IdUse;
        } 

        private void BtnEnter_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textUser.Text) && !string.IsNullOrEmpty(textPassword.Text))
            {
                string mySQL = string.Empty;
                mySQL += "SELECT * FROM Users ";
                mySQL += "WHERE Usuario = '" + textUser.Text + "' ";
                mySQL += "AND Contraseña = '" + textPassword.Text + "'";

                SqlCommand comand = new SqlCommand(mySQL, conexion.Conectar());
                read = comand.ExecuteReader();
                if (read.HasRows!=false)
                {
                    while (read.Read())
                    {
                        type = read.GetInt32(5);
                        IdUse = read.GetInt32(0);
                    }
                    read.Close();
                    textUser.Clear();
                    textPassword.Clear();
                    ShowPasswordCheckBox.Checked = false;
                    
                    this.Hide();
                    MenuAdminForm formMenu = new MenuAdminForm(IdUse, type);
                    formMenu.ShowDialog(); 
                    formMenu = null;
                    this.Show();
                    this.textUser.Select();
                }
                else
                {
                    MessageBox.Show("El usuario no se encuentra registrado");
                    textUser.Focus();
                    read.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.");
                textUser.Select();
            }
        }

    }
}
