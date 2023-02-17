using CandleMvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcCandle.Models;
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
                    },

                    new Candle
                    {
                        Type = "pillar",
                        Material = "Wax",
                        Length = "3inch",
                        Origin = "afganistan",
                        Color = "all",
                        Price = 2.00M
                    },

                    new Candle
                    {
                        Type = "taper",
                        Material = "Wax",
                        Length = "10inch",
                        Origin = "nigeria",
                        Color = "black",
                        Price = 6.00M
                    },

                    new Candle
                    {
                        Type = "votive",
                        Material = "Wax",
                        Length = "3inch",
                        Origin = "france",
                        Color = "lavender",
                        Price = 80.00M
                    },

                    new Candle
                    {
                        Type = "Candlex",
                        Material = "Wax",
                        Length = "3inch",
                        Origin = "INDIA",
                        Color = "White",
                        Price = 10.00M
                    },

                    new Candle
                    {
                        Type = "soy",
                        Material = "Wax",
                        Length = "2inch",
                        Origin = "pakistan",
                        Color = "palistan",
                        Price = 3.00M
                    },

                    new Candle
                    {
                        Type = "beeswax",
                        Material = "Wax",
                        Length = "3inch",
                        Origin = "africa",
                        Color = "yellow",
                        Price = 10.00M
                    },

                    new Candle
                    {
                        Type = "scented",
                        Material = "Wax",
                        Length = "4.5inch",
                        Origin = "INDIA",
                        Color = "White",
                        Price = 30.00M
                    },

                    new Candle
                    {
                        Type = "Aromatherapy",
                        Material = "Wax",
                        Length = "5inch",
                        Origin = "UAE",
                        Color = "green",
                        Price = 60.00M
                    },

                    new Candle
                    {
                        Type = "tea light",
                        Material = "Wax",
                        Length = "5inch",
                        Origin = "Myanmar",
                        Color = "magenta",
                        Price = 60.00M
                    },

                    new Candle
                    {
                        Type = "Decorative",
                        Material = "Wax",
                        Length = "5inch",
                        Origin = "USA",
                        Color = "Blue",
                        Price = 20.00M
                    }







                );
                ;
                context.SaveChanges();
            }
        }
    }
}
