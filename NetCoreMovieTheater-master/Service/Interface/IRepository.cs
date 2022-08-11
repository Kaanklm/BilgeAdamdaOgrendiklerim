using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IRepository<T> where T:BaseEntity
    {
        //List
        List<T> GetAll();
        //Find
        T GetById(int id);
        //Create
        string Create(T entity);
        //Update
        string Update(T entity);
        //Delete
        string Delete(T entity);



    }
}
