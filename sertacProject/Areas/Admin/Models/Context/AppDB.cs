using sertacProject.Areas.Admin.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace sertacProject.Areas.Admin.Models.Context
{
    public class AppDB:DbContext
    {
        public AppDB():base("name=SertacDB")
        {

        }
        //Tablo olacak Class(Entity) işaretliyoruz.
        public DbSet<Category> Category { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Model> Model { get; set; }
        public DbSet<SubModel> SubModel { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
            .HasRequired<Model>(s => s.Model)
            .WithMany().WillCascadeOnDelete(false);


            modelBuilder.Entity<Product>()
            .HasRequired<SubModel>(s => s.SubModel)
            .WithMany().WillCascadeOnDelete(false);

        }
    }
}