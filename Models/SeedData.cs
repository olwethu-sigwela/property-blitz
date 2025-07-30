using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PropertyBlitz.Data;
using System;
using System.Linq;

namespace PropertyBlitz.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PropertyBlitzContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PropertyBlitzContext>>()))
            {
                // Look for any listings..
                if (context.Listing.Any())
                {
                    return;   
                }
                context.Listing.AddRange(
                new Listing
                {
                    Price = 750000,
                    NumBedrooms = 3,
                    Location = "Sandton",
                    Address = "100 Rivonia Road, Sandton",
                    Description = "Incredible deal - limited time only. This beautiful 3 bedroom unit overlooks the scenic Rivonia region of the Sandton area. Enjoy access to a 24/7 shopping centre, a park, and a lake within a 5-minute drive. Don't miss this incredible opportunity for high-class family living!",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 530000,
                    NumBedrooms = 2,
                    Location = "Melville",
                    Address = "22 Main Street, Melville",
                    Description = "A charming 2 bedroom cottage in the heart of Melville. Enjoy the vibrant local cafe culture, weekend markets, and proximity to UJ and Wits. Ideal for young professionals or students looking for a creative and energetic suburb.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 980000,
                    NumBedrooms = 4,
                    Location = "Fourways",
                    Address = "45 Cedar Road, Fourways",
                    Description = "Spacious and modern 4 bedroom home located in the ever-growing Fourways area. Features include an open-plan kitchen, large backyard, and proximity to Montecasino and Fourways Mall. Ideal for families looking for space and accessibility.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 460000,
                    NumBedrooms = 1,
                    Location = "Braamfontein",
                    Address = "12 Juta Street, Braamfontein",
                    Description = "Urban loft-style 1 bedroom apartment, walking distance from Joburg Theatre, Neighbourgoods Market, and multiple universities. Ideal for students or creatives who love the inner-city vibe and convenience.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 1200000,
                    NumBedrooms = 5,
                    Location = "Parkhurst",
                    Address = "88 4th Avenue, Parkhurst",
                    Description = "Elegant 5 bedroom home in Parkhurst with a landscaped garden, entertainment area, and gourmet kitchen. Walking distance from trendy restaurants and boutiques. Perfect for upscale family living with style.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 680000,
                    NumBedrooms = 2,
                    Location = "Rosebank",
                    Address = "77 Tyrwhitt Avenue, Rosebank",
                    Description = "Stylish 2 bedroom apartment in a secure complex just steps from Rosebank Mall and the Gautrain. Perfect for professionals seeking a high-end lock-up-and-go lifestyle in a prime location.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 390000,
                    NumBedrooms = 2,
                    Location = "Soweto",
                    Address = "150 Vilakazi Street, Orlando West, Soweto",
                    Description = "Affordable 2 bedroom family home located in historic Soweto. Close to schools, public transport, and cultural attractions like the Mandela House. A solid investment for first-time buyers.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 845000,
                    NumBedrooms = 3,
                    Location = "Randburg",
                    Address = "60 Malibongwe Drive, Randburg",
                    Description = "Modern 3 bedroom house in a quiet part of Randburg. Features include a spacious lounge, newly renovated kitchen, and secure off-street parking. Perfect for families looking for suburban peace close to the city.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 720000,
                    NumBedrooms = 3,
                    Location = "Linden",
                    Address = "33 7th Street, Linden",
                    Description = "Cozy 3 bedroom home with vintage charm in leafy Linden. Enjoy tree-lined streets, local bakeries, and a strong community vibe. Ideal for young families or creatives.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 590000,
                    NumBedrooms = 2,
                    Location = "Kensington",
                    Address = "105 Queen Street, Kensington",
                    Description = "A well-maintained 2 bedroom property in historic Kensington. Features a large garden, original wood floors, and easy access to Eastgate Mall and major highways. A classic Joburg gem.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 630000,
                    NumBedrooms = 3,
                    Location = "Auckland Park",
                    Address = "19 Kingsway Avenue, Auckland Park",
                    Description = "This 3 bedroom unit is ideally situated near SABC, universities, and Milpark Hospital. A great option for professionals, lecturers, or health workers looking for location and space.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 875000,
                    NumBedrooms = 3,
                    Location = "Midrand",
                    Address = "210 Lever Road, Midrand",
                    Description = "A contemporary 3 bedroom home in fast-growing Midrand. Enjoy modern finishes, secure parking, and easy access to the N1. Ideal for professionals commuting between Johannesburg and Pretoria.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 450000,
                    NumBedrooms = 2,
                    Location = "Yeoville",
                    Address = "88 Raleigh Street, Yeoville",
                    Description = "Budget-friendly 2 bedroom flat in Yeoville, perfect for inner-city dwellers or investors. Close to local shops, transport, and downtown Johannesburg.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 1100000,
                    NumBedrooms = 4,
                    Location = "Greenside",
                    Address = "18 Gleneagles Road, Greenside",
                    Description = "A stunning 4 bedroom home in trendy Greenside with open-plan living, outdoor entertainment area, and top-rated schools nearby. The perfect blend of urban style and suburban space.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 710000,
                    NumBedrooms = 2,
                    Location = "Ferndale",
                    Address = "56 Oxford Road, Ferndale",
                    Description = "Lock-up-and-go 2 bedroom unit in central Ferndale. Features include a balcony, open kitchen, and secure access. A popular choice for young couples and first-time buyers.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                },
                new Listing
                {
                    Price = 930000,
                    NumBedrooms = 4,
                    Location = "Observatory",
                    Address = "2 Observatory Avenue, Observatory",
                    Description = "Spacious 4 bedroom heritage home near Observatory Girls’ School. Features high ceilings, original fireplaces, and a large yard. A blend of historic charm and family practicality.",
                    ImageURL = "https://images.unsplash.com/photo-1572120360610-d971b9d7767c?q=80&w=1170"
                }
            );

                context.SaveChanges();
            }
        }

    }
}
