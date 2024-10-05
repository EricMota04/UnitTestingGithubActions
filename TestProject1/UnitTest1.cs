namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = ConsoleApp5.Program.Program.mensaje();

            Assert.AreEqual("Hola mundo", result);
        }
    }
}