using IqbolApp.Models;
using Microsoft.EntityFrameworkCore;

namespace IqbolApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        // Constructor that accepts DbContextOptions
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Parameterless constructor (used for migrations)
        public AppDbContext()
        {
        }

        // OnConfiguring is optional if you're using DbContextOptions
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ProductDb01;Trusted_Connection=True;");
            }
        }
    }
}


//using IqbolApp.Models;
//using Microsoft.EntityFrameworkCore;
//using System.IO;

//namespace IqbolApp.Data
//{
//    public class AppDbContext : DbContext
//    {
//        public DbSet<Product> Products { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {


//            var mdfFilePath = Path.Combine(@"|DataDirectory|", "ProductDb123.mdf");
//            optionsBuilder.UseSqlServer(
//                $@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename={mdfFilePath};Initial Catalog=ProductDb123;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework"
//            );


//            // Use the |DataDirectory| placeholder to specify a relative path
//            //var mdfFilePath = Path.Combine(@"|DataDirectory|", "ProductDb2.mdf");

//            //// Build the connection string with .mdf file located in the DataDirectory
//            //var connectionString = $@"Server=(localdb)\MSSQLLocalDB;AttachDbFilename={mdfFilePath};Database=ProductDb2;Trusted_Connection=True;";

//            //optionsBuilder.UseSqlServer(connectionString);
//        }
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Product>()
//                .Property(p => p.ActualAmount)
//                .HasPrecision(18, 2); // Example precision: 18 digits, 2 after the decimal point

//            modelBuilder.Entity<Product>()
//                .Property(p => p.Amount)
//                .HasPrecision(18, 2); // Example precision: 18 digits, 2 after the decimal point
//        }

//    }
//}
