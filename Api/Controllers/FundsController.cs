namespace Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using System.IO;
    using Api.DataFiles;
    using Api.Services;
    using Api.Services.Interfaces;
    using AutoMapper;
    using Api.Models.Response;

    public class FundsController : Controller
    {
        private readonly IFundsService _fundsService;

        private readonly IMapper _mapper;

        /// <summary>
        /// The controller constructor
        /// </summary>
        /// <param name="_fundsService"></param>
        public FundsController(IFundsService fundsService, IMapper mapper)
        {
            _fundsService = fundsService;
            _mapper = mapper;
        }

        [Route("get-funds")]
        public IActionResult GetFunds(string marketCode)
        {
            var funds = this._fundsService.GetFund(marketCode);

            var response = _mapper.Map<FundDataResponse>(funds);
            
            return this.Ok(response);
        }

        [Route("get-all")]
        public IActionResult GetAllFunds()
        {
            var allFunds = this._fundsService.GetAllFunds();

            var response = _mapper.Map<List<FundDataResponse>>(allFunds);

            return this.Ok(response); 
        }

        [Route("get-managerfunds")]
        public IActionResult GetManagerFunds(string manager)
        {
            var managerFunds = this._fundsService.GetManagerFunds(manager);

            var response = _mapper.Map<List<FundDataResponse>>(managerFunds);

            return this.Ok(response);
        }

    }
}