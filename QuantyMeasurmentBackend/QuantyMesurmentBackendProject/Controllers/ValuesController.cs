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

        [Route("FeetToInch")]
        [HttpPost]
        public IActionResult FeetToInchCoverter(Feet feetValue)
        {
            var inchData = manager.FeetToInchConverter(feetValue);
            if (inchData != null)
            {
                return this.Ok(inchData.GetInchesValue());
            }
            else
            {
                return this.BadRequest();
            }
        }
        [Route("InchToFeet")]
        [HttpPost]
        public IActionResult InchToFeethCoverter(Inches inch)
        {
            var feetValue = manager.InchToFeetConverter(inch);
            if (feetValue != null)
            {
                return this.Ok(feetValue.GetFeetValue());
            }
            return this.BadRequest();
        }
        [Route("YardToFeet")]
        [HttpPost]
        public IActionResult YardToFeetConveter(Yard yard)
        {
            var feetValue = manager.YardToFeetConverter(yard);
            if (feetValue != null)
            {
                return this.Ok(feetValue.GetFeetValue());
            }
            return this.BadRequest();
        }
        [Route("YardtoInch")]
        [HttpPost]
        public ActionResult<double> YardToInchConverter(Yard yard)
        {
            var inchValue = manager.YardToInchConverter(yard);
            if (inchValue != null)
            {
                return this.Ok(inchValue.GetInchesValue());
            }
            return this.BadRequest();
        }
        [Route("KilogramToGram")]
        [HttpPost]
        public ActionResult<double> KilogramToGramConverter(Kilogram kilogram)
        {
            var gramValue = manager.KilogramToGramConverter(kilogram);
            if (gramValue != null)
            {
                return this.Ok(gramValue.GetGramValue());
            }
            return this.BadRequest();
        }
        [Route("GramToKilogram")]
        [HttpPost]
        public ActionResult<double> GramToKilogramConverter(Gram gram)
        {
            var kilogramValue = manager.GramToKilogramConverter(gram);
            if (kilogramValue != null)
            {
                return this.Ok(kilogramValue.GetKilogramValue());
            }
            return this.BadRequest();
        }
        [Route("CelsiusToFahrenheit")]
        [HttpPost]
        public ActionResult<double> CelsiusToFahrenheitConverter(Celcius celsius)
        {
            var fahrenheitValue = manager.CelsiusToFahrenheitConverter(celsius);
            if (fahrenheitValue != null)
            {
                return this.Ok(fahrenheitValue.GetFahranheitValue());
            }
            return this.BadRequest();
        }

        [Route("FahrenheitToCelsius")]
        [HttpPost]
        public ActionResult<double> FahrenheittoCelsiusConverter(Fahranheit fahranheit)
        {
            var celsiusValue = manager.FahrenheitToCelsiusCoverter(fahranheit);
            if (celsiusValue != null)
            {
                return this.Ok(celsiusValue.GetCelciusValue());
            }
            return this.BadRequest();
        }


    }
}
