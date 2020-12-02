using DataAccsessLayer.Abstract;
using DataAccsessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccsessLayer.Abstract
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbSet<T> _objectSet;
        private readonly DataContext _dbContext = new DataContext();

        public Repository()
        {
            _objectSet = _dbContext.Set<T>();
        }
        public int Delete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }

        public T GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }


        public List<T> IList(Func<T, bool> predicate)
        {
            return _objectSet.Where(predicate).ToList();
        }
        public List<T> List()
        {
            return _objectSet.ToList();
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public int Update(T obj)
        {
            throw new NotImplementedException();
        }

        public T IGet(Func<T, bool> predicate)
        {
            return _objectSet.FirstOrDefault(predicate);
        }


    }
}
