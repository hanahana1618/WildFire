using System;
using Microsoft.EntityFrameworkCore;

namespace WildFire.Models {
    public class ApplicationDbContext : DbContext {
        public DbSet<Character> Characters { get; set; }
    }
}