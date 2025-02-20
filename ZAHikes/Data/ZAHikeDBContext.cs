using Microsoft.EntityFrameworkCore;
using ZAHikes.Models.Domains;

namespace ZAHikes.Data
{
    public class ZAHikeDBContext : DbContext
    {
        public ZAHikeDBContext (DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        //property - thse are collections for the DB 
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Hike> Hikes { get; set; } 

    }
}


