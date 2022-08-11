using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IRepository<T> where T:BaseEntity
    {
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<bool> Delete(int id);
    }
}
