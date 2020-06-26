using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingList.Models
{
    public class FoodCalculator
    {
        public string FoodName { get; set; }

        public decimal Quantity { get; set; }

        public FoodCalculator(string foodName, decimal quantity)
        {
            FoodName = foodName;
            Quantity = quantity;
        }

        public List<string> GetEquivalentTable() 
        {
            var resultsTable = new List<string>();
            var equivalenceList = GetEquivalenceList();

            if (equivalenceList.Exists(x => x.Name == FoodName.ToLower())) 
            {
                var ingredientPortion = equivalenceList.First(x => x.Name == FoodName.ToLower()).Quantity;
                var portionFactor = Quantity / ingredientPortion;

                foreach (var ingredient in equivalenceList)
                {
                    resultsTable.Add($"{ingredient.Name} {(ingredient.Quantity * portionFactor).ToString("0.##")} {ingredient.Unit}");
                }
            }

            return resultsTable;
        }

        private List<Ingredient> GetEquivalenceList() 
        {
            var categories = new List<List<Ingredient>> 
            {
                EquivalenceList.Fruits,
                EquivalenceList.Vegetables,
                EquivalenceList.Legumes,
                EquivalenceList.LowFatCereals,
                EquivalenceList.HighFatCereals,
                EquivalenceList.AnimalOriginFood,
                EquivalenceList.DairyProducts,
                EquivalenceList.DairySubstitutes,
                EquivalenceList.LowProteinOils,
                EquivalenceList.ProteinOils,
                EquivalenceList.LowFatSugars,
                EquivalenceList.FatSugars,
                EquivalenceList.SuperFood,
            };

            foreach (var category in categories)
            {
                if (category.Exists(x => x.Name == FoodName.ToLower()))
                {
                    return category;
                }
            }

            return new List<Ingredient>();
        }
    }
}
