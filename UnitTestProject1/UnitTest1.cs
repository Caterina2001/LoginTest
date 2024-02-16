using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAccess()
        {
            string result = Login.Program.FirstAccess();
            Assert.AreEqual("Succesfull", result);
        }
        
        [TestMethod]
        public void TestLoginRight()
        {
            bool result = Login.Program.Log("prueba1", "prueba123@");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestLoginWrong()
        {
            bool result = Login.Program.Log("Prueba1", "prueba123@");
            Assert.AreEqual(false, result);
           
        }
    }
}
