using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Plant.Models
{
    public class ProjectModelsContext: DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Leaf> Leafs { get; set; }
        public DbSet<LeafColor> LeafColors { get; set; }
        public DbSet<LeafThickness> LeafThickneses { get; set; }
        public DbSet<LeafShape> LeafShapes { get; set; }
        public DbSet<LeafMargin> LeafMargins { get; set; }
        public DbSet<LeafLocation> LeafLocations { get; set; }
        public DbSet<LeafConnection> LeafConnections { get; set; }
        public DbSet<LeafVenation> LeafVenations { get; set; }
    }
}