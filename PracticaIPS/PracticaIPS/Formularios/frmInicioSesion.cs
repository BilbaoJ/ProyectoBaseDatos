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
    
    public partial class frmInicioSesion : Form
    {
        public static List<Empleado> empleados = new List<Empleado>();
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        static public bool registrarEmpleado(string identificacion, string contraseña)
        {
            foreach (Empleado empleado in empleados)
            {
                if (empleado.Identificacion == identificacion)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Por favor ingrese todos los datos", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (registrarEmpleado(txtIdentificacion.Text, txtContraseña.Text))
                {
                    MessageBox.Show("Este usuario ya ha sido registrado", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string identificacion = txtIdentificacion.Text;
                    string contraseña = txtContraseña.Text;
                    Empleado nuevoEmpleado = new Empleado(identificacion, contraseña);
                    empleados.Add(nuevoEmpleado);
                    MessageBox.Show("Se ha registrado con éxito", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        static public int iniciarSesion(string identificacion, string contraseña)
        {
            foreach (Empleado empleado in empleados)
            {
                if (empleado.Identificacion == identificacion)
                {
                    if (empleado.Contraseña == contraseña)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            return 2;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if(txtIdentificacion.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Por favor llenar todos los campos", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int resultado = iniciarSesion(txtIdentificacion.Text, txtContraseña.Text);

                switch (resultado)
                {
                    case 0:
                        frmCitas frmCitas = new frmCitas();
                        frmCitas.Show();
                        break;
                    case 1:
                        MessageBox.Show("Contraseña incorrecta", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 2:
                        MessageBox.Show("La identificación no está registrada", "",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
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
