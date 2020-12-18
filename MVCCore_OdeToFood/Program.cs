using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVCCore_OdeToFood.Data;

namespace MVCCore_OdeToFood {
    public class Program {
        public static void Main(string[] args) {
            var host = CreateHostBuilder(args).Build();

            MigrateDatabase(host);
            // This step will make sure a migration runs when you start up the application
            // and if no database exists, it will create one (assuming it has rights to do so, error otherwise!)
            // in production, you would want additional things in place, such as running a back-up first, for example

            host.Run();
        }

        private static void MigrateDatabase(IHost host) {
            using (var scope = host.Services.CreateScope()) {
                var db = scope.ServiceProvider.GetRequiredService<OdeToFoodDbContext>();
                db.Database.Migrate();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
