using System;

namespace ShoppingList.Extensions
{
    public class StringValueAttribute: Attribute
    {
        public string Value { get; set; }
        public StringValueAttribute(string value)
        {
            Value = value;
        }
    }
}
