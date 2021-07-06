using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculatorLib
{
    public class BmiCalculatorType
    {
        private int BMI;
        public int calculator(int height, int weight)
        {
            BMI = weight / height;
            return BMI;
        }
    }
}
