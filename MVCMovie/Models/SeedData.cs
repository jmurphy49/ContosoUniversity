using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCMovie.Data;


namespace MVCMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context =
                new ApplicationDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                //Look for any records, if there are records do nothing
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Doctor Strange",
                        Genre = "Action",
                        ReleaseDate = DateTime.Parse("2016 - 10 - 20"),
                        Price = 14.99M,
                        Rating="R"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        Genre = "Comedy",
                        ReleaseDate = DateTime.Parse("1984 - 03 - 13"),
                        Price = 7.99M,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        Genre = "Comedy",
                        ReleaseDate = DateTime.Parse("1986 - 02 - 23"),
                        Price = 7.99M,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        Genre = "Western",
                        ReleaseDate = DateTime.Parse("1959 - 04 - 15"),
                        Price = 3.99M,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "The Last of the Mohicans",
                        Genre = "Western",
                        ReleaseDate = DateTime.Parse("1992 - 08 - 25"),
                        Price = 3.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Hugo",
                        Genre = "Fantasy/Mystery",
                        ReleaseDate = DateTime.Parse("2011 - 11 - 23"),
                        Price = 8.99M,
                        Rating = "PG"
                    }
                   );
                context.SaveChanges();
            }
        }
    }

}

