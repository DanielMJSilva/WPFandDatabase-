using System;
using System.Data.Entity;

namespace _301203886_MachadoJustoDaSilva__LAB04

{
    public class PlanetDbContext : DbContext
    {

        public DbSet<Element> PlanetDbSet { get; set; }

        public PlanetDbContext() : base() { }
    }
}
