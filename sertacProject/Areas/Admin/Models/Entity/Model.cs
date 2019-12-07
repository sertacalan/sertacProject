using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sertacProject.Areas.Admin.Models.Entity
{
    public class Model:BaseEntity
    {
        public int brandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<SubModel> SubModel { get; set; }
        public virtual ICollection<Product> Product { get; set; }

    }
}