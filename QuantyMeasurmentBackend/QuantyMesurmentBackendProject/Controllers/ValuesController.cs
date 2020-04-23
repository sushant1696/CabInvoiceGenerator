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
        public async Task<IActionResult>FeetToInchConverter(double feet)
        {
            var inchData = manager.FeetToInches(feet);
            if (inchData != 0.0)
                return this.Ok(inchData);
            return this.BadRequest();         
        }

        [Route("api/InchToFeet")]
        [HttpPost]
        public async Task<IActionResult> InchToFeetConverter(double inch)
        {
            var feetValue = manager.InchToFeet(inch);
            if (feetValue != 0.0)
                return this.Ok(feetValue);
            return this.BadRequest();
        }
        [Route("api/CelsiusToFahranheit")]
        [HttpPost]
        public async Task<IActionResult> CelsiusToFahranheit(double celsius)
        {
            var fahranheitData = manager.CelsiusToFahranheit(celsius);
            if (fahranheitData != 0.0)
                return this.Ok(fahranheitData);
            return this.BadRequest();
        }
        [Route("api/FahranheitToCelsius")]
        [HttpPost]
        public async Task<IActionResult> FahranheitToCelsiusconverter(double celsius)
        {
            var celsiusData = manager.FahranheitToCelsius(celsius);
            if (celsiusData != 0.0)
                return this.Ok(celsiusData);
            return this.BadRequest();
        }
        [Route("api/KilogramToGramConverter")]
        [HttpPost]
        public async Task<IActionResult> KilogramToGram(double kilogram)
        {
            var gramData = manager.KilogramToGramConverter(kilogram);
            if (gramData != 0.0)
                return this.Ok(gramData);
            return this.BadRequest();
        }
        [Route("api/GramToKilogram")]
        [HttpPost]

        public async Task<ActionResult> GramToKilogram(double celsius)
        {
            var gramData =manager.GramToKilogramConverter(celsius);
            if (gramData != 0.0)
                return this.Ok(gramData);
            return this.BadRequest();
        }
        [Route("api/YardToFeet")]
        [HttpPost]
        public async Task<ActionResult> YardToFeet(double yard)
        {
            var feetData =manager.YardToFeetConverter(yard);
            if (feetData != 0.0)
                return this.Ok(feetData);
            return this.BadRequest();
        } 
        [Route("api/YardToInch")]
        [HttpPost]
        public async Task<IActionResult> YardToInch(double yard)
        {
            var inchesData = manager.YardToInchConverter(yard);
            if (inchesData != 0.0)
                return this.Ok(inchesData);
            return this.BadRequest();
        }

    }
}
