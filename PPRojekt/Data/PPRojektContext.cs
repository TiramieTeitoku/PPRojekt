using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PPRojekt.Models
{
    public class PPRojektContext : DbContext
    {
        public PPRojektContext (DbContextOptions<PPRojektContext> options)
            : base(options)
        {
        }

        public DbSet<PPRojekt.Models.User> User { get; set; }
    }
}
