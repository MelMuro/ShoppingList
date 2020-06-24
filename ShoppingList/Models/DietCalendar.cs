using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using ShoppingList.Extensions;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ShoppingList.Models
{
    public class DietCalendar
    {
        public Dictionary<int, List<Meal>> MealsPerDay { get; set; }
        public int NumberOfDays { get { return MealsPerDay.Count; } }
        public List<string> NotFoundIngredients { get; set; }

        public DietCalendar(IFormFile formFile)
        {
            MealsPerDay = new Dictionary<int, List<Meal>>();
            NotFoundIngredients = new List<string>();
            ParseExcelFile(formFile);
        }

        private void ParseExcelFile(IFormFile formFile) 
        {
            using var fileStream = formFile.OpenReadStream();
            using var excelPackage = new ExcelPackage(fileStream);
            var worksheet = excelPackage.Workbook.Worksheets[0];
            int lastRowIndex = worksheet.Dimension.End.Row + 2; //need to add a span of two more cells in order to read values from last cell
            int lastColIndex = worksheet.Dimension.End.Column;
            int firstColIndex = 1, dayNumber = 0;
            string mealName = string.Empty;
            var meals = new List<Meal>();
            var ingredients = new List<Ingredient>();
            var rowIndexPerDays = GetRowIndexPerDays(worksheet);

            foreach (var rowIndex in rowIndexPerDays)
            {
                for (int col = firstColIndex; col <= lastColIndex; col++)
                {
                    for (int row = rowIndex.Value; row < lastRowIndex; row++)
                    {
                        if (worksheet.Cells[row, col].Value == null)
                        {
                            if (!string.IsNullOrWhiteSpace(mealName))
                            {
                                meals.Add(new Meal(mealName, new List<Ingredient>(ingredients)));
                                ingredients.Clear();
                            }
                            if (col == lastColIndex)
                            {
                                mealName = string.Empty;
                                MealsPerDay.Add(dayNumber, new List<Meal>(meals));
                                meals.Clear();
                            }
                            break;
                        }

                        string cellStringValue = GetSanitizedCellString(worksheet.Cells[row, col].Value.ToString());
                        if (string.IsNullOrWhiteSpace(cellStringValue)) continue;

                        if (Regex.Match(cellStringValue, @"^(dia)\s\d+").Success)
                        {
                            dayNumber = GetDayNumber(cellStringValue);
                        }
                        else if (cellStringValue.Contains(":"))
                        {
                            mealName = cellStringValue.Trim().TrimEnd(':');
                        }
                        else
                        {
                            string ingredientValue = GetSanitizedIngredientName(cellStringValue);
                            if (ingredientValue.Contains(","))
                            {
                                var ingredientsArray = ingredientValue.Split(',');
                                foreach (string ingredientString in ingredientsArray)
                                {
                                    var ingredient = GetIngredientFromCell(GetSanitizedIngredientName(ingredientString));
                                    if (ingredient != null)
                                    {
                                        ingredients.Add(ingredient);
                                    }
                                    else
                                    {
                                        NotFoundIngredients.Add(ingredientString);
                                    }
                                }
                            }
                            else
                            {
                                var ingredient = GetIngredientFromCell(ingredientValue);
                                if (ingredient != null)
                                {
                                    ingredients.Add(ingredient);
                                }
                                else
                                {
                                    NotFoundIngredients.Add(ingredientValue);
                                }
                            }
                        }
                    }
                } 
            }
        }

        private string GetSanitizedCellString(string cellStringValue) 
        {
            return cellStringValue
                .ToLower()
                .Replace("á", "a")
                .Replace("é", "e")
                .Replace("í", "i")
                .Replace("ó", "o")
                .Replace("ú", "u")
                .Replace(".", "")
                .Replace(";", ""); 
        }

        private string GetSanitizedIngredientName(string cellStringValue) 
        {
            return GetSanitizedCellString(cellStringValue)
                .Replace(" y ", ",")
                .Replace(" y/o ", ",")
                .Replace(" con ", ",")
                .Replace(" sin ", ",")
                .Replace(" + ", ",")
                .Replace("+", ",")
                .ApplySpecialIngredientRules();
        }

        private Dictionary<int, int> GetRowIndexPerDays(ExcelWorksheet excelSheet) 
        {
            int lastRow = excelSheet.Dimension.End.Row;
            int col = 1, firstRow = 1;
            var indexPerDays = new Dictionary<int, int>();

            for (int row = firstRow; row <= lastRow; row++)
            {
                if (excelSheet.Cells[row, col].Value != null && GetSanitizedCellString(excelSheet.Cells[row, col].Value.ToString()).Contains("dia"))
                {
                    indexPerDays.Add(GetDayNumber(GetSanitizedCellString(excelSheet.Cells[row, col].Value.ToString())), row);
                }
            }

            return indexPerDays;
        }

        private int GetDayNumber(string dayCellValue) => int.Parse(Regex.Match(dayCellValue, @"\d+").Value);

        private Ingredient GetIngredientFromCell(string cellStringValue) 
        {
            decimal quantity = 0;
            Enums.Unit unit = Enums.Unit.pieza;

            if (int.TryParse(Regex.Match(cellStringValue, @"\d+").Value, out int parsedNumber)) quantity = parsedNumber;

            foreach (string unitEnum in Enum.GetNames(typeof(Enums.Unit)))
            {
                if (Regex.IsMatch(cellStringValue, @$"\s({unitEnum})\s"))
                {
                    unit = (Enums.Unit)Enum.Parse(typeof(Enums.Unit), unitEnum);
                    break;
                }
            }

            if (quantity == 0) quantity = TryGetFractionNumber(cellStringValue);

            foreach (string ingredientEnum in Enum.GetNames(typeof(Enums.Ingredient)))
            {
                var ingredientEnumValue = (Enums.Ingredient)Enum.Parse(typeof(Enums.Ingredient), ingredientEnum);
                if (cellStringValue.Contains(ingredientEnumValue.GetStringValue()))
                {
                    string ingredientName = ingredientEnum;
                    return new Ingredient(ingredientName, quantity, unit);
                }
            }

            return null;
        }

        private decimal TryGetFractionNumber(string sanitizedIngredientValue) 
        {
            decimal result = 0;
            var validFractions = new Dictionary<string, decimal>()
            {
                {"½", 0.5m },
                {"¼", 0.25m },
                {"¾", 0.75m },
                {"⅓", 0.33m },
                {"⅔", 0.66m }
            };

            foreach (var fraction in validFractions)
            {
                if (sanitizedIngredientValue.Contains(fraction.Key))
                {
                    result = fraction.Value;
                    break;
                }
            }

            return result;
        }

    }
}
