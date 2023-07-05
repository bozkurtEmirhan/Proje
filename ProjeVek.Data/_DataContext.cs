using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProjeVek.Data
{
    public class DataContext : DbContext
    {
        public DataContext(string connectionString) : base(new DbContextOptionsBuilder().UseSqlServer(connectionString).Options)
        {
        }

        public DbSet<Model.Author> Authors { get; set; }
        public DbSet<Model.Category> Categories { get; set; }
        public DbSet<Model.Comment> Comments { get; set; }
        public DbSet<Model.Content> Contents { get; set; }
        public DbSet<Model.ContentCategory> ContentCategories { get; set; }
        public DbSet<Model.ContentTag> ContentTags { get; set; }
        public DbSet<Model.Media> Medias { get; set; }
        public DbSet<Model.Tag> Tags { get; set; }
        public DbSet<Model.Setting> Setting { get; set; }
        public DbSet<Model.Role> Roles { get; set; }
        public DbSet<Model.RolePage> RolePages { get; set; }

       
            }
        }
    

