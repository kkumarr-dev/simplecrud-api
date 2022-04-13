using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thalavali.API.Entities
{
    public class ThalavaliDbContext:DbContext
    {
        public ThalavaliDbContext()
        {

        }
        public ThalavaliDbContext(DbContextOptions<ThalavaliDbContext> options) : base(options)
        {

        }

        public DbSet<TblUsers> TblUsers { get; set; }
    }
}
