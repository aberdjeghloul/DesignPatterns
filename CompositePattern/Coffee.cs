using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public abstract class Coffee
    {
        public int Calories { get; set; }
        public List<Coffee> Flavors { get; set; }

        public Coffee(int calories)
        {
            Calories = calories;
            Flavors = new List<Coffee>();
        }

        public void DisplayCalories()
        {
            Console.WriteLine($"{this.GetType().Name}: {this.Calories} calories ");
            foreach (var drink in Flavors)
            {
                drink.DisplayCalories();
            }
        }
    }
}
