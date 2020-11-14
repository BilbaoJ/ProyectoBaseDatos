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
    public partial class frmRegistroPaciente : Form
    {
        private string operacion = "";
        public frmRegistroPaciente()
        {
            InitializeComponent();
            mostrarPacientes();
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            mostrarPacientes();
            operacion = "NUEVOREGISTRO";
            txtIdentificacion.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            dtpFhNacimiento.Enabled = true;
            dtpFhRegistro.Enabled = true;
            limpiar();
            
        }

        private void mostrarPacientes()
        {
            dgvPacientes.DataSource = OperacionesPacientes.mostrar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacion = "EDITAR";
            txtEmail.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void editar()
        {
            txtIdentificacion.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            dtpFhNacimiento.Enabled = false;
            dtpFhRegistro.Enabled = false;
        }

        private void limpiar()
        {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
        }

        private void dgvPacientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtIdentificacion.Text = dgvPacientes.Rows[e.RowIndex].Cells["Identificacion"].Value.ToString();
            txtNombre.Text = dgvPacientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtApellido.Text = dgvPacientes.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            txtDireccion.Text = dgvPacientes.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
            txtTelefono.Text = dgvPacientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            txtEmail.Text = dgvPacientes.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            dtpFhNacimiento.Text = dgvPacientes.Rows[e.RowIndex].Cells["FhNacimiento"].Value.ToString();
            dtpFhRegistro.Text = dgvPacientes.Rows[e.RowIndex].Cells["FhRegistro"].Value.ToString();
            editar();          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (operacion == "EDITAR")
            {

                string identificacion = txtIdentificacion.Text;
                string email = txtEmail.Text;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;

                if (OperacionesPacientes.editar(identificacion, email, direccion, telefono))
                {
                    MessageBox.Show("La información ha sido actualizada", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarPacientes();
                }
                else
                {
                    MessageBox.Show("No se realizó la actualización", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (operacion == "NUEVOREGISTRO") {
                if (txtIdentificacion.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" ||
                dtpFhNacimiento.Text == "" || txtDireccion.Text == "" || txtEmail.Text == "" ||
                txtTelefono.Text == "" || dtpFhRegistro.Text == "")
                {
                    MessageBox.Show("Por favor ingrese todos los datos", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!txtEmail.Text.Contains("@"))
                {

                    MessageBox.Show("Por favor ingrese un correo válido", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtIdentificacion.Text.Length > 11) {

                    MessageBox.Show("Por favor ingrese un número de identificación válido de 11 digitos ", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (dtpFhNacimiento.Value.Date >= DateTime.Now.Date)
                {
                    MessageBox.Show("Por favor seleccione una fecha válida", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string identificacion = txtIdentificacion.Text;
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string fhNacimiento = dtpFhNacimiento.Text;
                    string direccion = txtDireccion.Text;
                    string email = txtEmail.Text;
                    string telefono = txtTelefono.Text;
                    string fhRegistro = dtpFhRegistro.Text;

                    if (OperacionesPacientes.registrarPaciente(identificacion, nombre, apellido, fhNacimiento,
                        direccion, telefono, email, fhRegistro))
                    {
                        MessageBox.Show("El registro se realizó con éxito", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarPacientes();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizar el registro", "",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnMultas_Click(object sender, EventArgs e)
        {
            dgvPacientes.DataSource = OperacionesPacientes.mostrarPacientesConMultas();
        }

        private void txtdentificacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
