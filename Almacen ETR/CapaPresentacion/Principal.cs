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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGetIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreenForm formETR = new LoginScreenForm();
            formETR.ShowDialog();
            formETR = null;
            this.Show();
        }
    }
}
