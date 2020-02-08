using Microsoft.AspNetCore.Http;
using ShoppingList.Extensions;
using System.ComponentModel;

namespace ShoppingList.Models.ViewModels
{
    public class ShoppingListViewModel
    {
        [DisplayName("File")]
        [AllowedExtensions(new string[] { ".xlsx"})]
        public IFormFile SelectedFile { get; set; }
        [DisplayName("Days")]
        public string SelectedDays { get; set; }
    }
}