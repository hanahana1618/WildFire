using System;
using Microsoft.EntityFrameworkCore;

namespace Yeoman.Models {
    public class ApplicationDbContext : DbContext {
        public DbSet<Project> Projects { get; set; }
    }
}