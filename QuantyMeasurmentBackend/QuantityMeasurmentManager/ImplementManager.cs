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

        public double CelsiusToFahranheit(double celsius)
        {
            return repository.CelsiusToFahranheit(celsius);
        }

        public double FahranheitToCelsius(double fahranheit)
        {
            return repository.FahranheitToCelsius(fahranheit);
        }

        public double FeetToInches(double feet)
        {
            return repository.FeetToInches(feet) ;
        }

        public double GramToKilogramConverter(double gram)
        {
            return repository.GramToKilogramConverter(gram);
        }

        public double InchToFeet(double inch)
        {
            return repository.InchToFeet(inch);
        }

        public double KilogramToGramConverter(double kilogram)
        {
            return repository.KilogramToGramConverter(kilogram);
        }

        public double YardToFeetConverter(double yard)
        {
            return repository.YardToFeetConverter(yard);
        }

        public double YardToInchConverter(double yard)
        {
            return repository.YardToInchConverter(yard);
        }
    }
}
