using System.Collections.Generic;

namespace ShoppingList.Models
{
    public class Meal
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Meal(string name, List<Ingredient> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }
    }
}
