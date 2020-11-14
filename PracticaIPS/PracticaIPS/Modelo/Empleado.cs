using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaIPS
{
    public class Empleado
    {
        private String identificacion;
        private String contraseña;

        public Empleado(string identificacion, string contraseña)
        {
            this.identificacion = identificacion;
            this.contraseña = contraseña;
        }

        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}
