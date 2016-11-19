using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using BLL;
namespace BLL.Tests
{
    [TestClass()]
    public class VendedorBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Vendedor vendedor = new Vendedor();
            Assert.IsTrue(VendedorBLL.Guardar(vendedor));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsTrue(VendedorBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.Fail();
        }
    }
}