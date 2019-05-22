using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faturaProje.REP
{
    public interface IRepository<T> where T:class
    {
        DbSet<T> set();
        T bul(int id);
        void sil(T entity);
        void ekle(T entity);
        void guncelle(T entity);
        void kaydet();
        List<T> liste();
        IQueryable<T> genelliste();
    }
}
