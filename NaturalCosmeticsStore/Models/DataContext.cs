﻿using Microsoft.EntityFrameworkCore;

namespace NaturalCosmeticsStore.Models
{
    public class DataContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DataContext(DbContextOptions<DataContext> options):base(options){ }
    }
}
