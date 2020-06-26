using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ShoppingList.Models.ViewModels
{
    public class FoodCalculatorViewModel
    {
        private static readonly List<Tuple<List<Ingredient>, SelectListGroup>> categories = new List<Tuple<List<Ingredient>, SelectListGroup>>
        {
            Tuple.Create(EquivalenceList.Fruits, new SelectListGroup { Name = "Frutas"} ),
            Tuple.Create(EquivalenceList.Vegetables, new SelectListGroup { Name = "Verduras"} ),
            Tuple.Create(EquivalenceList.Legumes, new SelectListGroup { Name = "Legumbres"} ),
            Tuple.Create(EquivalenceList.LowFatCereals, new SelectListGroup { Name = "Cereales sin grasa"} ),
            Tuple.Create(EquivalenceList.HighFatCereals, new SelectListGroup { Name = "Cereales con grasa"} ),
            Tuple.Create(EquivalenceList.AnimalOriginFood, new SelectListGroup { Name = "Alimentos de origen animal"} ),
            Tuple.Create(EquivalenceList.DairyProducts, new SelectListGroup { Name = "Lacteos"} ),
            Tuple.Create(EquivalenceList.DairySubstitutes, new SelectListGroup { Name = "Sustitutos de lacteos"} ),
            Tuple.Create(EquivalenceList.LowProteinOils, new SelectListGroup { Name = "Aceites sin proteina"} ),
            Tuple.Create(EquivalenceList.ProteinOils, new SelectListGroup { Name = "Aceites con proteina"} ),
            Tuple.Create(EquivalenceList.LowFatSugars,new SelectListGroup { Name = "Azucares sin grasa"} ),
            Tuple.Create(EquivalenceList.FatSugars, new SelectListGroup { Name = "Azucares con grasa"} ),
            Tuple.Create(EquivalenceList.SuperFood, new SelectListGroup { Name = "Super Food"} )
        };

        private static List<SelectListItem> GetItemsWithGroups() 
        {
            var selectList = new List<SelectListItem>();

            foreach (var category in categories)
            {
                foreach (var food in category.Item1)
                {
                    selectList.Add(new SelectListItem { Value = food.Name, Text = $"{food.Name} ({food.Unit})", Group = category.Item2 });
                }
            }

            return selectList;
        }

        [DisplayName("Food")]
        public string FoodName { get; set; }
        [DisplayName("Quantity")]
        public decimal Quantity { get; set; }
        [DisplayName("Categories")]
        public List<SelectListItem> Categories { get; } = GetItemsWithGroups();
    }
}
