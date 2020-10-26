using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class Odometer
    {
        private double milesDriven;
        private double gallonsFuelUsed;

        // COnstructors
        public Odometer()
        {

        }

        public Odometer(double m, double g)
        {
            SetMilesDriven(m);
            SetGallonsFuelUsed(g);
        }

        
        // Setters
        public void SetMilesDriven(double m)
        {
            milesDriven = m;
        }

        public void SetGallonsFuelUsed(double g)
        {
            gallonsFuelUsed = g;
        }

        
        //Getters
        public double GetMilesDriven()
        {
            return milesDriven;
        }
        public double GetGallonsFuelUsed()
        {
            return gallonsFuelUsed;
        }

        public void ResetOdometer()
        {
            SetGallonsFuelUsed(0);
            SetMilesDriven(0);
        }

        public void Add(double m, double g)
        {
            SetMilesDriven(GetMilesDriven() + m);
            SetGallonsFuelUsed(GetGallonsFuelUsed() + g);
        }

        public double MPG()
        {
            return (GetMilesDriven() / GetGallonsFuelUsed());
        }

        public override string ToString()
        {
            return "Miles driven: " + GetMilesDriven() + "   Gallons of fuel used: " + GetGallonsFuelUsed();
        }


    }
}
