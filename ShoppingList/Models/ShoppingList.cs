using ShoppingList.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList.Models
{
    public class ShoppingList
    {
        public string ListName { get; }
        public List<string> ListContent { get; set; }

        public List<string> NotFoundIngredients { get; set; }

        private List<Ingredient> totalIngredients;

        public ShoppingList(DietCalendar dietCalendar, int[] daysNumber)
        {
            ListName = "Shopping List";
            ListContent = new List<string>();
            totalIngredients = new List<Ingredient>();
            NotFoundIngredients = dietCalendar.NotFoundIngredients;

            foreach (var day in daysNumber)
            {
                if (dietCalendar.MealsPerDay.TryGetValue(day, out List<Meal> meals))
                {
                    meals.ForEach(x => totalIngredients.AddRange(new List<Ingredient>(x.Ingredients)));
                }
            }

            var ingredientAmount = totalIngredients.GroupBy(x => x.Name)
                            .Select(x => new
                            {
                                name = x.Key,
                                unit = x.First().Unit.GetStringValue(),
                                amount = x.Sum(y => y.Quantity),
                            }).ToList();

            foreach (var ingredient in ingredientAmount)
            {
                string nameToDisplay = ((Enums.Ingredient)Enum.Parse(typeof(Enums.Ingredient), ingredient.name)).GetStringValue();
                string amountToDisplay = ingredient.amount > 0 ? ingredient.amount.ToString() : "libre";
                string unitToDisplay = amountToDisplay == "libre" ? "" : ingredient.unit;

                ListContent.Add($"{nameToDisplay} {amountToDisplay} {unitToDisplay}");
            }

            ListContent.Sort();
        }
    }
}
