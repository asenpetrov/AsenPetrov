using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const double White = 1.5;
        private const double Wholegrain = 1;
        private const double Crispy = 0.9;
        private const double Chewy = 1.1;
        private const double Homemade = 1;

        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechniques, double weight)
        {
            this.FlourType = flourType.ToLower();
            this.BakingTechnique = bakingTechniques.ToLower();
            this.Weight = weight;
        }
        public string FlourType
        {
            get
            {
                return flourType;
            }
            set
            {
                string newValue = value.ToLower();
                if (newValue == "white" || newValue == "wholegrain")
                {
                    flourType = newValue;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                
            }
        }
        public string BakingTechnique
        {
            get
            {
                return bakingTechnique;
            }
            set
            {
                
                if (value == "crispy" || value == "chewy" || value == "homemade")
                {
                    bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid baking technique");
                }
                
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public double CalculateCalories()
        {
            double rawCalories = weight * 2;
            if (this.FlourType == "white")
            {
                rawCalories *= White;
                if (this.BakingTechnique == "crispy")
                {
                    rawCalories *= Crispy;
                }
                else if (this.BakingTechnique == "chewy")
                {
                    rawCalories *= Chewy;
                }
                else if (this.BakingTechnique == "homemade")
                {
                    rawCalories *= Homemade;

                }
            }
            if (this.FlourType == "wholegrain")
            {
                rawCalories *= Wholegrain;
                if (this.BakingTechnique == "crispy")
                {
                    rawCalories *= Crispy;
                }
                else if (this.BakingTechnique == "chewy")
                {
                    rawCalories *= Chewy;
                }
                else if (this.BakingTechnique == "homemade")
                {
                    rawCalories *= Homemade;

                }
            }
            rawCalories = Math.Round(rawCalories, 2);

            return rawCalories;
        }
    }
}
