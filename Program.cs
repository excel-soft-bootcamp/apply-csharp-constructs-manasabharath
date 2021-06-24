using System;

namespace Bmicalculator
{
    public class BodyTest
    {
        string name;
        int weight;
        int height;

        public BodyTest(string Name, int Weight, int Height)
        {
            this.weight = Weight;
            this.height = Height;

        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
      
        public void DisplayName()
        {
            Console.WriteLine("Name: {0}", Name);
        }


        
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                this.weight = value;
            }
        }
        public void DisplayWeight()
        {
            Console.WriteLine("Weight in kgs: {0}", Weight);
        }

        
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                this.height = value;
            }
        }
        public void DisplayHeight()
        {
            Console.WriteLine("Height in meters: {0}", Height);
        }


        public float BodyMassIndex()
        {
            float BMI = (Weight) / (Height * Height);
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
        


        class Test
        {
            public static void Main(string[] args)
            {
                BodyTest bt1 = new BodyTest(null, 0, 0);

                Console.Write("Enter Name: ");
                bt1.Name = Convert.ToString(Console.ReadLine());
                Console.Write("Enter Weight in kgs: ");
                bt1.Weight = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Height in meters: ");
                bt1.Height = Convert.ToInt32(Console.ReadLine());




                bt1.DisplayName();
                bt1.DisplayWeight();
                bt1.DisplayHeight();
                bt1.DisplayBodyMassIndex();
                bt1.DisplayBMIOutput();
 
            }
        }
    }
}