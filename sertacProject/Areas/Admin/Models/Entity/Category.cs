using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sertacProject.Areas.Admin.Models.Entity
{
    public class Category:BaseEntity
    {
        public virtual ICollection<Product> Product { get; set; }
    }
}