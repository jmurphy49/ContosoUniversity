using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGames.Data;

namespace VideoGames.Models
{
    public class VideoGameSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =
                new ApplicationDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if(!context.Rating.Any())
                {
                    context.Rating.AddRange(
                        new Rating {Description="eC"},
                        new Rating { Description = "E" },
                        new Rating { Description = "10+E" },
                        new Rating { Description = "T" },
                        new Rating { Description = "M" },
                        new Rating { Description = "Ao" },
                        new Rating { Description = "Rp" }
                        );
                    context.SaveChanges();
                }
                if (context.VideoGame.Any())
                {
                    return;
                }

                context.VideoGame.AddRange(
                    new VideoGame
                    {
                        Title = "League of Legends",
                        Genre = "MOBA",
                        Platform = "PC",
                        Price = 0M,
                        Publisher = "Riot Games",
                        RatingID = 4,
                        ReleaseDate = DateTime.Parse("2009-10-27")
                    },
                    new VideoGame
                    {
                        Title = "Doom 4",
                        Genre = "FPS",
                        Platform = "Multi",
                        Price = 59.99M,
                        Publisher = "Bethesda",
                        RatingID = 5,
                        ReleaseDate = DateTime.Parse("2016-06-06")
                    },
                    new VideoGame
                    {
                        Title = "Call of Duty",
                        Genre = "FPS",
                        Platform = "Multi",
                        Price = 20.00M,
                        Publisher = "Infinity Ward",
                        RatingID = 5,
                        ReleaseDate = DateTime.Parse("2007-11-05")
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
