using System;

namespace Bmicalculator
{
    public class HealthProfile
    {
        string name;
        int weight;
        int height;

        //constructor to initalize all the variables
        public HealthProfile(string Name, int Weight, int Height)
        {
            this.weight = Weight;
            this.height = Height;

        }
        //set and get name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //set and get weight 
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //set and get height
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        //method to display the Weight
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


        //create a method that calculates the BMI
        public float BodyMassIndex()
        {
            float BMI = (Weight) / (Height);
            return BMI;
        }
        public void DisplayBodyMassIndex()
        {
            Console.WriteLine("Body Mass Index: {0}", BodyMassIndex());
        }
        public void DisplayBMIOutput()
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

        public void DisplayBMIChart()
        {
            Console.Write("\n\n\nBMI Values\n\nUnderweight: less than 18.5\nNormal: between 18.5 and 24.9\nOverweight: between 25 and 29.9\nObese: 30 or greater\n");
        }


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

                HealthProfile hp1 = new HealthProfile(Name,Weight,Height);




                hp1.DisplayName();
                hp1.DisplayWeight();
                hp1.DisplayHeight();
                hp1.DisplayBodyMassIndex();
                hp1.DisplayBMIOutput();
                hp1.DisplayBMIChart();

            }
        }
    }
}