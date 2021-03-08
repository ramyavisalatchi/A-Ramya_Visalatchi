using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspCore7.Models;

namespace AspCore7.Data
{
    public class AspCore7Context : DbContext
    {
        public AspCore7Context (DbContextOptions<AspCore7Context> options)
            : base(options)
        {
        }

        public DbSet<AspCore7.Models.Account> Account { get; set; }
    }
}
