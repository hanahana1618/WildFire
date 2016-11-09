using System;
using Microsoft.EntityFrameworkCore;

namespace Yeoman.Models {
    public class ApplicationDbContext : DbContext {
        public DbSet<Account> Accounts { get; set;}
        public DbSet<Project> Projects { get; set; }
    }
}