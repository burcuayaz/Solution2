using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> List();

        int Save();
        int Insert(T obj);
        int Update(T obj);
        int Delete(T obj);

        T IGet(Func<T, bool> predicate);
        List<T> IList(Func<T, bool> predicate);
        T GetById(int Id);
    }
}