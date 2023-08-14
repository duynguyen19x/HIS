using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Helpers
{
    public static class StringHelper
    {
        public static bool ToShortStringDateFormat(this string input, out DateTime output)
        {
            return DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out output);
        }

        public static bool ToLongStringDateFormat(this string input, out DateTime output)
        {
            return DateTime.TryParseExact(input, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out output);
        }

        //public static bool ToShortStringDateFormat(this string input, out DateTime? output)
        //{
        //    DateTime dateTime;

        //    var isOutput = DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
        //    if (isOutput)
        //        output = dateTime;

        //    return isOutput;
        //}

        //public static bool ToLongStringDateFormat(this string input, out DateTime? output)
        //{
        //    DateTime dateTime;

        //    var isOutput = DateTime.TryParseExact(input, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
        //    if (isOutput)
        //        output = dateTime;

        //    return isOutput;
        //}
    }
}
