using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Extensions
{
    /// <summary>
    /// Kiểm tra dữ liệu
    /// </summary>
    public static class Check
    {
        #region - is null or default

        public static bool IsNullOrDefault(bool? value)
        {
            return value == null || value == default(bool);
        }

        public static bool IsNullOrDefault(string value)
        {
            return value == null || string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNullOrDefault(int? value)
        {
            return value == null || value == default(int);
        }

        public static bool IsNullOrDefault(long? value)
        {
            return value == null || value == default(long);
        }

        public static bool IsNullOrDefault(decimal? value)
        {
            return value == null || value == default(decimal);
        }

        public static bool IsNullOrDefault(DateTime? value)
        {
            return value == null || value == default(DateTime);
        }

        public static bool IsNullOrDefault(Guid? value)
        {
            return value == null || value == default(Guid);
        }

        #endregion

        #region - is not null and default

        public static bool IsNotNullAndDefault(bool? value)
        {
            return value != null && value != default(bool);
        }

        public static bool IsNotNullAndDefault(string value)
        {
            return value != null && value.Length > 0;
        }

        public static bool IsNotNullAndDefault(int? value)
        {
            return value != null && value != default(int);
        }

        public static bool IsNotNullAndDefault(long? value)
        {
            return value != null && value != default(long);
        }

        public static bool IsNotNullAndDefault(decimal? value)
        {
            return value != null && value != default(decimal);
        }

        public static bool IsNotNullAndDefault(DateTime? value)
        {
            return value != null && value != default(DateTime);
        }

        public static bool IsNotNullAndDefault(Guid? value)
        {
            return value != null && value != default(Guid);
        }

        #endregion

        #region - collection

        public static bool IsNullOrEmpty<T>(this ICollection<T> source)
        {
            return source == null || source.Count <= 0;
        }

        public static bool IsNotNullOrEmpty<T>(this ICollection<T> source)
        {
            return source != null && source.Count > 0;
        }

        public static bool Any<T>(ICollection<T> source)
        {
            return source != null && source.Any();
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

        #endregion

        #region - object

        public static bool IsEquals(object objA, object objB)
        {
            return Equals(objA, objB);
        }

        public static bool IsNotEquals(object objA, object objB)
        {
            return !Equals(objA, objB);
        }

        public static T As<T>(this object obj)
            where T : class
        {
            return (T)obj;
        }

        public static T To<T>(this object obj)
            where T : struct
        {
            if (typeof(T) == typeof(Guid) || typeof(T) == typeof(TimeSpan))
            {
                return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(obj.ToString());
            }
            if (typeof(T).IsEnum)
            {
                if (Enum.IsDefined(typeof(T), obj))
                {
                    return (T)Enum.Parse(typeof(T), obj.ToString());
                }
                else
                {
                    throw new ArgumentException($"Enum type undefined '{obj}'.");
                }
            }

            return (T)Convert.ChangeType(obj, typeof(T), CultureInfo.InvariantCulture);
        }

        #endregion
    }
}
