using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class MyDbContext: DbContext
    {
        public MyDbContext() : base("name=connstr")
        {
            //Database.SetInitializer<MyDbContext>(null);
            
        }
        public DbSet<Admin> Admin { get; set; }

        public DbSet<Invitation> Invitation { get; set; }
        public DbSet<GoWith> GoWith { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Comment> Comment { get; set; }

    }
}
