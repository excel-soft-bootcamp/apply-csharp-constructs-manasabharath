using System;

namespace Bmicalculator
{

    //create the program to test out the class
    class HealthProfileTest
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter Name:");
            string Name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Weight in kgs:");
            int Weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Height in meters:");
            int Height = Convert.ToInt32(Console.ReadLine());

            HealthDetails hp1 = new HealthDetails(Name, Weight, Height);
            




            hp1.DisplayName();
            hp1.DisplayWeight();
            hp1.DisplayHeight();
            hp1.DisplayBodyMassIndex();
            hp1.BmiValidation();
           

        }
    }
}