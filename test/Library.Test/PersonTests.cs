using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void TestValidName()
        {
            Person p = new Person("Walter Taño", "5.461.647-3");
            string expected = "Walter Taño";
            Assert.AreEqual(expected, p.Name);
        }

        [Test]
        public void TestValidID()
        {
            Person p = new Person("Walter Taño", "5.461.647-3");
            string expected = "5.461.647-3";
            Assert.AreEqual(expected, p.ID);
        }

        [Test]
        public void TestInvalidName()
        {
            Person p = new Person("", "5.461.647-3");
            Assert.AreEqual(null, p.Name);
        }

        [Test]
        public void TestInvalidID()
        {
            Person p = new Person("Walter Taño", "5.461.647-4");
            Assert.AreEqual(null, p.ID);
        }
    }
}