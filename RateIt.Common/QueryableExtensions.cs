using System;
using System.Linq;
using System.Linq.Expressions;

namespace RateIt.Common
{
	public static class QueryableExtensions
	{
		public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> source, bool useFilter, Expression<Func<TSource, bool>> predicate)
		{
			return useFilter ? source.Where(predicate) : source;
		}
	}
}