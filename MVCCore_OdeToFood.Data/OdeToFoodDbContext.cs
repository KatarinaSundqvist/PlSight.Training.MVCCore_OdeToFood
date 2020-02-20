using Microsoft.EntityFrameworkCore;
using MVCCore_OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCore_OdeToFood.Data {
    public class OdeToFoodDbContext:DbContext {
        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options):base(options) {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
