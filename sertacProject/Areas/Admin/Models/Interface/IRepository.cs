using sertacProject.Areas.Admin.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sertacProject.Areas.Admin.Models.Interface
{
    interface IRepository<T> where T:BaseEntity
    {
        // Talimat metodları yazalım.
        void Save(T model);
        void Delete(T model);
        void Update(T model);
        T Get(int Id);
        List<T> GetAll();

    }
}
