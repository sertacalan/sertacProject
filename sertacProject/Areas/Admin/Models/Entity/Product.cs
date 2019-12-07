using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sertacProject.Areas.Admin.Models.Entity
{
    public class Product:BaseEntity
    {
        public int categoryId { get; set; }
        public int brandId { get; set; }
        public int modelId { get; set; }
        public int subModelId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Model Model { get; set; }
        public virtual SubModel SubModel { get; set; }

    }
}