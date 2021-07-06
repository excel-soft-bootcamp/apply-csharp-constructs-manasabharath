using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiVaildationLib
{
    public class BmiValidationType
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
