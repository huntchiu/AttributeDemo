using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AttributeDemo.Attributes;

namespace AttributeDemo
{
    public static class AttributeUtils
    {
        public static Dictionary<string, string> GetPropertyOfFileds<T>()
        {
            return typeof(T).GetProperties()
                .Where(prop => Attribute.IsDefined(prop, typeof(FieldAttribute)))
                .ToDictionary(
                    prop => prop.Name,
                    prop => ((FieldAttribute)prop.GetCustomAttributes(typeof(FieldAttribute), false).First()).Name
                );
        }
    }
}



