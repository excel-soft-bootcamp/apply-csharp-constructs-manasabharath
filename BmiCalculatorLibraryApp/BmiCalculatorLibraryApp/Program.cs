using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculatorLibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInputLib.UserInputType _userInputType = new UserInputLib.UserInputType();
            int height = _userInputType.Height();
            int weight = _userInputType.Weight();

            BmiCalculatorLib.BmiCalculatorType _BmiCalculatorType = new BmiCalculatorLib.BmiCalculatorType();
            int BmiValue = _BmiCalculatorType.calculator(height, weight);


            BmiVaildationLib.BmiValidationType _BmiValidationType = new BmiVaildationLib.BmiValidationType();
            string message = _BmiValidationType.CheckCondition(BmiValue);

            BmiDisplayLib.BmiDisplayType _BmiDisplayType = new BmiDisplayLib.BmiDisplayType();
            _BmiDisplayType.Display(message);
        }
    }
}
