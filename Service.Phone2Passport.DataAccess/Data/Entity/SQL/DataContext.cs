using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Service.Phone2Passport.DataAccess.Data.Models;

namespace Service.Phone2Passport.DataAccess.Data.Entity.SQL
{

    public class DataContext : DbContext
    {
        protected readonly IConfiguration ?Configuration;


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer("Data Source=10.55.31.65; Initial Catalog=Clients; User Id=uGate; Password=*New_123#");
        }

        public DbSet<Passport> ?GetCli4Phone { get; set; }
    }
}
