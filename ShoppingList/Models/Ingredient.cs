namespace ShoppingList.Models
{
    public class Ingredient
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public Enums.Unit Unit { get; set; }

        public Ingredient(string name, decimal quantity = 0, Enums.Unit unit = Enums.Unit.pieza)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
    }
}
