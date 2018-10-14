using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McDonalds_BuilderPattern.Interfaces;

namespace McDonalds_BuilderPattern
{
    class Meal
    {
        private List<IFood> foodList= new List<IFood>();

        public void AddFood(IFood food)
        {
            foodList.Add(food);
        }

        public float GetCost()
        {
            float cost = 0;
            foreach(var f in foodList)
            {
                cost = cost + f.Price();
            }

            return cost;
        }

        public void ShowFoods()
        {
            foreach(var food in foodList)
            {
               Console.WriteLine("Food : " + food.Name());
               Console.WriteLine("Packing : " + food.Packing().Pack());
               Console.WriteLine("Price : " + food.Price());
            }
        }
    }
}
