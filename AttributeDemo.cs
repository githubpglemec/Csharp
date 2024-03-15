using System;

namespace ncit_hari
{
    // Custom attribute class
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
    public class CustomAttribute : Attribute
    {
        // Property to store additional information
        public string Information { get; }

        // Constructor that accepts additional information
        public CustomAttribute(string information)
        {
            Information = information;
        }
    }

    // Class decorated with built-in attribute
    [Serializable]
    // Class decorated with custom attribute
    [Custom("This is a custom attribute.")]
    public class AttributeDemo
    {
        // Method decorated with custom attribute
        [Custom("This is a custom attribute applied to a method.")]
        public void MethodWithAttribute()
        {
            Console.WriteLine("Method with attribute called.");
        }

        // Property decorated with custom attribute
        [Custom("This is a custom attribute applied to a property.")]
        public int MyProperty { get; set; }

        // Main method
        static void Main(string[] args)
        {
            // Retrieve custom attributes applied to the class
            object[] classAttributes = typeof(AttributeDemo).GetCustomAttributes(typeof(CustomAttribute), true);
            foreach (CustomAttribute attribute in classAttributes)
            {
                Console.WriteLine("Custom attribute applied to class: " + attribute.Information);
            }

            // Create an instance of AttributeDemo
            AttributeDemo obj = new AttributeDemo();

            // Call the method decorated with custom attribute
            obj.MethodWithAttribute();

            // Retrieve custom attributes applied to the method
            var method = typeof(AttributeDemo).GetMethod("MethodWithAttribute");
            object[] methodAttributes = method.GetCustomAttributes(typeof(CustomAttribute), true);
            foreach (CustomAttribute attribute in methodAttributes)
            {
                Console.WriteLine("Custom attribute applied to method: " + attribute.Information);
            }

            // Set and get property value
            obj.MyProperty = 42;
            Console.WriteLine("Property value: " + obj.MyProperty);

            // Retrieve custom attributes applied to the property
            var property = typeof(AttributeDemo).GetProperty("MyProperty");
            object[] propertyAttributes = property.GetCustomAttributes(typeof(CustomAttribute), true);
            foreach (CustomAttribute attribute in propertyAttributes)
            {
                Console.WriteLine("Custom attribute applied to property: " + attribute.Information);
            }

            // Additional information
            Console.WriteLine("\nLab No.: 16");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
