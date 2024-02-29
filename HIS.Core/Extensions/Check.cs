using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Extensions
{
    public static class Check
    {
        public static bool IsNullOrDefault(bool? value)
        {
            return value == null || value == default(bool);
        }

        public static bool IsNullOrDefault(int? value)
        {
            return value == null || value == default(int);
        }

        public static bool IsNullOrDefault(DateTime? value)
        {
            return value == null || value == default(DateTime);
        }

        public static bool IsNullOrDefault(Guid? value)
        {
            return value == null || value == default(Guid);
        }

        public static bool IsNullOrEmpty(string value)
        {
            return value == null || string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNotNullOrDefault(bool? value)
        {
            return value != null && value != default(bool);
        }

        public static bool IsNotNullOrDefault(int? value)
        {
            return value != null && value != default(int);
        }

        public static bool IsNotNullOrDefault(DateTime? value)
        {
            return value != null && value != default(DateTime);
        }

        public static bool IsNotNullOrDefault(Guid? value)
        {
            return value != null && value != default(Guid);
        }

        public static bool IsNotNullOrEmpty(string value)
        {
            return value != null && value.Length > 0;
        }


        public static bool IsNullOrEmpty<T>(this ICollection<T> source)
        {
            return source == null || source.Count <= 0;
        }

        /// <summary>
        /// Kiểm tra chuỗi có trong mảng.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool IsIn(this string str, params string[] data)
        {
            foreach (var item in data)
            {
                if (str == item)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsEquals(object objA, object objB)
        {
            return Equals(objA, objB);
        }

        public static bool IsNotEquals(object objA, object objB)
        {
            return !Equals(objA, objB);
        }
    }
}
