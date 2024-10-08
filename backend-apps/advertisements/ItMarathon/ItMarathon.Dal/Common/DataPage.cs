namespace ItMarathon.Dal.Common
{
    /// <summary>
    /// Record for holding a paged data items and total count.
    /// </summary>
    /// <typeparam name="T">Type of item.</typeparam>
    /// <param name="Items">Page of items.</param>
    /// <param name="TotalCount">Total count of items.</param>
    public record class DataPage<T>(IEnumerable<T> Items, long TotalCount);
}
