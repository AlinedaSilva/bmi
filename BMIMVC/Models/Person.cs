using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BMIMVC.Models
{
	public enum Category { Underweight, Normal, Overweight, Obese};
    public class Person
    {
	const double UnderWeightLimite = 18.4;
	const double NormalWeightLimite = 24.9;
	const double OverWeightLimite = 29.9;	

	const double PoundsToKilos = 2.2046;
	const double InchesToMetres = 0.0254;
       
	    [Required(ErrorMessage = "Required field!")]
        [DisplayName("Weight - Stones")]
        public int Weight { get; set; }

        [Required(ErrorMessage = "Required field!")]
        [DisplayName("Height - Feet")]
        public int Height { get; set; }

        public void CalculateCategory()
        {
            double bmi = 0;
            bmi = Weight / (Weight / 100) * (Height / 100);

            if (bmi <= 18.4)
            {
                Console.WriteLine(" Underweigth");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("Normal");
            }
            if (bmi >= 25 && bmi <= 24.9)
            {
                Console.WriteLine("Overweight");
            }
            if (bmi > 30)
            {
                Console.WriteLine("Obese");
            }
        }

        public double CalculateBMI
        {
            get
            {
                double totalWeightInKgs = PoundsToKilos * Weight;
                double totalHeightInMeters = InchesToMetres * Height;
                double bmi = totalWeightInKgs / (Math.Pow(totalHeightInMeters,2));
                return bmi;
            }
        }
    }
}