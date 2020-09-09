using System.Collections.Generic;

namespace ShoppingList.Models
{
    public static class EquivalenceList
    {
        public static List<Ingredient> Fruits = new List<Ingredient>
        {
            new Ingredient("arandano fresco", 1.5m, Enums.Unit.taza),
            new Ingredient("arandano fresco", 20, Enums.Unit.gr),
            new Ingredient("ciruela", 0.5m),
            new Ingredient("durazno amarillo", 2),
            new Ingredient("fresa rebanada", 1, Enums.Unit.taza),
            new Ingredient("guayaba", 3),
            new Ingredient("kiwi", 1.5m),
            new Ingredient("mandarina", 2),
            new Ingredient("mango picado", 1, Enums.Unit.taza),
            new Ingredient("manzana roja", 1, Enums.Unit.taza),
            new Ingredient("manzana verde", 0.5m, Enums.Unit.taza),
            new Ingredient("melon picado", 1, Enums.Unit.taza),
            new Ingredient("moras", 0.75m, Enums.Unit.taza),
            new Ingredient("naranja", 2),
            new Ingredient("papaya", 1, Enums.Unit.taza),
            new Ingredient("pasas", 10),
            new Ingredient("pasas", 20, Enums.Unit.gr),
            new Ingredient("pera", 0.5m),
            new Ingredient("piña rebanada", 0.75m, Enums.Unit.taza),
            new Ingredient("platano", 0.5m),
            new Ingredient("sandia picada", 1, Enums.Unit.taza),
            new Ingredient("toronja", 1),
            new Ingredient("uvas", 18)
        };

        public static List<Ingredient> Vegetables = new List<Ingredient>
        {
            new Ingredient("acelga cruda", 2, Enums.Unit.taza),
            new Ingredient("acelga picada cocida", 0.5m, Enums.Unit.taza),
            new Ingredient("apio crudo", 1.5m, Enums.Unit.taza),
            new Ingredient("brocoli cocido", 0.5m, Enums.Unit.taza),
            new Ingredient("brocoli crudo", 1, Enums.Unit.taza),
            new Ingredient("calabacita alargada cruda", 1, Enums.Unit.taza),
            new Ingredient("cebolla blanca rebanada", 0.5m, Enums.Unit.taza),
            new Ingredient("champiñon cocido entero", 0.5m, Enums.Unit.taza),
            new Ingredient("champiñon crudo entero", 1, Enums.Unit.taza),
            new Ingredient("chile jalapeño", 6),
            new Ingredient("chile verde", 1),
            new Ingredient("col cocida picada (repollo)", 0.5m, Enums.Unit.taza),
            new Ingredient("col cruda picada", 2, Enums.Unit.taza),
            new Ingredient("col morada cruda picada", 1, Enums.Unit.taza),
            new Ingredient("ejotes", 0.5m, Enums.Unit.taza),
            new Ingredient("esparragos", 0.5m, Enums.Unit.taza),
            new Ingredient("espinaca cocida", 0.5m, Enums.Unit.taza),
            new Ingredient("espinaca cruda", 2, Enums.Unit.taza),
            new Ingredient("jitomate bola", 1),
            new Ingredient("lechuga", 3, Enums.Unit.taza),
            new Ingredient("nopal cocido", 1, Enums.Unit.taza),
            new Ingredient("pepino con cascara rebanado", 1, Enums.Unit.taza),
            new Ingredient("pimiento amarillo crudo chico", 1),
            new Ingredient("pimiento rojo crudo chico", 1),
            new Ingredient("pimiento verde crudo chico", 1),
            new Ingredient("rabano", 1, Enums.Unit.taza),
            new Ingredient("zanahoria picada cruda", 0.5m, Enums.Unit.taza)
        };

