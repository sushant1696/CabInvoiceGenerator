// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValueController.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using QuantityMeasurmentManager;

namespace QuantyMesurmentBackendProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IManager manager;

        public ValuesController(IManager manager)
        {
            this.manager = manager;
        }

        [Route("api/FeetToInches")]
        [HttpPost]
        public async Task<IActionResult> FeetToInchConverter(double feet)
        {
            var inchData = manager.FeetToInches(feet);
            if (inchData != 0.0)
                return this.Ok(inchData);
            return this.BadRequest();         
        }
       


    }
}
