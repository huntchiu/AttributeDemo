using System;
namespace AttributeDemo.Attributes
{
    public class FieldAttribute : Attribute 
    { 
        public string Name { get; set; } 
        public FieldAttribute(string name)
        {
            Name = name;
        }
    }
}