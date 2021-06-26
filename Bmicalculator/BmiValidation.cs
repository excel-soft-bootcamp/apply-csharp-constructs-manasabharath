using System;
using System.Collections.Generic;
using System.Text;

namespace Bmicalculator
{
    class BmiValidation
    {
        private int BodyMassIndex;
        public void ValidateBmi(int BodyMassIndex)
        {

            if (BodyMassIndex() < 18.5)
            {
                Console.Write("\nYou are Underweight.\n");
            }
            else if (BodyMassIndex() < 25)
            {
                Console.Write("\nYou are healthy.\n");
            }
            else if (BodyMassIndex() < 30)
            {
                Console.Write("\nYou are Overweight\n");
            }
            else Console.Write("\nYou are Obese.\n");
        }

    }
}

