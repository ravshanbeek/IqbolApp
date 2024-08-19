using IqbolApp.Data;
using IqbolApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace IqbolApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Initialize application configuration
            ApplicationConfiguration.Initialize();

            // Set up dependency injection
            var services = new ServiceCollection();

            // Register DbContext with the dependency injection container
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ProductDb01;Trusted_Connection=True;"));

            // Register ProductService with the dependency injection container
            services.AddScoped<IProductService, ProductService>();

            // Build the service provider
            var serviceProvider = services.BuildServiceProvider();

            // Resolve the IProductService instance
            var productService = serviceProvider.GetRequiredService<IProductService>();

            // Run the application with the configured Form1
            Application.Run(new Form1(productService));
        }
    }
}
