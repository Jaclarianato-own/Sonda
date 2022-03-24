using Microsoft.EntityFrameworkCore;
using Sonda.Domain;
using Sonda.Infrastructure.Data.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.Infrastructure.Data.Context
{
    public class PropertyContext : DbContext
    {
        public DbSet<Cita> citas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=clarianadb2.co8ijfnxyhj8.us-east-1.rds.amazonaws.com,1433;Initial Catalog=dbproperty;Persist Security Info=False;User ID=jclarianat;Password=Camus2802*;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=true;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CitaConfig());


        }
    }
}
