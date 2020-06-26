/********************************************************************************************
* FundDataResponse.cs
* Created on: 26/06/2020
* Created by: Tom Gorton
*******************************************************************************************/

namespace Api.Models.Response
{
    /// <summary>
    /// Defines the <see cref="FundDataResponse" />.
    /// </summary>
    public class FundDataResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether Active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the CurrentUnitPrice.
        /// </summary>
        public decimal CurrentUnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the FundManager.
        /// </summary>
        public string FundManager { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the MarketCode.
        /// </summary>
        public string Code { get; set; }
    }
}
