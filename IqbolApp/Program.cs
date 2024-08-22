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
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);

            // Handle non-UI thread exceptions
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

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

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            HandleException(e.Exception);
        }

        // This event handler deals with exceptions on non-UI threads
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            HandleException(ex);
        }

        // A common method to handle exceptions
        static void HandleException(Exception ex)
        {
            // Log the exception, show a message box, or perform any other necessary action
            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Optionally, you can exit the application after handling the exception
            // Application.Exit();
        }
    }
}
