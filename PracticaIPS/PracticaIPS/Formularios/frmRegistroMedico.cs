using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaIPS
{
    public partial class frmRegistroMedico : Form
    {
        private string operacion = "" ;
        public frmRegistroMedico()
        {
            InitializeComponent();
            mostrarMedicos();
        }

        private void btnRegistroMedico_Click(object sender, EventArgs e)
        {
            operacion = "NUEVOREGISTRO";
            txtCedula.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            cmbEspecialidad.Enabled = true;
            txtSalario.Enabled = true;
            numUDañosExp.Enabled = true;
            limpiar();
        }

        private void mostrarMedicos()
        {
            dgvMedicos.DataSource = OperacionesMedicos.mostrar();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacion = "EDITAR";
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtSalario.Enabled = true;
        }

        private void editar() {

            txtCedula.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            cmbEspecialidad.Enabled = false;
            txtSalario.Enabled = false;
            numUDañosExp.Enabled = false;
        }

        private void limpiar()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbEspecialidad.Text = "";
            txtSalario.Text = "";
            numUDañosExp.Text = "";
        }


        private void dgvMedicos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCedula.Text = dgvMedicos.Rows[e.RowIndex].Cells["Cedula"].Value.ToString();
            txtNombre.Text = dgvMedicos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtApellido.Text = dgvMedicos.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            cmbEspecialidad.Text = dgvMedicos.Rows[e.RowIndex].Cells["Especialidad"].Value.ToString();
            txtSalario.Text = dgvMedicos.Rows[e.RowIndex].Cells["SalarioCita"].Value.ToString();
            numUDañosExp.Text = dgvMedicos.Rows[e.RowIndex].Cells["AñosExperiencia"].Value.ToString();
            editar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (operacion == "EDITAR")
            {

                string cedula = txtCedula.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                double salarioCita = Convert.ToDouble(txtSalario.Text);

                if (OperacionesMedicos.editar(cedula, nombre, apellido,
                    salarioCita))
                {
                    MessageBox.Show("La información ha sido actualizada", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarMedicos();
                }
                else
                {
                    MessageBox.Show("No se realizó la actualización", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (operacion == "NUEVOREGISTRO") {
                if (txtCedula.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" ||
                cmbEspecialidad.Text == "" || txtSalario.Text == "" || numUDañosExp.Text == "")
                {
                    MessageBox.Show("Por favor ingrese todos los datos", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtCedula.Text.Length > 11)
                {

                    MessageBox.Show("Por favor ingrese un número de cédula válido de 11 digitos ", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string cedula = txtCedula.Text;
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string especialidad = cmbEspecialidad.Text;
                    double salarioCita = Convert.ToDouble(txtSalario.Text);
                    string añosExperiencia = numUDañosExp.Text;

                    if (OperacionesMedicos.registrarMedico(cedula, nombre, apellido, especialidad,
                        salarioCita, añosExperiencia))
                    {
                        MessageBox.Show("El registro se realizó con éxito", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarMedicos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizar el registro", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