        public static List<Ingredient> Legumes = new List<Ingredient>
        {
            new Ingredient("chicharos", 100, Enums.Unit.gr),
            new Ingredient("frijol entero", .5m, Enums.Unit.taza),
            new Ingredient("frijol molido", .33m, Enums.Unit.taza),
            new Ingredient("garbanzo cocido", .5m, Enums.Unit.taza),
            new Ingredient("hummus", 5, Enums.Unit.cucharada),
            new Ingredient("lentejas cocida", .5m, Enums.Unit.taza)
        };

        public static List<Ingredient> LowFatCereals = new List<Ingredient> 
        {
            new Ingredient("amaranto tostado", .25m, Enums.Unit.taza),
            new Ingredient("arroz cocido", .25m, Enums.Unit.taza),
            new Ingredient("arroz crudo*", .08m, Enums.Unit.taza),
            new Ingredient("avena cocida", .75m, Enums.Unit.taza),
            new Ingredient("avena cruda", .33m, Enums.Unit.taza),
            new Ingredient("camote cocido", .33m, Enums.Unit.taza),
            new Ingredient("cebada", 20, Enums.Unit.gr),
            new Ingredient("cheerios", 25, Enums.Unit.gr),
            new Ingredient("galletas habaneras", 4),
            new Ingredient("galletas maria", 4),
            new Ingredient("granola sin azucar", 30, Enums.Unit.gr),
            new Ingredient("obleas de amaranto", 80, Enums.Unit.gr),
            new Ingredient("obleas de amaranto", 33, Enums.Unit.gr),
            new Ingredient("pan birote", .33m),
            new Ingredient("pan integral", 1),
            new Ingredient("pan sin azucar", 1),
            new Ingredient("pan thins", 1),
            new Ingredient("papa cocida", 50, Enums.Unit.gr),
            new Ingredient("pasta cocida", .5m, Enums.Unit.taza),
            new Ingredient("pasta cruda*", .25m, Enums.Unit.taza),
            new Ingredient("pita chips", 20, Enums.Unit.gr),
            new Ingredient("quinoa cocida", .25m, Enums.Unit.taza),
            new Ingredient("quinoa cruda*", .13m, Enums.Unit.taza),
            new Ingredient("tortilla de maiz", 1),
            new Ingredient("tortilla de maiz horneada o microondas", 2),
            new Ingredient("tortilla de nopal", 1.5m),
            new Ingredient("tostadas horneadas", 2),
            new Ingredient("totopos horneados", 26, Enums.Unit.gr)
        };

        public static List<Ingredient> HighFatCereals = new List<Ingredient> 
        {
            new Ingredient("chococrispis", 30, Enums.Unit.gr)
        };

        public static List<Ingredient> AnimalOriginFood = new List<Ingredient> 
        {
            new Ingredient("almeja fresca", 4),
            new Ingredient("atun en aceite", 30, Enums.Unit.gr),
            new Ingredient("atun en agua", 30, Enums.Unit.gr),
            new Ingredient("atun fresco", 30, Enums.Unit.gr),
            new Ingredient("atun horneado", 20, Enums.Unit.gr),
            new Ingredient("camarones crudos", 35, Enums.Unit.gr),
            new Ingredient("carne de cerdo crudo", 40, Enums.Unit.gr),
            new Ingredient("carne de res a la plancha*", 24, Enums.Unit.gr),
            new Ingredient("carne de res cruda", 30, Enums.Unit.gr),
            new Ingredient("carne deshebrada (cocida)*", 21, Enums.Unit.gr),
            new Ingredient("carne molida cocinada*", 24, Enums.Unit.gr),
            new Ingredient("carne molida cruda", 30, Enums.Unit.gr),
            new Ingredient("carne promedio", 30, Enums.Unit.gr),
            new Ingredient("chuleta ahumada", .5m),
            new Ingredient("claras de huevo", 2),
            new Ingredient("huevo entero", 1),
            new Ingredient("jamon de pavo", 1),
            new Ingredient("jamon de pechuga de pavo", 2),
            new Ingredient("machaca", 30, Enums.Unit.gr),
            new Ingredient("pechuga de pollo a la plancha*", 24, Enums.Unit.gr),
            new Ingredient("pechuga de pollo cocida*", 21, Enums.Unit.gr),
            new Ingredient("pechuga de pollo sin piel (cruda)", 30, Enums.Unit.gr),
            new Ingredient("peperoni", 8),
            new Ingredient("pescado a la plancha*", 34, Enums.Unit.gr),
            new Ingredient("pescado crudo", 40, Enums.Unit.gr),
            new Ingredient("pierna de pollo sin piel", 45, Enums.Unit.gr),
            new Ingredient("queso cottage", 3, Enums.Unit.cucharada),
            new Ingredient("queso fresco y queso panela", 40, Enums.Unit.gr),
            new Ingredient("salmon crudo", 30, Enums.Unit.gr),
            new Ingredient("tocino de pavo", 1)
        };

