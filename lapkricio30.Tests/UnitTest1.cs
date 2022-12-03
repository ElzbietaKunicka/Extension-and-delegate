using extension;
using Microsoft.VisualStudio.CodeCoverage;

namespace lapkricio30.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(-10, false)]
        [DataRow(10, true)]
        
        public void TestMethod1(int number, bool expectedResult)
        {
            var result = number.IsPositive();
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        [DataRow(9, false)]
        [DataRow(10, true)]

        public void TestMethod2(int number, bool expectedResult)
        {
            var result = number.IsEven();
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        [DataRow(9, false)]
        [DataRow(10, false)]
        [DataRow(11, true)]

        public void TestMethod3(int number, bool expectedResult)
        {
            var result = number.IsBigger(10);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        [DataRow("labas", false)]
        [DataRow("laba diena", true)]
        [DataRow("katinas", false)]

        public void TestMethod4(string number, bool expectedResult)
        {
            var result = number.HasGap();
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        [DataRow("deividas", 93, "hotmail", "deividas93@hotmail")]
        
        public void TestMethod5( string fullname, int yearOfBirth, string domain, string expectedResult)
        {
            var result = fullname.HasParam(yearOfBirth, domain);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        

        public void TestMethod6()
        {
            var ourList = new List<string>()
            {
                "vardas",
                "pavarde"

            };
            var result = ourList.EveryOtherWord();
            Assert.AreEqual(result.Count, 1);
            Assert.AreEqual(result.First(), "vardas");
            
        }




    }
}