// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IManager.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta das"/>
// ----------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Parameter
    {
        private double feet;
        private double inch;
        private double celsius;
        private double fahranheit;
        private double kilogram;
        private double gram;
        private double yard;
        public double Feet
        {
            get
            {
                return this.feet;
            }
            set
            {
                this.feet = value;
            }
        }
        public double Inch
        {
            get
            {
                return this.inch;
            }
            set
            {
                this.inch = value;
            }
        }
        public double Celsius
        {
            get
            {
                return this.celsius;
            }
            set
            {
                this.celsius = value;
            }
        }
        public double Fahranheit
        {
            get
            {
                return this.fahranheit;
            }
            set
            {
                this.fahranheit = value;
            }
        }
        public double Kilogram
        {
            get
            {
                return this.kilogram;
            }
            set
            {
                this.kilogram = value;
            }
        }
        public double Gram
        {
            get
            {
                return this.gram;
            }
            set
            {
                this.gram = value;
            }
        }
        public double Yard
        {
            get
            {
                return this.yard;
            }
            set
            {
                this.yard = value;
            }
        }
    }
}
