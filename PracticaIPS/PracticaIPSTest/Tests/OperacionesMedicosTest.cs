using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaIPS;


namespace PracticaIPSTest.Tests
{
    [TestClass]
    public class OperacionesMedicosTest
    {
        [TestMethod]
        public void RegistroMedicoTest()
        {
            string cedula = "12584769";
            string nombre = "Leonardo";
            string apellido = "Gonzalez";
            string especialidad = "Optómetra";
            double salarioCita = 20000 ;
            string añosExperiencia = "15";

            bool resultado = OperacionesMedicos.registrarMedico(cedula, nombre, apellido, especialidad,
                        salarioCita, añosExperiencia);

            Assert.AreEqual(true, resultado, "No se pudo realizar el registro");
        }
    }
}
