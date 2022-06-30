using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

			//declaired variables
			int weight;
			int height;
			int bmi;


			Console.WriteLine("Please Enter your height in inches: "); //Asks user for their height 
			height = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter your weight in pounds: "); //Asks user for their weight 
			weight = Convert.ToInt32(Console.ReadLine());


            bmi = (((int)(weight / Math.Pow(height, 2) * 703))); //BMI formula in C# 
			

			if (bmi >= 18 && bmi <= 30)
            {
				Console.WriteLine("\nYour BMI is {0}.", bmi);   //Prints bmi
			}

            else
            {
				Console.WriteLine("Consult Your Doctor!");
            }
            
            Console.WriteLine("\nIf your BMI is less than 18.5, it falls within the underweight range.");
			Console.WriteLine("\nIf your BMI is 18.5 to < 25, it falls within the healthy weight range.");
            Console.WriteLine("\nIf your BMI is 25.0 to < 30, it falls within the overweight range.");
			Console.WriteLine("\nIf your BMI is 30.0 or higher, it falls within the obesity range.");
		}

	}
}



/*
  


  CDC Guide to BMI Levels
  https://www.cdc.gov/obesity/basics/adult-defining.html#:~:text=If%20your%20BMI%20is%20less,falls%20within%20the%20obesity%20range. 

  Formula to Calculate bmi
  https://www.cdc.gov/nccdphp/dnpao/growthcharts/training/bmiage/page5_2.html
 
  
*/