
namespace ValidationAttributes
{
using System;
using System.Linq;
using System.Reflection;
    using System.Collections.Generic;
    using System.Collections;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var person = new Person
             (
                 "Petar",
                 11
             );

           bool isValidEntity = Validator.IsValid(person);

            Console.WriteLine(isValidEntity); // True
        }
    }
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            bool result = false;
            PropertyInfo[] propertyInfos = obj.GetType().GetProperties();

            foreach (var propertyInfo in propertyInfos)
            {
                IEnumerable<MyValidationAttribute> attributes = propertyInfo.GetCustomAttributes()
                    .Where(a => a is MyValidationAttribute)
                    .Cast<MyValidationAttribute>();

                foreach (var attribute in attributes)
                {
                    result = attribute.IsValid(propertyInfo.GetValue(obj));

                    if (result == false) return result;
                }
            }

            return result;
        }
    }
    public abstract class MyValidationAttribute : Attribute
    {
        public abstract bool IsValid(object obj);

    }

    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;

        private int maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public override bool IsValid(object obj)
        {
            if(obj is int valueAsInt)
            {
                if (valueAsInt >= minValue && valueAsInt <= maxValue)
                {
                    return true;
                }
                else return false;
            }

            throw new ArgumentException("Invalid type!") ;
        }

        public class MyRequiredAttribute : MyValidationAttribute
        {
            public override bool IsValid(object obj)
            {
                var result = false;
                var entity = (string)obj;
                if(obj as string != null)
                {
                    result = true;
                }
                return result;
            }
        }

    }
}
