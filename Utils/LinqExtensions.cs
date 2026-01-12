namespace BlazorApp2.Utils;

public static class LinqExtensions
{
    public static IEnumerable<T> OrderByDynamic<T>(
        this IEnumerable<T> source,
        string prop,
        bool asc)
    {
        var p = typeof(T).GetProperty(prop);
        return asc
            ? source.OrderBy(x => p!.GetValue(x))
            : source.OrderByDescending(x => p!.GetValue(x));
    }
}
