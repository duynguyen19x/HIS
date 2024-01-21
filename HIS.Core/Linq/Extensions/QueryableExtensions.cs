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

        public static IQueryable<TSource> SortBy<TSource>(this IQueryable<TSource> query, ISortedResultRequest input)
        {
            if (input != null 
                && input.Sorting != null && !string.IsNullOrWhiteSpace(input.Sorting))
            {
                var i = 0;
                var props = typeof(TSource).GetProperties();

                var conditions = input.Sorting.Split(',');
                foreach (var condition in conditions)
                {
                    var order = condition.Trim().Split(' ');
                    var prop = typeof(TSource).GetProperties().FirstOrDefault(x => x.Name.ToUpper() == order[0].ToUpper());
                    //var prop = typeof(TSource).GetProperty(order[0]);
                    if (prop != null)
                    {
                        var expression = ToLambda<TSource>(order[0]);

                        var descending = false;
                        if (order.Length > 1 && order[1] != null && order[1].ToUpper().Equals("DESC"))
                            descending = true;

                        if (i == 0)
                        {
                            
                            query = descending ? query.OrderByDescending(expression) : query.OrderBy(expression);
                        }
                        else
                        {
                            query = descending ? ((IOrderedQueryable<TSource>)query).ThenByDescending(expression) : ((IOrderedQueryable<TSource>)query).ThenBy(expression);
                        }

                        i++;
                    }
                }
            }

            return query;
        }    

        public static IQueryable<TSource> ApplySortingAndPaging<TSource>(this IQueryable<TSource> query, IPagedAndSortedResultRequest input)
        {
            return query.SortBy(input).PageBy(input);
        }


        private static Expression<Func<T, object>> ToLambda<T>(string propertyName)
        {
            var parameter = Expression.Parameter(typeof(T));
            var property = Expression.Property(parameter, propertyName);
            var propAsObject = Expression.Convert(property, typeof(object));

            return Expression.Lambda<Func<T, object>>(propAsObject, parameter);
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
