using Microsoft.EntityFrameworkCore;
using System;

namespace UrbanZoo.Models
{
  public class UrbanZooContext : DbContext
  {
    public UrbanZooContext(DbContextOptions<UrbanZooContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

      builder.Entity<Feature>()
           .HasData(
              new Feature{	FeatureId  = 1,	 UserId  = 4,	CreatedDate = DateTime.Now,	Title = "Chicken Coup",	Description = "Owners welcome public feeding",	Availability = true,	StreetAddress = "SE 47th & SE rural",	City = "Portland",	State = "OR",	Lat = 45.4719015,	Lng = -122.6145719,	 Zipcode  = "97211"	},
              new Feature{	FeatureId  = 2,	 UserId  = 3,	CreatedDate = DateTime.Now,	Title = "Chicken Coup",	Description = "Owners welcome public feeding",	Availability = true,	StreetAddress = "SE 44th & SE Tolman",	City = "Portland",	State = "OR",	Lat = 45.4770279,	Lng = -122.6174991,	 Zipcode  = "98682"	},
              new Feature{	FeatureId  = 3,	 UserId  = 3,	CreatedDate = DateTime.Now,	Title = "Chicken Coup",	Description = "Can't feed the chickens",	Availability = true,	StreetAddress = "SE 45th Ave & SE Harold St",	City = "Portland",	State = "OR",	Lat = 45.4827529,	Lng = 122.6164548,	 Zipcode  = "97266"	},
              new Feature{	FeatureId  = 4,	 UserId  = 2,	CreatedDate = DateTime.Now,	Title = "Chicken Coup",	Description = "Owners welcome public feeding",	Availability = true,	StreetAddress = "5119 SE 46th Ave",	City = "Portland",	State = "OR",	Lat = 45.4860228,	Lng = -122.6154899,	 Zipcode  = "98660"	},
              new Feature{	FeatureId  = 5,	 UserId  = 1,	CreatedDate = DateTime.Now,	Title = "Chicken Coup",	Description = "Owners welcome public feeding",	Availability = true,	StreetAddress = "5980 SE Steele St",	City = "Portland",	State = "OR",	Lat = 45.4846498,	Lng = -122.602384,	 Zipcode  = "97211"	},
              new Feature{	FeatureId  = 6,	 UserId  = 4,	CreatedDate = DateTime.Now,	Title = "Chickens and Ducks",	Description = "Owners welcome public feeding",	Availability = true,	StreetAddress = "4816 SE 50th Ave",	City = "Portland",	State = "OR",	Lat = 45.4876879,	Lng = -122.6109854,	 Zipcode  = "98685"	},
              new Feature{	FeatureId  = 7,	 UserId  = 1,	CreatedDate = DateTime.Now,	Title = "Goat and Pig",	Description = "Behind chain linked fence",	Availability = true,	StreetAddress = "4536 SE 65th Ave",	City = "Portland",	State = "OR",	Lat = 45.4895937,	Lng = -122.5959313,	 Zipcode  = "97225"	},
              new Feature{	FeatureId  = 8,	 UserId  = 5,	CreatedDate = DateTime.Now,	Title = "PDX Lego MiniFig Exchange",	Description = "Bring minifigs to trade. On telephone poll near address listed https://www.instagram.com/portlandminifigs/?hl=en",	Availability = true,	StreetAddress = "SE 42nd Ave & SE Cora St",	City = "Portland",	State = "OR",	Lat = 45.4915052,	Lng = -122.6190095,	 Zipcode  = "97068"	},
              new Feature{	FeatureId  = 9,	 UserId  = 6,	CreatedDate = DateTime.Now,	Title = "Secret passage way",	Description = "Back alley path with large branches to climb on",	Availability = true,	StreetAddress = "4700 SE 50th Ave",	City = "Portland",	State = "OR",	Lat = 45.4876876,	Lng = -122.6109854,	 Zipcode  = "97231"	},
              new Feature{	FeatureId  = 10,	 UserId  = 2,	CreatedDate = DateTime.Now,	Title = "Rose tunnel ",	Description = "Rose bushes growing over sidewalk. Smells good in summer",	Availability = true,	StreetAddress = "6417 SE Steele St",	City = "Portland",	State = "OR",	Lat = 45.4844941,	Lng = -122.5972208,	 Zipcode  = "97218"	},
              new Feature{	FeatureId  = 11,	 UserId  = 2,	CreatedDate = DateTime.Now,	Title = "Fairy tunnel ",	Description = "Arborvitae 'tunnel' over sidewalk with toys inside",	Availability = true,	StreetAddress = "4601 SE Raymond St",	City = "Portland",	State = "OR",	Lat = 45.4866872,	Lng = -122.6147603,	 Zipcode  = "97218"	},
              new Feature{	FeatureId  = 12,	 UserId  = 6,	CreatedDate = DateTime.Now,	Title = "PDX Diorama",	Description = "Diorama featuring dinosaurs and friends. https://www.instagram.com/pdxdinorama/?hl=en",	Availability = true,	StreetAddress = "SE 78th Ave & SE Morrison St",	City = "Portland",	State = "OR",	Lat = 45.5168197,	Lng = -122.5854467,	 Zipcode  = "97218"	}
          );
    }
    public DbSet<Feature> Features { get; set; }
  }
}