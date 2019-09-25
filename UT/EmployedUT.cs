using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using BLL;
using DTO;

namespace UT
{
    [TestClass]
    public class EmployedUT
    {
        private BLL.Employed employedDAL;

        [TestMethod]
        public void getEmployes()
        {
            employedDAL = new BLL.Employed();
            Assert.IsTrue(employedDAL.getEmployes().status);   
        }

        [TestMethod]
        public void getEmployed()
        {
            var idEmpleado = 1;
            var nameExpected = "Juan";
            employedDAL = new BLL.Employed();
            var nameActual = ((EmployedDTO)employedDAL.getEmployed(idEmpleado).data).name;
            Assert.AreEqual(nameExpected, nameActual);
        }

    }
}
