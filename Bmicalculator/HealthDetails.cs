using System;
using System.Collections.Generic;
using System.Text;

namespace Bmicalculator
{
    public class HealthDetails
    {

        public int Height()
        {
            int height = int.Parse(this.ReadFromConsole("Enter your height:"));
            return height;
        }

        public int Weight()
        {
            int weight = int.Parse(this.ReadFromConsole("Enter your weight:"));
            return weight;
        }
        private string ReadFromConsole(string message)
        {

            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
    }

        


    
}
