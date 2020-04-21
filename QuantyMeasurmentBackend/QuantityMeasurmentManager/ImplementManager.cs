using Model;
using QuantityMeasurmentRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurmentManager
{
    public class ImplementManager : IManager
    {
        private readonly IRepository repository;

        public ImplementManager(IRepository repository)
        {
            this.repository = repository;
        }

        public Fahranheit CelsiusToFahrenheitConverter(Celcius celsius)
        {
            var FahrenheitData = repository.CelsiusToFahrenheitConverter(celsius);
                return FahrenheitData;
        }

        public Celcius FahrenheitToCelsiusCoverter(Fahranheit fahranheit)
        {
            var celsiusData =repository.FahrenheitToCelsiusCoverter(fahranheit);
            return celsiusData;
        }

        public Inches FeetToInchConverter(Feet feet)
        {
            var InchData = repository.FeetToInchConverter(feet);
            return InchData;
        }

        public Kilogram GramToKilogramConverter(Gram gram)
        {
            var kilogramData = repository.GramToKilogramConverter(gram);
            return kilogramData;
        }

        public Feet InchToFeetConverter(Inches inch)
        {
            var inchValue = repository.InchToFeetConverter(inch);
            return inchValue;
        }

        public Gram KilogramToGramConverter(Kilogram kilogram)
        {
            var gramdata = repository.KilogramToGramConverter(kilogram);
            return gramdata;
        }

        public Feet YardToFeetConverter(Yard yard)
        {
            var feetdata = repository.YardToFeetConverter(yard);
            return feetdata;
        }

        public Inches YardToInchConverter(Yard yard)
        {
            var inchdata = repository.YardToInchConverter(yard);
            return inchdata;
        }
    }
}
