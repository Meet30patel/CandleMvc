using CandleMvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcCandle.Data;
using System;
using System.Linq;

namespace MvcCandle.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {

                if (context.Candle.Any())
                {
                    return;   // DB has been seeded
                }

                context.Candle.AddRange(


                    new Candle
                    {
                        Type = "Candlex",
                        Material = "Wax",
                        Length = "3inch",
                        Origin = "INDIA",
                        Color = "White",
                        Price = 10.00M
                    }


                );
                ;
                context.SaveChanges();
            }
        }
    }
}
