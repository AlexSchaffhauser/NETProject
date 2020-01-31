using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETGalaxyView
{
    public class BuildingContext : DbContext
    {

        public DbSet<Planet> Planets { get; set; }

        public DbSet<Building> Buildings { get; set; }

    }
}
