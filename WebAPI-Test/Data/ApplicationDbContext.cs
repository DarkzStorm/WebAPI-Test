using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebAPI_Test.Models;

namespace WebAPI_Test.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<UserInformation> UserInformations { get; set; }
    }
}
