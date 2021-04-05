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

        private void MenuItemSearchUserIncomeETR_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchIncomeUserForm formETR = new SearchIncomeUserForm("Transmisión");
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }

        private void MenuItemSearchUserIncomeCORP_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchIncomeUserForm formETR = new SearchIncomeUserForm("Corporación");
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }

        private void MenuItemSearchUserOutputETR_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchOutputUserForm formETR = new SearchOutputUserForm("Transmisión");
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }

        private void MenuItemSearchUserOutputCORP_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchOutputUserForm formETR = new SearchOutputUserForm("Corporación");
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm formUser = new UserForm();
            formUser.ShowDialog();
            formUser = null;
            this.Show();
        }

        private void btnNewTipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsForm formETR = new ProductsForm();
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }

        private void btnIncomeETR_Click(object sender, EventArgs e)
        {
            this.Hide();
            IncomeStoreForm formETR = new IncomeStoreForm("Transmisión", IdUse, typeUser);
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }

        private void btnIncomeCORP_Click(object sender, EventArgs e)
        {
            this.Hide();
            IncomeStoreForm formETR = new IncomeStoreForm("Corporación", IdUse, typeUser);
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }

        private void btnOutputETR_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistryOutputForm formETR = new RegistryOutputForm(IdUse, typeUser, "Transmisión");
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }

        private void btnOutputCORP_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistryOutputForm formETR = new RegistryOutputForm(IdUse, typeUser, "Corporación");
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }

        private void MenuItemNewTipe_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsForm formETR = new ProductsForm();
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }

        private void MenuItemNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm formUser = new UserForm();
            formUser.ShowDialog();
            formUser = null;
            this.Show();
        }

        private void MenuItemRegisterIncomeETR_Click(object sender, EventArgs e)
        {
            this.Hide();
            IncomeStoreForm formETR = new IncomeStoreForm("Transmisión", IdUse, typeUser);
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }

        private void MenuItemRegisterIncomeCORP_Click(object sender, EventArgs e)
        {
            this.Hide();
            IncomeStoreForm formETR = new IncomeStoreForm("Corporación", IdUse, typeUser);
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }

        private void MenuItemSearchUserETR_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchIncome formETR = new SearchIncome("Transmisión", IdUse);
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }

        private void MenuItemSearchUserCORP_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchIncome formETR = new SearchIncome("Corporación", IdUse);
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Inventario Laboratorio Protecciones" +
                            "\nVersión 1.0.0" +
                            "\n" + DateTime.Now.Year + "Propiedad de ENDE TRANSMISIÓN" + 
                            "\nDesarrollado por el Ingeniero Juan Antonio Sabath Awad" +
                            "\nCelular 65368964" +
                            "\nLinkedIn https://www.linkedin.com/in/antoniosabath/");
        }
    }
}
