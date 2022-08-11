using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
using Service.Interface;

namespace Service.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MovieContext movieContext;
        private DbSet<T> entities;

        public BaseRepository(MovieContext _movieContext)
        {
            movieContext = _movieContext;
            entities = movieContext.Set<T>();

        }
        public string Create(T entity)
        {

            try
            {
                entities.Add(entity);
                movieContext.SaveChanges();
                return $"Film Eklendi! ";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string Delete(T entity)
        {
            try
            {
                entities.Remove(entity);
                movieContext.SaveChanges();
                return "veri silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<T> GetAll()
        {
            return entities.ToList();
        }

        public T GetById(int id)
        {
            return entities.Find(id);
        }

        public string Update(T entity)
        {
            try
            {
                entities.Update(entity);
                movieContext.SaveChanges();
                return "veri güncellendi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
