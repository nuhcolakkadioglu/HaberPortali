using HaberPortali.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaberPortali.Data.Model;
using System.Linq.Expressions;
using HaberPortali.Data.DataContext;
using System.Data.Entity.Migrations;

namespace HaberPortali.Core.Repository
{
    public class HaberRepository : IHaberRepository
    {
        private readonly HaberContext db = new HaberContext();

        public int Count()
        {
            return db.Haber.Count();
        }

        public void Delete(int id)
        {
            var Haber = GetById(id);
            if(Haber!=null)
            {
                db.Haber.Remove(Haber);
            }
        }

        public Haber Get(Expression<Func<Haber, bool>> expression)
        {
            return db.Haber.FirstOrDefault(expression);
        }

        public IEnumerable<Haber> GetAll()
        {
            return db.Haber.Select(x => x);
        }

        public Haber GetById(int id)
        {
            return db.Haber.FirstOrDefault(m => m.ID == id);
        }

        public IQueryable<Haber> GetMany(Expression<Func<Haber, bool>> expression)
        {
            return db.Haber.Where(expression);
        }

        public void Insert(Haber model)
        {
            db.Haber.Add(model);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Haber model)
        {
            db.Haber.AddOrUpdate(model);
        }
    }
}
