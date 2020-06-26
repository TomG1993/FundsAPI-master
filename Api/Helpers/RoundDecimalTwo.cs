/********************************************************************************************
* RoundDecimalTwo.cs
* Created on: 26/06/2020
* Created by: Tom Gorton
*******************************************************************************************/

namespace Api.Helpers
{
    using AutoMapper;
    using System;

    /// <summary>
    /// Defines the <see cref="RoundDecimalTwo" />.
    /// </summary>
    public class RoundDecimalTwo : IValueConverter<decimal, decimal>
    {
        /// <summary>
        /// The Convert.
        /// </summary>
        /// <param name="source">The source<see cref="decimal"/>.</param>
        /// <param name="destination">The destination<see cref="decimal"/>.</param>
        /// <param name="context">The context<see cref="ResolutionContext"/>.</param>
        /// <returns>The <see cref="decimal"/>.</returns>
        //public decimal Convert(decimal source, decimal destination, ResolutionContext context)
        //{
        //    destination = Math.Round((decimal)source, 2, MidpointRounding.AwayFromZero);

        //    return destination;
        //}

        public decimal Convert(decimal sourceMember, ResolutionContext context)
        {
            return Math.Round((decimal)sourceMember, 2, MidpointRounding.AwayFromZero);

        }
    }
}
