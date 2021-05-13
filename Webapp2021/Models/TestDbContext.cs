using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapp2021.Models
{
    public class TestDbContext:DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public TestDbContext(DbContextOptions<TestDbContext> dbContextOptions) : base(dbContextOptions)
        {
            Database.EnsureCreated();
            if (!Phones.Any())
            {
                Phones.Add(new Phone
                {
                    Name = "Iphone",
                    Model = "X",
                    Price = "54,000 P.",
                    Description = "Iphone X new!",
                    IsActive = true
                });
                Phones.Add(new Phone
                {
                    Name = "Iphone",
                    Model = "Eight",
                    Description = "Iphone 8 new!",
                    Price = "42,000 P",
                    IsActive = false
                });

            }
        }
    }
}
