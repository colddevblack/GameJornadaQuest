using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace JogoTurno;

public static class EnumExtentions
{
    public static string? GetDisplayName(this Enum enumValue)
    {
        return enumValue.GetType()
          .GetMember(enumValue.ToString())[0]
          .GetCustomAttribute<DisplayAttribute>()
          ?.GetName();
    }
}
