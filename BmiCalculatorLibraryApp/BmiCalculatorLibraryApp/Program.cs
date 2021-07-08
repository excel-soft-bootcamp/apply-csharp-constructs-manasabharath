using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace BmiCalculatorLibraryApp
{
    public enum Options
    {
        CONSOLE = 1, FILEINPUT
    }
    class Program
    {
        static void Main(string[] args)
        {
            string displayMessage = $"Enter Your Choice {(int)Options.CONSOLE}->Console,{(int)Options.FILEINPUT}->Fileinput";
            Console.WriteLine(displayMessage);
            Options _choice = (Options)Int32.Parse(Console.ReadLine());
            switch (_choice)
            {
                case Options.CONSOLE:
                    UserInputLib.UserInputType _userInputType = new UserInputLib.UserInputType();
                    int height = _userInputType.Height();
                    int weight = _userInputType.Weight();

                    BmiCalculatorLib.BmiCalculatorType _BmiCalculatorType = new BmiCalculatorLib.BmiCalculatorType();
                    int BmiValue = _BmiCalculatorType.calculator(height, weight);


                    BmiVaildationLib.BmiValidationType _BmiValidationType = new BmiVaildationLib.BmiValidationType();
                    string message = _BmiValidationType.CheckCondition(BmiValue);

                    BmiDisplayLib.BmiDisplayType _BmiDisplayType = new BmiDisplayLib.BmiDisplayType();
                    _BmiDisplayType.Display(message);
                    break;

                case Options.FILEINPUT:
                   
                    try
                    {
                        using (StreamReader sr = new StreamReader(@"C:\Users\manasa.v\source\repos\sample.csv.txt"))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(e.Message);
                    }
                    Console.ReadKey();
                    break;
            }
        }
    }
}

