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
   public class ResimRepository:IResimRepository
    {
        private readonly HaberContext db = new HaberContext();

        public int Count()
        {
            return db.Resim.Count();
        }

        public void Delete(int id)
        {
            var Resim = GetById(id);
            if (Resim != null)
            {
                db.Resim.Remove(Resim);
            }
        }

        public Resim Get(Expression<Func<Resim, bool>> expression)
        {
            return db.Resim.FirstOrDefault(expression);
        }

        public IEnumerable<Resim> GetAll()
        {
            return db.Resim.Select(x => x);
        }

        public Resim GetById(int id)
        {
            return db.Resim.FirstOrDefault(m => m.ID == id);
        }

        public IQueryable<Resim> GetMany(Expression<Func<Resim, bool>> expression)
        {
            return db.Resim.Where(expression);
        }

        public void Insert(Resim model)
        {
            db.Resim.Add(model);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Resim model)
        {
            db.Resim.AddOrUpdate(model);
        }
    }
}
