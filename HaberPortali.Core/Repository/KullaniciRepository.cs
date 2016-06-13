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
  public class KullaniciRepository:IKullaniciRepository
    {
        private readonly HaberContext db = new HaberContext();

        public int Count()
        {
            return db.Kullanici.Count();
        }

        public void Delete(int id)
        {
            var k = GetById(id);
            if (k != null)
            {
                db.Kullanici.Remove(k);
            }
        }

        public Kullanici Get(Expression<Func<Kullanici, bool>> expression)
        {
            return db.Kullanici.FirstOrDefault(expression);
        }

        public IEnumerable<Kullanici> GetAll()
        {
            return db.Kullanici.Select(x => x);
        }

        public Kullanici GetById(int id)
        {
            return db.Kullanici.FirstOrDefault(m => m.ID == id);
        }

        public IQueryable<Kullanici> GetMany(Expression<Func<Kullanici, bool>> expression)
        {
            return db.Kullanici.Where(expression);
        }

        public void Insert(Kullanici model)
        {
            db.Kullanici.Add(model);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Kullanici model)
        {
            db.Kullanici.AddOrUpdate(model);
        }
    }
}
