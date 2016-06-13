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
  public  class RolRepository:IRolRepository
    {
        private readonly HaberContext db = new HaberContext();

        public int Count()
        {
            return db.Rol.Count();
        }

        public void Delete(int id)
        {
            var R = GetById(id);
            if (R != null)
            {
                db.Rol.Remove(R);
            }
        }

        public Rol Get(Expression<Func<Rol, bool>> expression)
        {
            return db.Rol.FirstOrDefault(expression);
        }

        public IEnumerable<Rol> GetAll()
        {
            return db.Rol.Select(x => x);
        }

        public Rol GetById(int id)
        {
            return db.Rol.FirstOrDefault(m => m.ID == id);
        }

        public IQueryable<Rol> GetMany(Expression<Func<Rol, bool>> expression)
        {
            return db.Rol.Where(expression);
        }

        public void Insert(Rol model)
        {
            db.Rol.Add(model);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Rol model)
        {
            db.Rol.AddOrUpdate(model);
        }
    }
}
