using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sertacProject.Areas.Admin.Models.Entity
{
    public class Brand:BaseEntity
    {
        public virtual ICollection<Model> Model { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}