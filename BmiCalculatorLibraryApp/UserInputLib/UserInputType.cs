using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputLib
{
    public class UserInputType
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
