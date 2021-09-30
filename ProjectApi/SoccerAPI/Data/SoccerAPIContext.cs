using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoccerAPI.Models;

namespace SoccerAPI.Data
{
    public class SoccerAPIContext : DbContext
    {
        public SoccerAPIContext (DbContextOptions<SoccerAPIContext> options)
            : base(options)
        {
        }

        public DbSet<SoccerAPI.Models.Fixture> Fixture { get; set; }
    }
}
