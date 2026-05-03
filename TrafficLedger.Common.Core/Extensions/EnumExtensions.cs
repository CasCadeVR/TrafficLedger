using System.ComponentModel;
using System.Reflection;

namespace TrafficLedger.Common.Core.Extensions;

/// <summary>
/// Расширение для Enum
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Возращает описание Enum, исходя из его аттрибута Description
    /// </summary>
    public static string GetDescription(this Enum value)
    {
        FieldInfo field = value.GetType().GetField(value.ToString());
        DescriptionAttribute attribute = (DescriptionAttribute)field.GetCustomAttribute(typeof(DescriptionAttribute));
        return attribute != null ? attribute.Description : value.ToString();
    }
}
