using System;
using System.IO;

namespace Bmicalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            HealthDetails health = new HealthDetails();



            BmiValueCalculator value = new BmiValueCalculator();
            int BmiValue = value.calculator(health.Height(), health.Weight());


            BmiValidator validate = new BmiValidator();
            string message = validate.CheckCondition(BmiValue);

            Display display = new Display();
            display.Displayinformation(message);



        }
    }
}