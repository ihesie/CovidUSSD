using CovidUSSD.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CovidUSSD.Service
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CovidUssdDBContext covidUssdDBContext;

        public Repository(CovidUSSD.Data.CovidUssdDBContext covidUssdDBContext)
        {
            this.covidUssdDBContext = covidUssdDBContext;
        }
        public void Delete(Guid id)
        {
            var entity = this.covidUssdDBContext.Set<T>().Find(id);
            if (entity != null)
            {
                this.covidUssdDBContext.Set<T>().Remove(entity);
                this.covidUssdDBContext.SaveChanges();
            }

        }

        public ICollection<T> FindAll(Expression<Func<T, bool>> match)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
