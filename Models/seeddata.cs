using Microsoft.EntityFrameworkCore;
using RazorPagesLibrary.Data;
using System;

namespace RazorPagesLibrary.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesLibraryContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesLibraryContext>>()))
            {
                if (context == null || context.Book == null)
                {
                    throw new ArgumentNullException("Null RazorPageLibraryContext");
                }

                // Look for any books
                if (context.Book.Any())
                {
                    return; // DB has been seeded
                }

                context.Book.AddRange(
                    new BookModel
                    {
                        Title = "The Psychology of Money",
                        Author = "Morgan Housel",
                        Genre = "Study Guide",
                        ISBN = "9780857197689",
                        PublicationDate = DateTime.Parse("2020-08-09"),
                        Pages = 256,
                        CoverImagePath = "/images/b1.jpg"
                    },
                    new BookModel
                    {
                        Title = "The 48 Laws of Power",
                        Author = "Robert Greene",
                        Genre = "Self Help",
                        ISBN = "0670881465",
                        PublicationDate = DateTime.Parse("1998-01-01"),
                        Pages = 480,
                        CoverImagePath = "/images/b2.jpg"
                    },
                    new BookModel
                    {
                        Title = "Never Finished",
                        Author = "David Goggins",
                        Genre = "Autobiography",
                        ISBN = "9781544534077",
                        PublicationDate = DateTime.Parse("2022-04-12"),
                        Pages = 297,
                        CoverImagePath = "/images/b3.jpg"
                    },
                    new BookModel
                    {
                        Title = "The Millennial Yogi",
                        Author = "Deepam Chatterjee",
                        Genre = "Self Help",
                        ISBN = "0143456148",
                        PublicationDate = DateTime.Parse("2022-02-28"),
                        Pages = 256,
                        CoverImagePath = "/images/b4.jpg"
                    },
                    new BookModel
                    {
                        Title = "The Underdog Founder",
                        Author = "Edrizio de La Cruz",
                        Genre = "Business & Finance",
                        ISBN = "9798989110919",
                        PublicationDate = DateTime.Parse("2023-09-19"),
                        Pages = 184,
                        CoverImagePath = "/images/b5.jpg"
                    },
                    new BookModel
                    {
                        Title = "The Silent Symphony",
                        Author = "Sally Chiwuzie",
                        Genre = "Mystery",
                        ISBN = "9781234567892",
                        PublicationDate = DateTime.Parse("2022-12-15"),
                        Pages = 320,
                        CoverImagePath = "/images/b6.jpg"
                    },
                    new BookModel
                    {
                        Title = "Echoes of Eternity",
                        Author = "Josh Steve",
                        Genre = "Fantasy",
                        ISBN = "9789876543210",
                        PublicationDate = DateTime.Parse("2023-05-28"),
                        Pages = 400,
                        CoverImagePath = "/images/b7.jpg"
                    },
                    new BookModel
                    {
                        Title = "The Quantum Paradox",
                        Author = "Jasmeet Singh",
                        Genre = "Science Fiction",
                        ISBN = "9797654321098",
                        PublicationDate = DateTime.Parse("2023-08-03"),
                        Pages = 256,
                        CoverImagePath = "/images/b8.jpg"
                    },
                    new BookModel
                    {
                        Title = "Heartstrings",
                        Author = "Rachel Lane",
                        Genre = "Romance",
                        ISBN = "9780123456789",
                        PublicationDate = DateTime.Parse("2023-11-20"),
                        Pages = 280,
                        CoverImagePath = "/images/b9.jpg"
                    },
                    new BookModel
                    {
                        Title = "Mindful Living",
                        Author = "Jason Hemlock",
                        Genre = "Self Help",
                        ISBN = "9798765432109",
                        PublicationDate = DateTime.Parse("2023-09-10"),
                        Pages = 240,
                        CoverImagePath = "/images/b10.jpg"
                    },
                    new BookModel
                    {
                        Title = "The Forgotten Kingdom",
                        Author = "Nicole Ciacchella",
                        Genre = "Historical Fiction",
                        ISBN = "9781098765432",
                        PublicationDate = DateTime.Parse("2023-02-08"),
                        Pages = 368,
                        CoverImagePath = "/images/b11.jpg"
                    },
                    new BookModel
                    {
                        Title = "The Whispers of the Wind",
                        Author = "Abigail Thompson",
                        Genre = "Thriller",
                        ISBN = "9790123456789",
                        PublicationDate = DateTime.Parse("2023-07-17"),
                        Pages = 312,
                        CoverImagePath = "/images/b12.jpg"
                    },
                    new BookModel
                    {
                        Title = "The Art of Mindfulness",
                        Author = "Thich Nhat Hanh",
                        Genre = "Philosophy",
                        ISBN = "9790123456789",
                        PublicationDate = DateTime.Parse("2023-10-15"),
                        Pages = 224,
                        CoverImagePath = "/images/b13.jpg"
                    },
                    new BookModel
                    {
                        Title = "Beneath the Starry Sky",
                        Author = "Jessica E. Subject",
                        Genre = "Young Adult",
                        ISBN = "9781234567890",
                        PublicationDate = DateTime.Parse("2023-06-12"),
                        Pages = 336,
                        CoverImagePath = "/images/b14.jpg"
                    },
                    new BookModel
                    {
                        Title = "The Quantum Enigma",
                        Author = "Wolfgang Smith",
                        Genre = "Science Fiction",
                        ISBN = "9790909090909",
                        PublicationDate = DateTime.Parse("2023-03-21"),
                        Pages = 272,
                        CoverImagePath = "/images/b15.jpg"
                    },
                    new BookModel
                    {
                        Title = "Diana and the Journey to the Unknown",
                        Author = "Aisha Saeed",
                        Genre = "Adventure",
                        ISBN = "9790123456789",
                        PublicationDate = DateTime.Parse("2023-09-30"),
                        Pages = 288,
                        CoverImagePath = "/images/b16.jpg"
                    },
                    new BookModel
                    {
                        Title = "Eternal Love",
                        Author = "Louis Moore",
                        Genre = "Romance",
                        ISBN = "9789876543210",
                        PublicationDate = DateTime.Parse("2023-08-18"),
                        Pages = 240,
                        CoverImagePath = "/images/b17.jpg"
                    },
                    new BookModel
                    {
                        Title = "A Mind Over Matter",
                        Author = "Andrew Zangwill",
                        Genre = "Self-Help",
                        ISBN = "9798765432109",
                        PublicationDate = DateTime.Parse("2023-11-28"),
                        Pages = 256,
                        CoverImagePath = "/images/b18.jpg"
                    },
                    new BookModel
                    {
                        Title = "Lost in Translation",
                        Author = "Ella Frances Sanders",
                        Genre = "Contemporary",
                        ISBN = "9780987654321",
                        PublicationDate = DateTime.Parse("2023-04-25"),
                        Pages = 288,
                        CoverImagePath = "/images/b19.jpg"
                    },
                    new BookModel
                    {
                        Title = "The Enchanted Garden Cafe",
                        Author = "Abigail Drake",
                        Genre = "Fantasy",
                        ISBN = "9780123456789",
                        PublicationDate = DateTime.Parse("2023-12-05"),
                        Pages = 320,
                        CoverImagePath = "/images/b20.jpg"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
