using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnalyzingPings.UnitTest
{
    [TestClass]
    public class PingStatisticsTests
    {
        [TestMethod]
        public void ComputeMean_()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.ComputeMean()
            //Assert
            Assert.AreEqual()
        }
    }
}
