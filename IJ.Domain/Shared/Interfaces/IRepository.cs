using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace IJ.Domain.Interfaces.Usuarios;


public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAsync();
    Task<T> GetAsyncById(T id);
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> RemoveAsync(T entity);
}