using McDonalds_BuilderPattern.Foods.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds_BuilderPattern
{
    class Program
    {
        enum Drink
        {
            Coke = 0,
            IceTea = 1
        }

        static void Main(string[] args)
        {
            //Welcome to McDonalds
            MealBuilder mealBuilder = new MealBuilder();
            Meal meal= mealBuilder.PrePareRoyalMeal((int)Drink.Coke);
            meal.ShowFoods();
            Console.WriteLine("TOTAL :" + meal.GetCost());
            meal.AddFood(new Coke()); //ekstra Coke
            meal.ShowFoods();
            Console.WriteLine("TOTAL :" +meal.GetCost());

            Console.ReadKey();
            
        }
    }
}
