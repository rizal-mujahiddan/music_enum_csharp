using System;
using System.ComponentModel;

namespace Extensions {
    public static class EnumExtensions
    {
        // Generic extension method constrained to Enum types
        public static TEnum GetEnumValueFromDescription<TEnum>(this string description) where TEnum : Enum
        {
            // Get all fields of the enum type
            var enumType = typeof(TEnum);
            foreach (var field in enumType.GetFields())
            {
                // Check if the field has a Description attribute
                var descriptionAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
                if (descriptionAttribute?.Description == description)
                {
                    return (TEnum)field.GetValue(null); // Return the enum value
                }
            }

            // Throw an exception if no matching description is found
            throw new ArgumentException($"No enum value found for description '{description}'", nameof(description));
        }
    }
}
