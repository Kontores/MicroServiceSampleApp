using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app, bool isProductionEnv)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>(), isProductionEnv);
            }
        }

        private static void SeedData(AppDbContext context, bool isProductionEnv)
        {
            if(isProductionEnv)
            {
                Console.WriteLine("--> Attempting to apply migrations...");
                try
                {
                    context.Database.Migrate();
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"--> Couldn't run migrations: {ex.Message}");
                }
                
            }

            if(context.Platforms.Any())
            {
                Console.WriteLine("Data already exists");
                return;
            }

            Console.WriteLine("Seeding data");
            context.Platforms.AddRange
                (
                new Platform() { Name = ".Net", Publisher = "Microsoft", Cost = "Free" },
                new Platform() { Name = "Sql Server Express", Publisher = "Microsoft", Cost = "Free" },
                new Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" }
                );

            context.SaveChanges();
        }
    }
}
