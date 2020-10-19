using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual("A Test Password", class1.testOfPassword());
        }
    }
}