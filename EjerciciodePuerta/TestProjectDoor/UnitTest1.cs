using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectDoor
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            door.Door door = new door.Door();

            bool respuesta = door.isClose();

            Assert.AreEqual(true, respuesta);
        }
    }
}
