using System;
using System.Collections.Generic;
using System.Text;

namespace Bmicalculator
{
    public class BmiValueCalculator
    {
        //create a method that calculates the BMI
        private int BMI;

        public int calculator(int height, int weight)
        {
            BMI = weight / height;
            return BMI;
        }
    }
}
