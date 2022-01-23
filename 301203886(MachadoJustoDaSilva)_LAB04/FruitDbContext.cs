using System;
using System.Data.Entity;

namespace _301203886_MachadoJustoDaSilva__LAB04

{
    public class FruitDbContext : DbContext
    {

        public DbSet<Element> FruitDbSet { get; set; }

        public FruitDbContext() : base() { }
    }
}