using System.Linq.Expressions;

namespace ItMarathon.Dal.Common.Contracts;

/// <summary>
/// Interface for a generic repository providing basic CRUD operations.
/// </summary>
/// <typeparam name="T">The type of entity managed by the repository.</typeparam>
public interface IRepositoryBase<T>
{
    /// <summary>
    /// Retrieves all entities.
    /// </summary>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>An IQueryable of entities.</returns>
    IQueryable<T> FindAll(bool trackChanges);

    /// <summary>
    /// Retrieves entities that match the specified condition.
    /// </summary>
    /// <param name="expression">The condition to match.</param>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>An IQueryable of entities that match the condition.</returns>
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);

    /// <summary>
    /// Creates a new entity.
    /// </summary>
    /// <param name="entity">The entity to create.</param>
    void Create(T entity);

    /// <summary>
    /// Updates an existing entity.
    /// </summary>
    /// <param name="entity">The entity to update.</param>
    void Update(T entity);

    /// <summary>
    /// Deletes an existing entity.
    /// </summary>
    /// <param name="entity">The entity to delete.</param>
    void Delete(T entity);
}
