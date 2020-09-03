using ShoppingList.Models;
using System;
using System.Reflection;

namespace ShoppingList.Extensions
{
    public static class ExtensionMethods
    {
        public static string GetStringValue(this Enum value) 
        {
            string stringValue = value.ToString();
            FieldInfo fieldInfo = value.GetType().GetField(stringValue);
            StringValueAttribute[] attrs = fieldInfo.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];

            if (attrs.Length > 0)
            {
                stringValue = attrs[0].Value;
            }
            return stringValue;
        }

        public static string ApplySpecialIngredientRules(this string value) 
        {
            value = value
                .Replace("yogur", Enums.Ingredient.yogurtNaturalSinAzucar.GetStringValue())
                .Replace("yogurt", Enums.Ingredient.yogurtNaturalSinAzucar.GetStringValue())
                .Replace("pepperoni", Enums.Ingredient.peperoni.GetStringValue())
                .Replace("granola", Enums.Ingredient.granolaSinAzucar.GetStringValue())
                .Replace("nieve", Enums.Ingredient.nieveSinAzucar.GetStringValue())
                .Replace("chuletas", Enums.Ingredient.chuletaAhumada.GetStringValue())
                .Replace("tostada", Enums.Ingredient.tostadasHorneadas.GetStringValue())
                .Replace("jalapeños", Enums.Ingredient.chileJalapeño.GetStringValue())
                .Replace("tortillas", "tortilla")
                .Replace("almendras", "almendra");

            if (!value.Contains(Enums.Ingredient.pechugaDePollo.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.piernaDePollo.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.polloDesmenuzado.GetStringValue()))
            {
                value = value.Replace("pollo", Enums.Ingredient.pechugaDePollo.GetStringValue());
            }

            if (!value.Contains(Enums.Ingredient.jamonDePavo.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.jamonDePechugaDePavo.GetStringValue()))
            {
                value = value.Replace("jamon", Enums.Ingredient.jamonDePavo.GetStringValue());
            }

            if (!value.Contains(Enums.Ingredient.chuletaAhumada.GetStringValue()))
            {
                value = value.Replace("chuleta", Enums.Ingredient.chuletaAhumada.GetStringValue());
            }

            if (!value.Contains(Enums.Ingredient.atunEnAceite.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.atunEnAgua.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.atunFresco.GetStringValue()))
            {
                value = value.Replace("atun", Enums.Ingredient.atunEnAgua.GetStringValue());
            }

            if (!value.Contains(Enums.Ingredient.lecheDeAlmendra.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.lecheDescremada.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.lecheDeSoya.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.lecheLight.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.lecheSemidescremada.GetStringValue()))
            {
                value = value.Replace("leche", Enums.Ingredient.lecheDescremada.GetStringValue());
            }

            if (!value.Contains(Enums.Ingredient.lecheDeAlmendra.GetStringValue()) && 
                !value.Contains(Enums.Ingredient.harinaDeAlmendra.GetStringValue()))
            {
                value = value.Replace("almendra", Enums.Ingredient.almendraPieza.GetStringValue());
            }

            if (!value.Contains(Enums.Ingredient.panBirote.GetStringValue()) && 
                !value.Contains(Enums.Ingredient.panIntegral.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.panPita.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.panSinAzucar.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.panThins.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.quesoPanela.GetStringValue()))
            {
                value = value.Replace("pan", Enums.Ingredient.panSinAzucar.GetStringValue());
            }

            if (!value.Contains(Enums.Ingredient.tocinoDePavo.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.pavoMolido.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.jamonDePavo.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.jamonDePechugaDePavo.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.pavoAlPastor.GetStringValue()))
            {
                value = value.Replace("pavo", Enums.Ingredient.pavo.GetStringValue());
            }

            if (!value.Contains(Enums.Ingredient.quesoCottage.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.quesoOaxaca.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.quesoVegano.GetStringValue()) &&
                !value.Contains(Enums.Ingredient.quesoPanela.GetStringValue()))
            {
                value = value.Replace("queso", Enums.Ingredient.quesoPanela.GetStringValue());
            }

            return value;
        }
    }
}
