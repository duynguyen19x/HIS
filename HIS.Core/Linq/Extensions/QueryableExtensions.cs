using HIS.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Linq.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<TSource> PageBy<TSource>(this IQueryable<TSource> query, int skip, int take)
        {
            if (query == null)
            {
                throw new ArgumentNullException("query");
            }

            return query.Skip(skip).Take(take);
        }

        public static IQueryable<TSource> PageBy<TSource>(this IQueryable<TSource> query, IPagedResultRequest input)
        {
            return query.PageBy(input.SkipCount, input.MaxResultCount);
        }

        public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> query, bool condition, Expression<Func<TSource, bool>> predicate)
        {
            if (!condition)
            {
                return query;
            }
            return query.Where(predicate);
        }

        public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> query, bool condition, Expression<Func<TSource, int, bool>> predicate)
        {
            if (!condition)
            {
                return query;
            }
            return query.Where(predicate);
        }

        public static IQueryable<TSource> OrderBy<TSource>(this IQueryable<TSource> query, IPagedResultRequest input)
        {
            if (input != null 
                && input.Sorting != null && !string.IsNullOrWhiteSpace(input.Sorting))
            {
                var conditions = input.Sorting.Split(',');
            }

            return query;
        }    


        public static IQueryable<TSource> InternalOrderBy<TSource>(this IQueryable<TSource> query, string key, bool ascending = true)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return query;
            }

            var lambda = (dynamic)CreateExpression(typeof(TSource), key);

            return ascending
                ? Queryable.OrderBy(query, lambda)
                : Queryable.OrderByDescending(query, lambda);
        }

        private static LambdaExpression CreateExpression(Type type, string propertyName)
        {
            var param = Expression.Parameter(type, "x");
            Expression body = param;
            foreach (var member in propertyName.Split('.'))
            {
                body = Expression.PropertyOrField(body, member);
            }
            return Expression.Lambda(body, param);
        }
    }
}
