using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebtestMVC.Models;

namespace WebtestMVC.Data
{
    public class WebtestMVCContext : DbContext
    {
        public WebtestMVCContext (DbContextOptions<WebtestMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
