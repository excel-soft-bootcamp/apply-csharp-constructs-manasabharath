using System;
using System.Collections.Generic;
using System.Text;

namespace Bmicalculator
{
    public class HealthDetails
    {
        BmiValidation Bmivalue = new BmiValidation();
        string name;
        int weight;
        int height;

        //constructor to initalize all the variables
        public HealthDetails(string Name, int Weight, int Height)
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

        //create a method that calculates the BMI
        public int BodyMassIndex()
        {
            int BMI = (Weight) / (Height);
            return BMI;
            Bmivalue.ValidateBmi(BMI);


        }


    }
}
