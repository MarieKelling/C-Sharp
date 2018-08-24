using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipotleCalorieCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Declared Variables that will never have their values changed (known values): 
            //
            const int caloriesTortilla = 300;
            const int caloriesCarnitas = 220;
            const int caloriesTacoShells = 210;
            const int caloriesRice = 200;
            const int caloriesSteak = 190;
            const int caloriesChicken = 180;
            const int caloriesBarbacoa = 170;
            const int caloriesGuacamole = 170;
            const int caloriesSourCream = 120;
            const int caloriesBeans = 120;
            const int caloriesCheese = 100;
            const int caloriesCornSalsa = 80;
            const int caloriesFajita = 20;
            const int caloriesOtherSalsa = 20;

            //
            //Declared Varibales that will be defined by the user (unknown values): 
            //
            string name;
            string mealType = "";
            string meatType = "";
                /*int numTortilla;
                int numTacoShells;*/
            int numRice;
            int numMeat;
            int totalMeatCalories;
                /*int numChicken;
                int numSteak;
                int numBarbacoa;
                int numCarnitas;*/
            int numGuacamole;
            int numSourCream;
            int numBeans;
            int numCheese;
            int numCornSalsa;
            int numFajita;
            int numOtherSalsa;

            //
            //User Interface Implementation: 
            //
            Console.Write("What is the name for the order? ");
            name = Console.ReadLine();

            //MEAL TYPE: 
            Console.WriteLine("A : Burrito");
            Console.WriteLine("B : Bowl");
            Console.WriteLine("C : Crispy Taco");
            Console.WriteLine("D : Soft Totilla");
            Console.Write("Please select your meal choice: ");

            char userChosenMeal = char.Parse(Console.ReadLine());    //Assumes only one order of selected meal type

            if (userChosenMeal == 'A' || userChosenMeal == 'a')  {
                mealType = "Burrito";
            }
            else if (userChosenMeal == 'B' || userChosenMeal == 'b')  {
                mealType = "Bowl";
            }
            else if (userChosenMeal == 'C' || userChosenMeal == 'c')  {
                mealType = "Crispy Taco";
            }
            else if (userChosenMeal == 'D' || userChosenMeal == 'd')  {
                mealType = "Soft Tortilla";
            }

            //RICE: 
            Console.Write("How many orders of rice would you like? ");
            numRice = int.Parse(Console.ReadLine()); 

            //MEAT: 
            Console.Write("How many orders of meat would you like? ");
            numMeat = int.Parse(Console.ReadLine()); 
            Console.WriteLine("A : Chicken");
            Console.WriteLine("B : Steak");
            Console.WriteLine("C : Carnitas");
            Console.WriteLine("D : Barbacoa");
            Console.Write("Please select your choice of meat: ");

            char userChosenMeat = char.Parse(Console.ReadLine());

            if(userChosenMeat == 'A' || userChosenMeat == 'a')  {
                meatType = "Chicken";
                totalMeatCalories = numMeat * caloriesChicken; 
            }
            else if (userChosenMeat == 'B' || userChosenMeat == 'b')  {
                meatType = "Steak";
                totalMeatCalories = numMeat * caloriesSteak;
            }
            else if (userChosenMeat == 'C' || userChosenMeat == 'c')  {
                meatType = "Carnitas";
                totalMeatCalories = numMeat * caloriesBarbacoa;
            }
            else if (userChosenMeat == 'D' || userChosenMeat == 'd')  {
                meatType = "Barbacoa";
                totalMeatCalories = numMeat * caloriesCarnitas; 
            }

            //EXTRAS / TOPPINGS: 



            Console.WriteLine("Hello, " + name + ", your meal selection is " + mealType + ".");
            Console.WriteLine("You selected " + numMeat + " order(s) of " + meatType + ".");
            Console.WriteLine("You selected " + numRice + " order(s) of Rice."); 

            Console.WriteLine("Please press any key to continue.. ");
            Console.ReadKey();

            //switch (selectionMeal)
            //{
            //    case 'A':
            //        mealType = "Burrito";
            //        break;
            //    case 'B':
            //        mealType = "Bowl";
            //        break;
            //    case 'C':
            //        mealType = "Crispy Taco";
            //        break;
            //    case 'D':
            //        mealType = "Soft Tortilla";
            //        break;
            //}

            //switch (selectionMeat)
            //{
            //    case 1:
            //         2: 
            //        mealType = "Chicken";
            //        totalMeatCalories = numMeat * caloriesChicken; 
            //        break;
            //    case 'B':
            //        mealType = "Steak";
            //        totalMeatCalories = numMeat * caloriesSteak;
            //        break;
            //    case 'C':
            //        mealType = "Carnitas";
            //        totalMeatCalories = numMeat * caloriesBarbacoa;
            //        break;
            //    case 'D':
            //        mealType = "Barbacoa";
            //        totalMeatCalories = numMeat * caloriesCarnitas; 
            //        break;
            //}
        }
    }
}
