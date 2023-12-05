using System.Collections.Generic;

namespace HIS.Application.Core.Utils
{
    public class DataHelper
    {
        public static bool IsNullOrDefault(int? value)
        {
            return value == null || value == default(int);
        }

        public static bool IsNullOrDefault(long? value)
        {
            return value == null || value == default(long);
        }

        public static bool IsNullOrDefault(double? value)
        {
            return value == null || value == default(double);
        }

        public static bool IsNullOrDefault(decimal? value)
        {
            return value == null || value == default(decimal);
        }

        public static bool IsNullOrDefault(float? value)
        {
            return value == null || value == default(float);
        }

        public static bool IsNullOrDefault(string value)
        {
            return string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNullOrDefault(DateTime? value)
        {
            return value == null || value == default(DateTime);
        }

        public static bool IsNullOrDefault(Guid? value)
        {
            return value == null || value == default(Guid);
        }
    }
}
