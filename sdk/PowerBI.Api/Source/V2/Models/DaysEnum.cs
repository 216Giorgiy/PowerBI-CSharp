// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DaysEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DaysEnum
    {
        [EnumMember(Value = "Monday")]
        Monday,
        [EnumMember(Value = "Tuesday")]
        Tuesday,
        [EnumMember(Value = "Wednesday")]
        Wednesday,
        [EnumMember(Value = "Thursday")]
        Thursday,
        [EnumMember(Value = "Friday")]
        Friday,
        [EnumMember(Value = "Saturday")]
        Saturday,
        [EnumMember(Value = "Sunday")]
        Sunday
    }
    internal static class DaysEnumEnumExtension
    {
        internal static string ToSerializedValue(this DaysEnum? value)
        {
            return value == null ? null : ((DaysEnum)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DaysEnum value)
        {
            switch( value )
            {
                case DaysEnum.Monday:
                    return "Monday";
                case DaysEnum.Tuesday:
                    return "Tuesday";
                case DaysEnum.Wednesday:
                    return "Wednesday";
                case DaysEnum.Thursday:
                    return "Thursday";
                case DaysEnum.Friday:
                    return "Friday";
                case DaysEnum.Saturday:
                    return "Saturday";
                case DaysEnum.Sunday:
                    return "Sunday";
            }
            return null;
        }

        internal static DaysEnum? ParseDaysEnum(this string value)
        {
            switch( value )
            {
                case "Monday":
                    return DaysEnum.Monday;
                case "Tuesday":
                    return DaysEnum.Tuesday;
                case "Wednesday":
                    return DaysEnum.Wednesday;
                case "Thursday":
                    return DaysEnum.Thursday;
                case "Friday":
                    return DaysEnum.Friday;
                case "Saturday":
                    return DaysEnum.Saturday;
                case "Sunday":
                    return DaysEnum.Sunday;
            }
            return null;
        }
    }
}
