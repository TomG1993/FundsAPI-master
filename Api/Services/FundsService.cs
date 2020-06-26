/********************************************************************************************
* FundsService.cs
* Created on: 24/06/2020
* Created by: Tom Gorton
*******************************************************************************************/

namespace Api.Services
{
    using Api.DataFiles;
    using Api.Services.Interfaces;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="FundsService" />.
    /// </summary>
    public class FundsService : IFundsService
    {
        /// <summary>
        /// The GetAllFunds.
        /// </summary>
        /// <returns>The <see cref="List{FundDetails}"/>.</returns>
        public List<FundDetails> GetAllFunds()
        {
            var file = System.IO.File.ReadAllTextAsync("./DataFiles/funds.json").Result;

            var funds = JsonConvert.DeserializeObject<List<FundDetails>>(file);

            return funds;
        }

        /// <summary>
        /// The get funds by id method.
        /// </summary>
        /// <param name="marketCode">The marketCode.</param>
        /// <returns>A single funds record.</returns>
        public FundDetails GetFund(string marketCode)
        {
            var file = System.IO.File.ReadAllTextAsync("./DataFiles/funds.json").Result;

            var funds = JsonConvert.DeserializeObject<List<FundDetails>>(file);

            var detail = new FundDetails();

            if (!string.IsNullOrWhiteSpace(marketCode))
            {
                detail = funds.FirstOrDefault(x => x.MarketCode == marketCode);
            }

            return detail;
        }

        /// <summary>
        /// The GetManagerFunds.
        /// </summary>
        /// <param name="fundManager">The fundManager<see cref="string"/>.</param>
        /// <returns>The <see cref="List{FundDetails}"/>.</returns>
        public List<FundDetails> GetManagerFunds(string fundManager)
        {
            var file = System.IO.File.ReadAllTextAsync("./DataFiles/funds.json").Result;

            var funds = JsonConvert.DeserializeObject<List<FundDetails>>(file);

            var details = new List<FundDetails>();

            if (!string.IsNullOrWhiteSpace(fundManager))
            {
                details = funds.Where(x => x.FundManager == fundManager).ToList();
            }

            return details;
        }
    }
}
