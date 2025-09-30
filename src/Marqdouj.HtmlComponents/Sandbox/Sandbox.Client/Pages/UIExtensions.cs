using Marqdouj.HtmlComponents.UI;
using Microsoft.FluentUI.AspNetCore.Components;

namespace Sandbox.Client.Pages
{
    internal static class UIExtensions
    {
        internal static bool IsReadOnly(this IUIModelValue item, bool readOnly)
        {
            return readOnly || item.ReadOnly;
        }

        internal static List<Option<string?>> GetBoolLookup(bool withDefault)
        {
            var values = new List<Option<string?>>
            {
                new() {Text = true.ToString(), Value = true.ToString() },
                new() {Text = false.ToString(), Value = false.ToString() }
            };

            if (withDefault)
            {
                values.Insert(0, new() { Text = "<default>", Value = "" });
            }

            return values;
        }

        internal static List<Option<string>> GetEnumLookup<TEnum>(bool withDefault) where TEnum : Enum
        {
            var values = Enum.GetValues(typeof(TEnum)).Cast<TEnum>().Select(e => e.ToString()).OrderBy(e => e);
            var selectOptions = values.Select(e => new Option<string> { Text = e.Replace("_", ""), Value = e }).ToList();

            if (withDefault)
                selectOptions.Insert(0, new Option<string> { Text = "<default>", Value = "" });

            return selectOptions;
        }
    }
}
