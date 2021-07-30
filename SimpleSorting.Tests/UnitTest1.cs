using NUnit.Framework;

namespace SimpleSorting.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assign 
            var sut = new Class1();

            //Act
            var result = sut.Test();

            //Assert

            Assert.AreEqual(1, result, "Result should be 1");
        }
    }
}