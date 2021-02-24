using Microsoft.VisualStudio.TestTools.UnitTesting;
using MeterSrNum;

namespace MeterSrNumTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstNumber()
        {
            // place all AAA
            //Arrange
            string meternum = "SDERS00M680MLSSBY1254LJU012";

            MeterSrNum.SrNum meter1 = new MeterSrNum.SrNum(meternum);

            //Assert
            bool finalResult = meter1.srNumCheck();
            Assert.IsTrue(finalResult);
        }

        [TestMethod]
        public void SecondNumber()
        {
            // place all AAA
            //Arrange
            string meternum = "SSBY1254LJU012";

            MeterSrNum.SrNum meter1 = new MeterSrNum.SrNum(meternum);

            //Assert
            bool finalResult = meter1.srNumCheck();
            Assert.IsTrue(finalResult);
        }
    }
}
