// ******************************
// Axis Project
// @__harveyt__
// ******************************
using System.Globalization;

namespace BlazorSql.Server.Services
{
    public static class UtilsReflexion
    {
        // for string
        public static string GetValue<T>(T item, string propertyName)
        {
            return item.GetType().GetProperty(propertyName).GetValue(item, default)?.ToString();
        }
        // for string
        public static void SetValue<T>(T item, string propertyName, string value)
        {
            item.GetType().GetProperty(propertyName).SetValue(item, value, default);
        }
    }
}
