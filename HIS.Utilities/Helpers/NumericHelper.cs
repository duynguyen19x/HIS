using System.Globalization;

namespace HIS.Utilities.Helpers
{
    public static class NumericHelper
    {
        public static DateTime? ToLongDatetime(this long? number)
        {
            if (number == null)
                return null;

            if (number.ToString().Length < 14)
                return null;

            return DateTime.ParseExact(number.ToString(), "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
        }
    }
}
