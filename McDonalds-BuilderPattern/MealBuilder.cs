using McDonalds_BuilderPattern.Foods.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds_BuilderPattern
{
    class MealBuilder
    {
        public Meal PrePareChickenMeal(int drink)
        {
            var meal = new Meal();
            meal.AddFood(new McChicken());

            if(drink == 0)
                meal.AddFood(new Coke());

            if (drink == 1)
                meal.AddFood(new IceTea());

            return meal;
        }

        public Meal PrePareRoyalMeal(int drink)
        {
            var meal = new Meal();
            meal.AddFood(new McRoyal());
            meal.AddFood(new IceTea());
            return meal;
        }
    }
}
