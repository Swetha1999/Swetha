using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspCoreEF.Models;

namespace AspCoreEF.Data
{
    public class AspCoreEFContext : DbContext
    {
        public AspCoreEFContext (DbContextOptions<AspCoreEFContext> options)
            : base(options)
        {
        }

        public DbSet<AspCoreEF.Models.Account> Account { get; set; }
    }
}
