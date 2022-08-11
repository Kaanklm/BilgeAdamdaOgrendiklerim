using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<T> dbSet;

        public BaseRepository(ApplicationDbContext _context)
        {
            context = _context;
            this.dbSet = context.Set<T>();
        }

        public async Task<bool> Add(T entity)
        {
            try
            {
                await dbSet.AddAsync(entity);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                var result = await dbSet.Where(x => x.Id == id).FirstOrDefaultAsync();
                if (result != null)
                {
                    dbSet.Remove(result);
                    await context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<List<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<bool> Update(T entity)
        {
            try
            {
                dbSet.Update(entity);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
