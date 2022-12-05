using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogSayfam.Models
{
    public class BlogContext:DbContext
    {
        public BlogContext() : base("blogVT")
        {
            Database.SetInitializer(new BlogInitializer());
        }

       public DbSet<Blog> Bloglar { get; set; }
       
    }
}