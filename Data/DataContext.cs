using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using sehir_Rehberi.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sehir_Rehberi.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
       public DbSet<Value> Values { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<photo> photos { get; set; }
        public DbSet<User> Users { get; set; }
      


    }
}
