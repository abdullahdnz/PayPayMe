using PayPayMe.DataAccess.Abstract;
using PayPayMe.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPayMe.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T entity)
        {
            using var context = new AppDbContext();
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var context = new AppDbContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var context = new AppDbContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            using var context = new AppDbContext();
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            using var context = new AppDbContext();
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}
