using sertacProject.Areas.Admin.Models.Entity;
using sertacProject.Areas.Admin.Models.Interface;
using sertacProject.Areas.Admin.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sertacProject.Areas.Admin.Models.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private AppDB db;
        public CategoryRepository(AppDB _db)
        {
            db = _db;
        }
        public void Delete(Category model)
        {
            // Context'in içindeki Category'yi silecek.
            db.Category.Remove(model);
            db.SaveChanges();
        }

        public Category Get(int Id)
        {
            return db.Category.Find(Id);
        }

        public List<Category> GetAll()
        {
            // Tüm Category'leri getir.
            return db.Category.ToList();
        }

        public void Save(Category model)
        {
            db.Category.Add(model);
            db.SaveChanges();
        }

        public void Update(Category model)
        {
            db.Entry(model).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}