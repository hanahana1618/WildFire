using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PleseWork.Models;

// namespace Yeoman.Data {
//     public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
//     {
//         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//             : base(options)
//         {
//         }

//         protected override void OnModelCreating(ModelBuilder builder)
//         {
//             base.OnModelCreating(builder);
//             // Customize the ASP.NET Identity model and override the defaults if needed.
//             // For example, you can rename the ASP.NET Identity table names and more.
//             // Add your customizations after calling base.OnModelCreating(builder);
//             public DbSet<Project> Projects { get; set; }
//         }
//     }
// }


namespace PleaseWork.Models {
    public class ApplicationDbContext : DbContext {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}