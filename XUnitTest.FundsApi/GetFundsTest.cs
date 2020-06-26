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
        /// The GetFundsTest_ValidId_ReturnsTrue.
        /// </summary>
        [Fact]
        public void GetFundsTest_ValidId_ReturnsTrue()
        {
            // Arrange
            var fundDetail = new FundDetails();
            var marketCode = "ANIM";

            var service = new FundsService();

            // Act
            var result = service.GetFund(marketCode);

            // Assert
            Assert.NotNull(result);
            Assert.NotEmpty(result.Name);
        }
    }
}
