using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaIPS;

namespace PracticaIPSTest.Tests
{
    [TestClass]
    public class EmpleadoTest
    {
        [TestMethod]
        public void InicioDeSesionTest()
        {
            string identificacion = "123456789";
            string contraseña = "000000";
            Empleado empleado = new Empleado(identificacion, contraseña);
            frmInicioSesion.empleados.Add(empleado);

            int resultado = frmInicioSesion.iniciarSesion(identificacion, contraseña);

            Assert.AreEqual(0, resultado, "No se inició sesión correctamente");
        }

        [TestMethod]
        public void registroTest()
        {
            string identificacion = "987654321";
            string contraseña = "000000";

            bool resultado = frmInicioSesion.registrarEmpleado(identificacion, contraseña);

            Assert.AreEqual(false, resultado, "Este usuario ya ha sido registrado");
        }
    }
}
