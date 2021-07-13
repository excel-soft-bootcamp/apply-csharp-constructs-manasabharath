using System;
using System.Collections.Generic;
using System.Text;

namespace Bmicalculator
{
    public class BmiValidator   
    {
        public string CheckCondition(int BMI)
        {
            if (BMI < 18.5)
            {
                return "UnderWeight";
            }
            else if (BMI >= 25)
            {
                return "OverWeight";
            }
            else
            {
                return "Normal";
            }
        }

    }
    


}