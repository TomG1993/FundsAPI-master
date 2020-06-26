/********************************************************************************************
* UnitTest1.cs
* Created on: 24/06/2020
* Created by: Tom Gorton
*******************************************************************************************/

namespace FundsUnitTests
{
    using Api.DataFiles;
    using Api.Services;
    using Api.Services.Interfaces;
    using Xunit;

    /// <summary>
    /// Defines the <see cref="GetFundsTest" />.
    /// </summary>
    public class GetFundsTest
    {
        /// <summary>
        /// The GetFundsTest_ValidId_
        /// </summary>
        [Fact]
        public void GetFundsTest_ValidId()
        {
            // Arrange
            var marketCode = "ANIM";

            var service = new FundsService();

            // Act
            var result = service.GetFund(marketCode);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result.Name);
        }

        /// <summary>
        /// The GetFundsTest_ValidId
        /// </summary>
        [Fact]
        public void GetFundsTest_InvalidId()
        {
            // Arrange
            var marketCode = "";

            var service = new FundsService();

            // Act
            var result = service.GetFund(marketCode);

            // Assert
            Assert.NotNull(result);
            Assert.Null(result.MarketCode);
        }

        /// <summary>
        /// The GetFundsTest_ValidId
        /// </summary>
        [Fact]
        public void GetAllFundsTest_Valid()
        {
            // Arrange

            var service = new FundsService();

            // Act
            var result = service.GetAllFunds();

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        /// <summary>
        /// The GetFundsTest_ValidId
        /// </summary>
        [Fact]
        public void GetManagerFundsTest_ValidManager()
        {
            // Arrange
            var fundDetail = new FundDetails();
            var marketCode = "Isotrack";

            var service = new FundsService();

            // Act
            var result = service.GetManagerFunds(marketCode);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }
    }
}