        public static List<Ingredient> DairyProducts = new List<Ingredient> 
        {
            new Ingredient("leche de soya", 1, Enums.Unit.taza),
            new Ingredient("leche semidescremada", 1, Enums.Unit.taza),
            new Ingredient("yogurt griego sin azucar", 1, Enums.Unit.taza),
            new Ingredient("yogurt natural sin azucar", 0.5m, Enums.Unit.taza)
        };

        public static List<Ingredient> DairySubstitutes = new List<Ingredient> 
        {
            new Ingredient("leche de almendras", 1, Enums.Unit.taza),
            new Ingredient("leche de coco", 1, Enums.Unit.taza)
        };

        public static List<Ingredient> LowProteinOils = new List<Ingredient> 
        {
            new Ingredient("aceite de canola", 1, Enums.Unit.cucharadita),
            new Ingredient("aceite de coco", 1, Enums.Unit.cucharadita),
            new Ingredient("aceite de maiz", 1, Enums.Unit.cucharadita),
            new Ingredient("aceite de oliva", 1, Enums.Unit.cucharadita),
            new Ingredient("aguacate", 35, Enums.Unit.gr),
            new Ingredient("mayonesa", 1, Enums.Unit.cucharadita),
            new Ingredient("media crema", 2, Enums.Unit.cucharada),
            new Ingredient("vinagreta", 2, Enums.Unit.cucharadita)
        };

        public static List<Ingredient> ProteinOils = new List<Ingredient> 
        {
            new Ingredient("almendras", 10),
            new Ingredient("cacahuate tostado para pelar", 14),
            new Ingredient("crema de Cacahuate", 2, Enums.Unit.cucharadita),
            new Ingredient("harina de almendras", 10, Enums.Unit.gr),
            new Ingredient("nuez de la india", 27, Enums.Unit.gr),
            new Ingredient("nuez en mitades", 6),
            new Ingredient("pistaches", 30, Enums.Unit.gr)
        };

        public static List<Ingredient> LowFatSugars = new List<Ingredient> 
        {
            new Ingredient("azucar de mesa", 2, Enums.Unit.cucharadita),
            new Ingredient("gelatina light", 1, Enums.Unit.taza),
            new Ingredient("mermelada sin azucar", 2, Enums.Unit.cucharadita),
            new Ingredient("miel", 2, Enums.Unit.cucharadita)
        };

        public static List<Ingredient> FatSugars = new List<Ingredient> 
        {
            new Ingredient("chocolate sin azucar o bajo en azucar", 10, Enums.Unit.gr),
            new Ingredient("nutella", 2, Enums.Unit.cucharadita)
        };

        public static List<Ingredient> SuperFood = new List<Ingredient>
        {
            new Ingredient("chia", 1, Enums.Unit.cucharadita),
            new Ingredient("cocoa", 1, Enums.Unit.cucharadita),
            new Ingredient("matcha", 1, Enums.Unit.cucharadita)
        };
    }
}
