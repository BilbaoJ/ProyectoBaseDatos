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
    public partial class frmCitas : Form
    {
        string operacion = "";
        public frmCitas()
        {
            InitializeComponent();
        }


        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            btnConfirmarCita.Enabled = false;
            dgvCitas.DataSource = OperacionesCitas.mostrarCitas();
            if (cmbMedico.Text == "" || cmbPaciente.Text == "") {
                MessageBox.Show("Por favor ingrese todos los datos", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dtpFechaCita.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Por favor seleccione una fecha válida", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string medico = cmbMedico.Text;
                string paciente = cmbPaciente.Text;
                string fecha = dtpFechaCita.Text;
                int operacion = OperacionesCitas.guardarCita(medico, paciente, fecha);

                switch (operacion)
                {
                    case 0:
                        MessageBox.Show("Se ha registrado la cita con éxito", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        MessageBox.Show("No se pudo registrar la cita", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2:
                        MessageBox.Show("Verifique que el paciente esté a paz y salvo", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 3:
                        MessageBox.Show("Ya ha sido asignada una cita con esta especialidad", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 4:
                        MessageBox.Show("No puede programar más citas", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                  
            }
        }

        private void médicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistroMedico frmRegistroMedico = new frmRegistroMedico();
            frmRegistroMedico.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroPaciente frmRegistroPaciente = new frmRegistroPaciente();
            frmRegistroPaciente.Show();
        }

        private void btnCitasIncump_Click(object sender, EventArgs e)
        {
            dgvCitas.DataSource = OperacionesCitas.mostrarCitasIncumplidas();
            btnConfirmarCita.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvCitas.DataSource = OperacionesCitas.mostrarCitasDePaciente(cmbIdBuscarCitas.Text);
            operacion = "CONFIRMAR";
            btnConfirmarCita.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActiveForm.Dispose();
            frmCitas cargar = new frmCitas();
            cargar.Show();
            btnConfirmarCita.Enabled = false;
        }

        private void btnConfirmarCita_Click(object sender, EventArgs e)
        {
            
            if (OperacionesCitas.confirmarCita(cmbMedico.Text, cmbPaciente.Text))
            {
                MessageBox.Show("Se actualizó la cita con éxito", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                operacion = "";
                cmbMedico.Enabled = true;
                cmbPaciente.Enabled = true;
                dtpFechaCita.Enabled = true;
                btnConfirmarCita.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se pudo actulizar la cita", "",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                operacion = "";
                cmbMedico.Enabled = true;
                cmbPaciente.Enabled = true;
                dtpFechaCita.Enabled = true;
                btnConfirmarCita.Enabled = false;
            }
        }

        private void dgvCitas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (operacion == "CONFIRMAR")
            {
                cmbMedico.Enabled = false;
                cmbPaciente.Enabled = false;
                dtpFechaCita.Enabled = false;
                cmbMedico.Text = dgvCitas.Rows[e.RowIndex].Cells["CedulaMedico"].Value.ToString();
                cmbPaciente.Text = dgvCitas.Rows[e.RowIndex].Cells["IdentificacionPaciente"].Value.ToString();
                dtpFechaCita.Text = dgvCitas.Rows[e.RowIndex].Cells["FechaCita"].Value.ToString();

            }

        }

        private void txtIdPaciente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIdMedico_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmCitas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iPSDataSet1.tbPacientes' Puede moverla o quitarla según sea necesario.
            this.tbPacientesTableAdapter.Fill(this.iPSDataSet1.tbPacientes);
            // TODO: esta línea de código carga datos en la tabla 'iPSDataSet.tbMedicos' Puede moverla o quitarla según sea necesario.
            this.tbMedicosTableAdapter.Fill(this.iPSDataSet.tbMedicos);

        }

        private void dtpFechaCita_Validating(object sender, CancelEventArgs e)
        {
            if (dtpFechaCita.Value < DateTime.Now)
            {
                e.Cancel = true;
            }
        }
    }
}
