using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OtelSistemi.Entitiy;

namespace OtelSistemi.Repositories
{
    public class Repository<T> where T:class, new()
    {
        DbOtelEntities1 db = new DbOtelEntities1();
        public List<T> GetAll()
        {
            return db.Set<T>().ToList(); // dışarıdan parametre gönderilecek.
        }

        public void Tadd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }

        public void Tdelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }
        // id'ye göre bulma işlemi
        public T Tget(T id)
        {
            return db.Set<T>().Find(id);
        }
        public void Tupdate(T p)
        {
            db.SaveChanges();
        }
        //Linq Find metodu
        public T Find(Expression<Func<T,bool>>where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }

        //Şartlı Listeleme  
        public List<T> GetListByID(Expression<Func<T, bool>> filter)
        { 
            return db.Set<T>().Where(filter).ToList();
        }
    }
}
