using HaberPortali.Core.Infrastructure;
using HaberPortali.Data.DataContext;
using HaberPortali.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortali.Core.Repository
{
   public class KategoriRepository:IKategoriRepository
    {
        private readonly HaberContext db = new HaberContext();

        public int Count()
        {
            return db.Kategori.Count();
        }

        public void Delete(int id)
        {
            var Kategori = GetById(id);
            if (Kategori != null)
            {
                db.Kategori.Remove(Kategori);
            }
        }

        public Kategori Get(Expression<Func<Kategori, bool>> expression)
        {
            return db.Kategori.FirstOrDefault(expression);
        }

        public IEnumerable<Kategori> GetAll()
        {
            return db.Kategori.Select(x => x);
        }

        public Kategori GetById(int id)
        {
            return db.Kategori.FirstOrDefault(m => m.ID == id);
        }

        public IQueryable<Kategori> GetMany(Expression<Func<Kategori, bool>> expression)
        {
            return db.Kategori.Where(expression);
            
        }

        public void Insert(Kategori model)
        {
            db.Kategori.Add(model);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Kategori model)
        {
            db.Kategori.AddOrUpdate(model);
        }
    }
}
