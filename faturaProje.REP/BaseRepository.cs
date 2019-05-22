using faturaProje.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faturaProje.REP
{
    public class BaseRepository<T> : IRepository<T> where T : class, new()
     {
        FaturaContext db = DBsingleTone.GetInstance();
        
        public T bul(int id)
        {
            return set().Find(id);
        }

        public T bul(int fd,int urıd)
        {
            return set().Find(fd,urıd);
        }

        public void ekle(T entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Added;
        }

        public IQueryable<T> genelliste()
        {
            return set().AsQueryable();
        }

        public void guncelle(T entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void kaydet()
        {
            db.SaveChanges();
        }

        public List<T> liste()
        {
           return set().ToList();


        }

        public System.Data.Entity.DbSet<T> set()
        {
            return db.Set<T>();
        
        }

        public void sil(T entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
        }
    }
}
