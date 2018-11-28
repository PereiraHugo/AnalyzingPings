using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using AnalyzingPings;
using System;

namespace AnalyzingPings.UnitTest
{
    [TestClass]
    public class PingStatisticsTests
    {
        /// <summary>
        /// PingStatisticsTests is a class to test the methods from PingStatistics class
        /// </summary>
        /// <summary>
        /// Two example sets used to test the methods, one odd and one even to test in both scenario
        /// </summary>
        private List<long> evenset = new List<long> { 10, 20, 40, 50 };
        private List<long> oddset = new List<long> { 10, 10, 20, 40, 50 };


        /// <summary>
        /// Method to test ComputeMean method with the even set, and the expected result is 30
        /// </summary>
        [TestMethod]
        public void ComputeMean_EvenSet_isEqual30()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.ComputeMean(this.evenset);
            //Assert
            Assert.AreEqual(30, result);
        }

        /// <summary>
        /// Method to test ComputeMean method with the odd set, and the expected result is 26
        /// </summary>
        [TestMethod]
        public void ComputeMean_OddSet_isEqual26()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.ComputeMean(this.oddset);
            //Assert
            Assert.AreEqual(26, result);
        }

        /// <summary>
        /// Method to test ComputeMedian method with the even set, and the expected result is 30
        /// </summary>
        [TestMethod]
        public void ComputeMedian_EvenSet_isEqual30()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.ComputeMedian(this.evenset);
            //Assert
            Assert.AreEqual(30, result);
        }

        /// <summary>
        /// Method to test ComputeMedian method with the odd set, and the expected result is 20
        /// </summary>
        [TestMethod]
        public void ComputeMedian_OddSet_isEqual20()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.ComputeMedian(this.oddset);
            //Assert
            Assert.AreEqual(20, result);
        }

        /// <summary>
        /// Method to test IdentifyUnique method with the odd set, and the expected result is equal to even set
        /// </summary>
        [TestMethod]
        public void IdentifyUnique_OddSet_IsEqualtoEvenSet()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.IdentifyUnique(this.oddset);
            //Assert
            CollectionAssert.AreEqual(this.evenset, result);
        }

        /// <summary>
        /// Method to test IdentifyUnique method with the even set, and the expected result is equal to even set
        /// </summary>
        [TestMethod]
        public void IdentifyUnique_EvenSet_NoChange()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.IdentifyUnique(this.evenset);
            //Assert
            CollectionAssert.AreEqual(this.evenset, result);
        }

        /// <summary>
        /// Method to test ComputeVariance method with the odd set, and the expected result is 264
        /// </summary>
        [TestMethod]
        public void ComputeVariance_OddSet_IsEqualto264()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.ComputeVariance(this.oddset);
            //Assert
            Assert.AreEqual(264, result);
        }

        /// <summary>
        /// Method to test ComputeVariance method with the even set, and the expected result is 250
        /// </summary>
        [TestMethod]
        public void ComputeVariance_EvenSet_IsEqualto250()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.ComputeVariance(this.evenset);
            //Assert
            Assert.AreEqual(250, result);
        }

        /// <summary>
        /// Method to test ComputeStdDeviation method with the odd set, and the expected result is 16.25
        /// </summary>
        [TestMethod]
        public void ComputeStdDeviation_OddSet_IsEqualto250()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.ComputeStdDeviation(this.oddset);
            //Assert
            Assert.AreEqual(16.25, Math.Round(result,2));
        }

        /// <summary>
        /// Method to test ComputeStdDeviation method with the even set, and the expected result is 15.81
        /// </summary>
        [TestMethod]
        public void ComputeStdDeviation_EvenSet_IsEqualto250()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.ComputeStdDeviation(this.evenset);
            //Assert
            Assert.AreEqual(15.81, Math.Round(result,2));
        }

        /// <summary>
        /// Method to test IdentifyFirstQuartile method with the even set, and the expected result is 10
        /// </summary>
        [TestMethod]
        public void IdentifyFirstQuartile_OddSet_IsEqualto10()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.IdentifyFirstQuartile(this.evenset);
            //Assert
            Assert.AreEqual(10, result);
        }

        /// <summary>
        /// Method to test IdentifyFirstQuartile method with the even set, and the expected result is 10
        /// </summary>
        [TestMethod]
        public void IdentifyFirstQuartile_EvenSet_IsEqualto10()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.IdentifyFirstQuartile(this.evenset);
            //Assert
            Assert.AreEqual(10, result);
        }

        /// <summary>
        /// Method to test IdentifyThirdQuartile method with the even set, and the expected result is 15.81
        /// </summary>
        [TestMethod]
        public void IdentifyThirdQuartile_OddSet_IsEqualto10()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.IdentifyThirdQuartile(this.evenset);
            //Assert
            Assert.AreEqual(40, result);
        }

        /// <summary>
        /// Method to test IdentifyThirdQuartile method with the even set, and the expected result is 15.81
        /// </summary>
        [TestMethod]
        public void IdentifyThirdQuartile_EvenSet_IsEqualto10()
        {
            //Arrange
            var pingstat = new PingStatistics();
            //Act
            var result = pingstat.IdentifyThirdQuartile(this.evenset);
            //Assert
            Assert.AreEqual(40, result);
        }
    }
}
