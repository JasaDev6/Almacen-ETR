using Almacen_ETR.CapaNegocio;
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
    public partial class OutputForm : Form
    {
        CN_Output objectCN = new CN_Output();
        private string IdIncomeOutput = null;
        private string IdOutput = null;
        private int IdUser;
        private bool editOutput = false;

        public OutputForm(int IdUse)
        {
            InitializeComponent();
            IdUser = IdUse;
        }

        public void getDataProducts(string Marca, string Modelo, string Tipo, string Nserie, string BDI, string ULab, string IdIn)
        {
            LabelMarca.Text = Marca;
            LabelModelo.Text = Modelo;
            LabelTipo.Text = Tipo;
            LabelNserie.Text = Nserie;
            LabelBDI.Text = BDI;
            LabelULab.Text = ULab;
            DateTime date = DateTime.Now;
            LabelDateOutput.Text = date.ToString();
            IdIncomeOutput = IdIn;
        }

        private void OutputForm_Load(object sender, EventArgs e)
        {
        }

        private bool Ischeckfields()
        {
            if (!string.IsNullOrEmpty(textBoxDestino.Text) && !string.IsNullOrEmpty(textBoxTDestino.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos");
                return false;
            }
        }

        private void btnConfirmDeparture_Click(object sender, EventArgs e)
        {
            if (editOutput == false)
            {
                try
                {
                    if (Ischeckfields())
                    {
                        objectCN.insert(textBoxDestino.Text, textBoxTDestino.Text, LabelDateOutput.Text, textBoxObs.Text, IdIncomeOutput, IdUser);
                        MessageBox.Show("Se inserto correctamente");
                        cleanForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                }
            }
            if (editOutput == true)
            {
                try
                {
                    objectCN.edit(textBoxDestino.Text, textBoxTDestino.Text, LabelDateOutput.Text, textBoxObs.Text, IdOutput);
                    MessageBox.Show("Se edito correctamente");
                    cleanForm();
                    editOutput = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puedo editar los datos por: " + ex);
                }
            }
        }

        public void getEditRegisterOutput(string Marca, string Modelo, string Tipo, string Nserie, string BDI, string ULab, string Destino, string TableroDestino, string FechaSalida, string Observacion, string IdOutputEdit, bool edit)
        {
            LabelMarca.Text = Marca;
            LabelModelo.Text = Modelo;
            LabelTipo.Text = Tipo;
            LabelNserie.Text = Nserie;
            LabelBDI.Text = BDI;
            LabelULab.Text = ULab;

            editOutput = edit;

            textBoxDestino.Text = Destino;
            textBoxTDestino.Text = TableroDestino;
            LabelDateOutput.Text = FechaSalida;
            textBoxObs.Text = Observacion;
            IdOutput = IdOutputEdit;
        }

        private void cleanForm()
        {
            textBoxDestino.Clear();
            textBoxTDestino.Clear();
            textBoxObs.Clear();
        }

    }
}
