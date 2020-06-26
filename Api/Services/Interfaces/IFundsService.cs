/********************************************************************************************
* IFundsService.cs
* Created on: 24/06/2020
* Created by: Tom Gorton
*******************************************************************************************/

namespace Api.Services.Interfaces
{
    using Api.DataFiles;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IFundsService" />.
    /// </summary>
    public interface IFundsService
    {
        /// <summary>
        /// The GetFund.
        /// </summary>
        /// <param name="marketCode">The marketCode<see cref="string"/>.</param>
        /// <returns>The <see cref="FundDetails"/>.</returns>
        FundDetails GetFund(string marketCode);

        /// <summary>
        /// The GetAllFunds.
        /// </summary>
        /// <returns>The <see cref="List{FundDetails}"/>.</returns>
        List<FundDetails> GetAllFunds();

        /// <summary>
        /// The GetManagerFunds.
        /// </summary>
        /// <param name="fundManager">The fundManager<see cref="string"/>.</param>
        /// <returns>The <see cref="List{FundDetails}"/>.</returns>
        List<FundDetails> GetManagerFunds(string fundManager);
    }
}
