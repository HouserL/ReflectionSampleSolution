using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace ReflectionSample.Logic;

public class ReflectionLogic
{
    public static void GetMethod()
    {

    }
    public static string GetProperties<T>(T input, int indent = 0)
    {
        var output = new StringBuilder();
        var properties = input!.GetType().GetProperties();

        if (input is IEnumerable) // Check to see if object is a List,Array etc
        {
            var list = (IEnumerable)input; //Cast input into a IEnumerable 
            foreach (var item in list)
            {
                output.Append(GetIndent(indent));
                output.Append(GetProperties(item, indent));  // Recursive call for each object in the list
            }
            return output.ToString();
        }
        if (!input.GetType().IsClass)  //Checks to see if initial input is coming from a string,int,bool ect..
        {
            output.AppendLine(input.ToString());
        }
        foreach (var item in properties)
        {
            output.Append(GetIndent(indent));
            output.AppendLine(GetPropertyValue(input, item, indent));
        }

        return output.ToString();
    }

    private static string GetPropertyValue<T>(T input, PropertyInfo property, int indent = 0)
    {
        var displayProperty = GetDisplayName(property); // Check to see if class has a display name for property
        var output = new StringBuilder();

        if (property.PropertyType.IsClass && (property.PropertyType.Name != "String")) // Check to see if property is a class & make sure the it does not just return the Name of it or character by character.
        {
            output.AppendLine(property.Name+": ");
            output.Append(GetProperties(property.GetValue(input), indent+1));
            return output.ToString();
        }
        output.Append($@"{displayProperty}: {property.GetValue(input)}");
        return output.ToString();
    }

    public static string GetDisplayName(PropertyInfo propertyInfo)
    {
        var displayProperty = propertyInfo
                                                .GetCustomAttributes(typeof(DisplayNameAttribute), true)
                                                .Cast<DisplayNameAttribute>()
                                                .SingleOrDefault();
        if (displayProperty == null) return propertyInfo.Name;  // If no Display Name Return the Property Name
        return displayProperty.DisplayName;
    }

    private static string GetIndent(int indent = 0)
    {
        var output = string.Empty;
        for (int i = 0; i < indent ; i++)
        {
            output += $"\t";
        }
        return output;
    }

}

