using Almacen_ETR.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen_ETR
{
    public partial class MenuAdminForm : Form
    {
        private int IdUse;
        private int typeUser;

        public MenuAdminForm(int IdU, int typeU)
        {
            IdUse = IdU;
            typeUser = typeU;
            InitializeComponent();
        }

        private void openForm(object formUser)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }
            Form fh = formUser as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = formUser;
            fh.Show();
        }

        private void MenuItemSearchUserOutputETR_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //SearchOutputUserForm formETR = new SearchOutputUserForm("Transmisión");
            //formETR.ShowDialog();
            //formETR = null;
            //this.Show();

            openForm(new SearchOutputUserForm("Transmisión"));

        }

        private void MenuItemSearchUserOutputCORP_Click(object sender, EventArgs e)
        {
            openForm(new SearchOutputUserForm("Corporación"));
        }

        private void btnIncomeETR_Click(object sender, EventArgs e)
        {
            openForm(new IncomeStoreForm("Transmisión", IdUse, typeUser));
        }

        private void btnIncomeCORP_Click(object sender, EventArgs e)
        {
            openForm(new IncomeStoreForm("Corporación", IdUse, typeUser));
        }

        private void btnOutputETR_Click(object sender, EventArgs e)
        {
            openForm(new RegistryOutputForm(IdUse, typeUser, "Transmisión"));
        }

        private void btnOutputCORP_Click(object sender, EventArgs e)
        {
            openForm(new RegistryOutputForm(IdUse, typeUser, "Corporación"));
        }

        private void MenuItemNewTipe_Click(object sender, EventArgs e)
        {
            if (typeUser==1)
            {
                openForm(new ProductsForm());
            }
            else
            {
                MessageBox.Show("No tiene acceso solo el administrador");
            }
        }

        private void MenuItemNewUser_Click(object sender, EventArgs e)
        {
            if (typeUser == 1)
            {
                openForm(new UserForm());
            }
            else
            {
                MessageBox.Show("No tiene acceso solo el administrador");
            }
        }

        private void MenuItemRegisterIncomeETR_Click(object sender, EventArgs e)
        {
            openForm(new IncomeStoreForm("Transmisión", IdUse, typeUser));
        }

        private void MenuItemRegisterIncomeCORP_Click(object sender, EventArgs e)
        {
            openForm(new IncomeStoreForm("Corporación", IdUse, typeUser));
        }

        private void MenuItemSearchUserETR_Click(object sender, EventArgs e)
        {
            openForm(new SearchIncome("Transmisión", IdUse));
        }

        private void MenuItemSearchUserCORP_Click(object sender, EventArgs e)
        {
             openForm(new SearchIncome("Corporación", IdUse));
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Inventario Laboratorio Protecciones" +
                            "\nVersión 2.0.0" +
                            "\n" + DateTime.Now.Year + "Propiedad de ENDE TRANSMISIÓN" + 
                            "\nDesarrollado por el Ingeniero Juan Antonio Sabath Awad" +
                            "\nCelular 65368964" +
                            "\nLinkedIn https://www.linkedin.com/in/antoniosabath/");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuItemSearchIngresosETR_Click(object sender, EventArgs e)
        {
            openForm(new SearchIncomeUserForm("Transmisión"));
        }

        private void MenuItemSearchIngresosCORP_Click(object sender, EventArgs e)
        {
            openForm(new SearchIncomeUserForm("Corporación"));
        }

    }
}
