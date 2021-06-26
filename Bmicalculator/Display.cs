using System;
using System.Collections.Generic;
using System.Text;

namespace Bmicalculator
{
    class Display
    {
        public void DisplayWeight()
        {
            Console.WriteLine("Weight in kgs: {0}", Weight);
        }
        //method to display the Name
        public void DisplayName()
        {
            Console.WriteLine("Name: {0}", Name);
        }

        //method to display the Height
        public void DisplayHeight()
        {
            Console.WriteLine("Height in meters: {0}", Height);
        }

        public void DisplayBodyMassIndex()
        {
            Console.WriteLine("Body Mass Index: {0}", BodyMassIndex());
        }

    }
}
