using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoccerApiApp.Models;

namespace SoccerApiApp.Data
{
    public class SoccerApiAppContext : DbContext
    {
        public SoccerApiAppContext (DbContextOptions<SoccerApiAppContext> options)
            : base(options)
        {
        }

        public DbSet<Fixture> Fixture { get; set; }
    }
}
