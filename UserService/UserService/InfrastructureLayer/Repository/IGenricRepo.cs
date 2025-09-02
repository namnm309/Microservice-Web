using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repository
{
    public interface IGenricRepo
    {
        //Định nghĩa các phương thức CRUD chung cho tất cả các entity
        Task<T> GetByIdAsync<T>(Guid id) where T : class;
        Task<IEnumerable<T>> GetAllAsync<T>() where T : class;
        Task AddAsync<T>(T entity) where T : class;
        Task UpdateAsync<T>(T entity) where T : class;
        Task DeleteAsync<T>(Guid id) where T : class;
        Task SaveChangesAsync();
    }
}
