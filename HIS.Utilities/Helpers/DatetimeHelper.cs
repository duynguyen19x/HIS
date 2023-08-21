using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Helpers
{
    public static class DatetimeHelper
    {
        public static bool IsNullOrEmpty(DateTime? dateTime)
        {
            return dateTime == null || (dateTime != null && dateTime == (DateTime)default);
        }

        public static DateTime? UtcToLocal(this DateTime? dateTime)
        {
            // Lấy múi giờ hiện tại của hệ thống
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;

            // Lấy giá trị chênh lệch so với giờ GMT tại thời điểm hiện tại
            TimeSpan gmtOffset = localTimeZone.GetUtcOffset(DateTime.Now);

            if (dateTime == null)
                return null;
            else
                return dateTime.Value.AddHours(gmtOffset.Hours);
        }

        public static string ToShortDateStringFormat(this DateTime? dateTime)
        {
            if (dateTime == null)
                return null;
            else
                return dateTime.Value.ToString("yyyy-MM-dd");
        }

        public static string ToLongDateStringFormat(this DateTime? dateTime)
        {
            if (dateTime == null)
                return null;
            else
                return dateTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string ToShortDateStringFormat(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd");
        }

        public static string ToLongDateStringFormat(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
